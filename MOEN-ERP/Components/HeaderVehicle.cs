using DevExpress.ClipboardSource.SpreadsheetML;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.RawData;
using MOEN_ERP.Models.ViewModel.MeetingRoomBooking;
using MOEN_ERP.Services.Repository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Newtonsoft.Json;

namespace MOEN_ERP.Components
{
    public class HeaderVehicle : ViewComponent
    {
        private readonly IVehicleNotificationsService _noti;
        public HeaderVehicle(IVehicleNotificationsService noti) {
            _noti = noti;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var res = new List<VSystemNotificationVehicle>();
            var curUser = new Appz(HttpContext).CurrentSignInUser;
            if (curUser != null)
            {
               
                var resApi = await _noti.GetVehicleNotificationsListAsync(curUser?.Officer?.Id ?? 0, curUser?.UserRole?.Id ?? 0);
                if (resApi.Type == ApiResultsType.success.ToString())
                {
                    res = JsonConvert.DeserializeObject<List<VSystemNotificationVehicle>>((string)resApi.Data);
                }


                return View(res);
            }
            else
            {
                return View(HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme));
            }
               
        }

    }
}
