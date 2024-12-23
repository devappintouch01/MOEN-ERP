using DevExpress.ClipboardSource.SpreadsheetML;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.ViewModel.AudioVisualServiceRequest;
using MOEN_ERP.Models.ViewModel.MeetingRoomBooking;
using MOEN_ERP.Services.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MOEN_ERP.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {

        private readonly IDataService _data;
        public AccountController(IDataService data)
        {
            _data = data;
        }
        public async Task<IActionResult> LineManagement()
        {
            var userCur = new Appz(HttpContext)?.CurrentSignInUser;
            var data = new OfficerLineToken();
            try
            {

                var res = await _data.GetOfficerLineTokenAsync(userCur?.Officer?.Id ?? 0);
                if (res.Type == ApiResultsType.success.ToString())
                {
                    data = JsonConvert.DeserializeObject<OfficerLineToken>((string)res.Data);
                }
                else
                {
                    throw new Exception(res.Message);
                }

            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { errorMassage = ex.Message });
            }

            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> EventManageLineToken(OfficerLineToken data)
        {
            var userCur = new Appz(HttpContext)?.CurrentSignInUser;
            var res = new ApiResultsModel();
            try
            {
                data.CreateBy = userCur?.User?.Id;
                data.OfficerId = userCur?.Officer?.Id;
                res = await _data.AddOfficerLineTokenAsync(data);
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
                res.Type = ApiResultsType.error.ToString();
            }
            return Json(res);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteLineToken(int pId)
        {
            var res = await _data.DeleteOfficerLineTokenAsync(pId);
            return Json(res);
        }


    }
}
