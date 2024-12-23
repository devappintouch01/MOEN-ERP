using DevExpress.ClipboardSource.SpreadsheetML;
using MOEN_ERP.Components;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using MOEN_ERP.Services;
using MOEN_ERP.Services.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace MOEN_ERP.Controllers
{
    public class MeetingRoomDashboardController : Controller
    {
        private readonly ITokenService _tokenService;
        private readonly SettingsModel _settings;
        private readonly HttpClient _httpClient;
        private readonly ISystemService _systemService;

        public MeetingRoomDashboardController(HttpClient httpClient, ITokenService tokenService, IOptions<SettingsModel> options, ISystemService systemService)
        {
            //Logz.AddLog("start dashboard class");

            _systemService = systemService;             
            _settings = options.Value;
            _tokenService = tokenService;

            _httpClient = httpClient;
            string contentType = "application/json";
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
            var userAgent = "d-fens HttpClient";
            _httpClient.DefaultRequestHeaders.Add("User-Agent", userAgent);

            //Logz.AddLog("finish started dashboard class");
        }


        public async Task<IActionResult> Dashboard()
        {
            

            #region Check SystemInfoName
            var userCur = new Appz(HttpContext)?.CurrentSignInUser;
            if (userCur?.SystemInfo?.SystemInfoName != "MeetingRoomBooking")
            {
                return RedirectToAction("SignIn", "Authen");
            }
            #endregion
            var model = new DashboardMeeting();
            //var token = await _tokenService.GetTokenAsync();
            
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {userCur?.UserToken}");

            var response = await _httpClient.GetAsync(_settings.BaseUrlApi + $"/Dashboard/GetDashboarMeeting");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                model = JsonConvert.DeserializeObject<DashboardMeeting>(json) ?? new DashboardMeeting();
            }

           
            
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> GetTableVDashboardMeetingRoom()
        {
            var model = new List<VMeetingRoom>();
            //var token = await _tokenService.GetTokenAsync();
            var userCur = new Appz(HttpContext)?.CurrentSignInUser;
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {userCur?.UserToken}");

            var response = await _httpClient.GetAsync(_settings.BaseUrlApi + $"/Dashboard/GetTableVDashboardMeetingRoom");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                model = JsonConvert.DeserializeObject<List<VMeetingRoom>>(json) ?? new List<VMeetingRoom>();
            }
            return PartialView("_mdlTableVDashboardMeetingRoom", model);
        }
        [HttpPost]
        public async Task<IActionResult> GetTableAudioVisualService()
        {
            var model = new List<VAudioVisualService>();
            //var token = await _tokenService.GetTokenAsync();
            var userCur = new Appz(HttpContext)?.CurrentSignInUser;
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {userCur?.UserToken}");

            var response = await _httpClient.GetAsync(_settings.BaseUrlApi + $"/Dashboard/GetTableAudioVisualService");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                model = JsonConvert.DeserializeObject<List<VAudioVisualService>>(json) ?? new List<VAudioVisualService>();
            }
            return PartialView("_mdlTableAudioVisualService", model);
        }
        [HttpPost]
        public async Task<IActionResult> GetTableCateringRestaurant()
        {
            var model = new List<VDashboardCateringRestaurant>();
            //var token = await _tokenService.GetTokenAsync();
            var userCur = new Appz(HttpContext)?.CurrentSignInUser;
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {userCur?.UserToken}");

            var response = await _httpClient.GetAsync(_settings.BaseUrlApi + $"/Dashboard/GetTableCateringRestaurant");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                model = JsonConvert.DeserializeObject<List<VDashboardCateringRestaurant>>(json) ?? new List<VDashboardCateringRestaurant>();
            }
            return PartialView("_mdlTableCateringRestaurant", model);
        }
        [HttpPost]
        public async Task<IActionResult> GetTableVideoConferenceLicense()
        {
            var model = new List<VVideoConferenceLicense>();
            // var token = await _tokenService.GetTokenAsync();
            var userCur = new Appz(HttpContext)?.CurrentSignInUser;
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {userCur?.UserToken}");

            var response = await _httpClient.GetAsync(_settings.BaseUrlApi + $"/Dashboard/GetTableVideoConferenceLicense");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                model = JsonConvert.DeserializeObject<List<VVideoConferenceLicense>>(json) ?? new List<VVideoConferenceLicense>();
            }
            return PartialView("_mdlTableVideoConferenceLicense", model);
        }
    }
    
}
