using MOEN_ERP.Models.Common;
using MOEN_ERP.Services.Repository;
using MOEN_ERP.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;

namespace MOEN_ERP.Controllers
{
    public class MaterialDashboardController : Controller
    {
        private readonly IDropdowns _dropdowns;
        private readonly IDataService _dataService;
        private readonly IRawDataService _rawData;
        private readonly IMasterService _masterData;
        private readonly IAttachFileService _attachFile;

        private readonly ITokenService _tokenService;
        private readonly SettingsModel _settings;
        private readonly HttpClient _httpClient;

        private readonly ISystemService _systemService;


        public MaterialDashboardController(IDropdowns dropdowns, IDataService dataService, IRawDataService rawData, IMasterService masterData, IAttachFileService attachFile,
            IOptions<SettingsModel> options, HttpClient httpClient, ITokenService tokenService
            , ISystemService systemService)
        {
            //Logz.AddLog("Start meeting room calendar class");
            _dropdowns = dropdowns;
            _dataService = dataService;
            _rawData = rawData;
            _masterData = masterData;
            _attachFile = attachFile;

            _tokenService = tokenService;
            _settings = options.Value;

            _httpClient = httpClient;
            string contentType = "application/json";
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
            var userAgent = "d-fens HttpClient";
            _httpClient.DefaultRequestHeaders.Add("User-Agent", userAgent);
            _systemService = systemService;
            //Logz.AddLog("Finish start meeting room calendar class");
        }

        public async Task<IActionResult> Dashboard()
        {
            return View();
        }
    }
}
