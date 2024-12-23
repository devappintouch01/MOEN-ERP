using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using MOEN_ERP.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using MOEN_ERP.DAL.Models;

namespace MOEN_ERP.Controllers
{
    public class VehicleDashboardController : Controller
    {
        private readonly ITokenService _tokenService;
        private readonly SettingsModel _settings;
        private readonly HttpClient _httpClient;

        public VehicleDashboardController(HttpClient httpClient, ITokenService tokenService, IOptions<SettingsModel> options)
        {
            _settings = options.Value;
            _tokenService = tokenService;

            _httpClient = httpClient;
            string contentType = "application/json";
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
            var userAgent = "d-fens HttpClient";
            _httpClient.DefaultRequestHeaders.Add("User-Agent", userAgent);
        }

        public async Task<IActionResult> Dashboard()
        {
            var userCur = new Appz(HttpContext)?.CurrentSignInUser;
            var model = new DashboardVehicle();
            //var token = await _tokenService.GetTokenAsync();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {userCur?.UserToken}");

            var response = await _httpClient.GetAsync(_settings.BaseUrlApi + $"/Dashboard/GetVehicleDashboard");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                model = JsonConvert.DeserializeObject<DashboardVehicle>(json) ?? new DashboardVehicle();
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> GetTableVVehicle()
        {
            var userCur = new Appz(HttpContext)?.CurrentSignInUser;
            var model = new List<VVehicle>();
            //var token = await _tokenService.GetTokenAsync();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {userCur?.UserToken}");

            var response = await _httpClient.GetAsync(_settings.BaseUrlApi + $"/Dashboard/GetTableVVehicle");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                model = JsonConvert.DeserializeObject<List<VVehicle>>(json) ?? new List<VVehicle>();
            }
            return PartialView("_mdlTableVVehicle", model);
        }
        [HttpPost]
        public async Task<IActionResult> GetTableVOfficer()
        {
            var userCur = new Appz(HttpContext)?.CurrentSignInUser;
            var model = new List<VOfficer>();
            //var token = await _tokenService.GetTokenAsync();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {userCur?.UserToken}");

            var response = await _httpClient.GetAsync(_settings.BaseUrlApi + $"/Dashboard/GetTableVOfficer");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                model = JsonConvert.DeserializeObject<List<VOfficer>>(json) ?? new List<VOfficer>();
            }
            return PartialView("_mdlTableVOfficer", model);
        }
    }
}
