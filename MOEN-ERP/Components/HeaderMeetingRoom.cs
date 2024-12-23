using MOEN_ERP.Models.Common;
using MOEN_ERP.Services.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using MOEN_ERP.Models.RawData;

namespace MOEN_ERP.Components
{
    public class HeaderMeetingRoom : ViewComponent
    {
        private readonly IMeetingNotificationsService _noti;
        public HeaderMeetingRoom(IMeetingNotificationsService noti) {
            _noti = noti;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //Logz.AddLog("Start meeting notify");
            var res = new List<VSystemNotificationMeetingRoom>();
            var curUser = new Appz(HttpContext).CurrentSignInUser;
            if (curUser != null)
            {
                //Logz.AddLog("Start meeting notify get data");
                var resApi = await _noti.GetMeetingNotificationsListAsync(curUser?.Officer?.Id ?? 0, curUser?.UserRole?.Id ?? 0);
                if (resApi.Type == ApiResultsType.success.ToString())
                {
                    res = JsonConvert.DeserializeObject<List<VSystemNotificationMeetingRoom>>((string)resApi.Data);
                }

               // Logz.AddLog("Finish meeting notify");
                return View(res);
            }
            else
            {
                return View(HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme));
            }

        }


    }
}
