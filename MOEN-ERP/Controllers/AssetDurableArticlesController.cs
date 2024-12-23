using MOEN_ERP.Services.Repository;
using MOEN_ERP.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace MOEN_ERP.Controllers
{
    [Authorize]
    public class AssetDurableArticlesController : Controller
    {
        private readonly IDropdowns _dropdowns;
        private readonly IDataService _data;
        private readonly IRawDataService _rawdata;
        private readonly IMasterService _masterData;
        private readonly IAttachFileService _attachFile;

        public AssetDurableArticlesController(IDropdowns dropdowns, IDataService data, IRawDataService rawdata, IMasterService masterData, IAttachFileService attachFile)
        {
            _dropdowns = dropdowns;
            _data = data;
            _rawdata = rawdata;
            _masterData = masterData;
            _attachFile = attachFile;
        }

        public async Task<IActionResult> AssetDurableArticlesList()
        {
            return View();
        }

        public async Task<IActionResult> AssetDurableArticlesDetail()
        {
            return View();
        }

    }
}
