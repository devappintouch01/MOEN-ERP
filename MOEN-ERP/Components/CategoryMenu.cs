using MOEN_ERP.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using MOEN_ERP.Services.Repository;
using MOEN_ERP.Models.ViewModel;

namespace MOEN_ERP.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly IRawDataService _rawData;
        //private readonly ICategoryMenu menus;
        private readonly IHttpContextAccessor requestHttp;
        public CategoryMenu(IRawDataService rawData, IHttpContextAccessor _requestHttp) {
            //menus = _menus;
            _rawData = rawData;
            requestHttp = _requestHttp;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //Logz.AddLog("Start menu");
            var curUser = new Appz(HttpContext).CurrentSignInUser;
            if (curUser != null)
            {
                //Logz.AddLog("Start menu get data");
                var menuList = await _rawData.GetFunctionSystemMenuListAsync(new FunctionSystemMenu { SystemRoleId = curUser?.UserRole?.Id, SystemMenuGroupId = curUser?.SystemInfo?.SystemInfoId });
              

                var activeMenu = requestHttp.HttpContext.Request.Path.Value.ToString().Remove(0, 1).Split('/');
                var checkIndex = requestHttp.HttpContext.Request.Path.Value.ToString().Remove(0, 1).IndexOf("/");

                ViewBag.ControllerMain = menuList.FirstOrDefault(x =>
                x.ControllerName == activeMenu[0].ToString()
                && x.ActionName == (checkIndex < 0 ? "Index" : activeMenu[1].ToString())
                )?.ControllerMainName;

                ViewBag.Controller = activeMenu[0].ToString();

                ViewBag.Action = checkIndex < 0 ? "Index" : activeMenu[1].ToString();

                //Logz.AddLog("Finish menu");

                return View(menuList.OrderBy(x => x.Sequence).ToList());
            }
            else
            {
                return View(HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme));
            }
            
        }


    }
}
