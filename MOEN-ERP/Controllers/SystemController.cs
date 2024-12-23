using MOEN_ERP.Models.ViewModel;
using MOEN_ERP.Services.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using MOEN_ERP.DAL.Models;
using DevExpress.XtraRichEdit.Import.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using System.Text;
using DevExpress.ClipboardSource.SpreadsheetML;

namespace MOEN_ERP.Controllers
{
    //[Authorize]
    public class SystemController : Controller
    {
        private readonly IDataService _data;
        private readonly IRawDataService _rawData;
        private readonly HttpClient _httpClient;
        private readonly SettingsModel _settingsModels;
        public SystemController(IDataService data, IRawDataService rawData, HttpClient httpClient, IOptions<SettingsModel> option)
        {
            _data = data;
            _rawData = rawData;
            _httpClient = httpClient;
            _settingsModels = option.Value;
        }
        public async Task<IActionResult> ChooseSystem()
        {
            var account = new Appz(HttpContext).CurrentSignInUser;
            account.SystemInfo = null;
            //account.UserRole = null;
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, JsonConvert.SerializeObject(account)),
                };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

            new Appz(HttpContext).CurrentSignInUser = account;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChooseSystem(ChooseSystem data)
        {
            if (data.SystemInfoId != null)
            {
                var account = new Appz(HttpContext).CurrentSignInUser;

                var userRoleList = (await _rawData.GetViewSystemUserRoleAssignListAsync(new VSystemUserRoleAssign { SystemUserId = account?.User?.Id })).OrderByDescending(x => x.Priority).ToList();

                var userRoleBySystemMenuGroupList = new List<SystemRole>();
                var userRoleIdList = new List<int>();
                var userRoleAssingList = new List<VSystemUserRoleAssign>();

                switch (data.SystemInfoId)
                {
                    case 1:
                        account.SystemInfo = SystemInfo.MasterManagementSystem;

                        //--เช็ค Role User
                        if (userRoleList.Count() > 0 && userRoleList.Where(x => x.SystemRoleId == 1).Count() > 0)
                        {
                            //--Admin
                            account.UserRole = await _data.GetSystemRoleAsync(1);
                        }
                        else
                        {
                            //--Other
                            userRoleBySystemMenuGroupList = await _data.GetSystemRoleBySystemMenuGroupListAsync((int)data.SystemInfoId);
                            userRoleIdList = userRoleBySystemMenuGroupList.Select(x => x.Id).Where(xList => userRoleList.Select(x => x.SystemRoleId).Any(xGroup => xGroup == xList)).ToList();
                            if (userRoleIdList.Count() > 0)
                            {
                                userRoleAssingList = userRoleList.Where(x => userRoleIdList.Contains(x.SystemRoleId ?? 0)).ToList();
                                if (userRoleAssingList.Count() > 0)
                                {
                                    account.UserRole = userRoleBySystemMenuGroupList.Where(x => x.Id == userRoleAssingList.OrderByDescending(x => x.Priority).FirstOrDefault().SystemRoleId).FirstOrDefault();
                                }
                                //account.UserRole = userRoleBySystemMenuGroupList.Where(x => x.Id == userRoleIdList.FirstOrDefault()).FirstOrDefault();

                            }
                        }
                        break;
                    case 2:
                        account.SystemInfo = SystemInfo.BudgetingSystem;

                        //--เช็ค Role User
                        if (userRoleList.Count() > 0 && userRoleList.Where(x => x.SystemRoleId == 1).Count() > 0)
                        {
                            //--Admin
                            account.UserRole = await _data.GetSystemRoleAsync(1);
                        }
                        else
                        {
                            //--Other
                            userRoleBySystemMenuGroupList = await _data.GetSystemRoleBySystemMenuGroupListAsync((int)data.SystemInfoId);
                            userRoleIdList = userRoleBySystemMenuGroupList.Select(x => x.Id).Where(xList => userRoleList.Select(x => x.SystemRoleId).Any(xGroup => xGroup == xList)).ToList();
                            if (userRoleIdList.Count() > 0)
                            {
                                userRoleAssingList = userRoleList.Where(x => userRoleIdList.Contains(x.SystemRoleId ?? 0)).ToList();
                                if (userRoleAssingList.Count() > 0)
                                {
                                    account.UserRole = userRoleBySystemMenuGroupList.Where(x => x.Id == userRoleAssingList.OrderByDescending(x => x.Priority).FirstOrDefault().SystemRoleId).FirstOrDefault();
                                }
                                //account.UserRole = userRoleBySystemMenuGroupList.Where(x => x.Id == userRoleIdList.FirstOrDefault()).FirstOrDefault();

                            }
                        }
                        break;
                    case 3:
                        account.SystemInfo = SystemInfo.ProjectMonitoringSystem;

                        //--เช็ค Role User
                        if (userRoleList.Count() > 0 && userRoleList.Where(x => x.SystemRoleId == 1).Count() > 0)
                        {
                            //--Admin
                            account.UserRole = await _data.GetSystemRoleAsync(1);
                        }
                        else
                        {
                            //--Other
                            userRoleBySystemMenuGroupList = await _data.GetSystemRoleBySystemMenuGroupListAsync((int)data.SystemInfoId);
                            userRoleIdList = userRoleBySystemMenuGroupList.Select(x => x.Id).Where(xList => userRoleList.Select(x => x.SystemRoleId).Any(xGroup => xGroup == xList)).ToList();
                            if (userRoleIdList.Count() > 0)
                            {
                                userRoleAssingList = userRoleList.Where(x => userRoleIdList.Contains(x.SystemRoleId ?? 0)).ToList();
                                if (userRoleAssingList.Count() > 0)
                                {
                                    account.UserRole = userRoleBySystemMenuGroupList.Where(x => x.Id == userRoleAssingList.OrderByDescending(x => x.Priority).FirstOrDefault().SystemRoleId).FirstOrDefault();
                                }

                                //account.UserRole = userRoleBySystemMenuGroupList.Where(x => x.Id == userRoleIdList.FirstOrDefault()).FirstOrDefault();

                            }
                        }
                        break;
                    case 4:
                        account.SystemInfo = SystemInfo.InventoryManagementSystem;

                        //--เช็ค Role User
                        if (userRoleList.Count() > 0 && userRoleList.Where(x => x.SystemRoleId == 1).Count() > 0)
                        {
                            //--Admin
                            account.UserRole = await _data.GetSystemRoleAsync(1);
                        }
                        else
                        {
                            //--Other
                            userRoleBySystemMenuGroupList = await _data.GetSystemRoleBySystemMenuGroupListAsync((int)data.SystemInfoId);
                            userRoleIdList = userRoleBySystemMenuGroupList.Select(x => x.Id).Where(xList => userRoleList.Select(x => x.SystemRoleId).Any(xGroup => xGroup == xList)).ToList();
                            if (userRoleIdList.Count() > 0)
                            {
                                userRoleAssingList = userRoleList.Where(x => userRoleIdList.Contains(x.SystemRoleId ?? 0)).ToList();
                                if (userRoleAssingList.Count() > 0)
                                {
                                    account.UserRole = userRoleBySystemMenuGroupList.Where(x => x.Id == userRoleAssingList.OrderByDescending(x => x.Priority).FirstOrDefault().SystemRoleId).FirstOrDefault();
                                }
                                //account.UserRole = userRoleBySystemMenuGroupList.Where(x => x.Id == userRoleIdList.FirstOrDefault()).FirstOrDefault();

                            }
                        }
                        break;
                    case 5:
                        account.SystemInfo = SystemInfo.ExecutiveReportingSystem;

                        //--เช็ค Role User
                        if (userRoleList.Count() > 0 && userRoleList.Where(x => x.SystemRoleId == 1).Count() > 0)
                        {
                            //--Admin
                            account.UserRole = await _data.GetSystemRoleAsync(1);
                        }
                        else
                        {
                            //--Other
                            userRoleBySystemMenuGroupList = await _data.GetSystemRoleBySystemMenuGroupListAsync((int)data.SystemInfoId);
                            userRoleIdList = userRoleBySystemMenuGroupList.Select(x => x.Id).Where(xList => userRoleList.Select(x => x.SystemRoleId).Any(xGroup => xGroup == xList)).ToList();
                            if (userRoleIdList.Count() > 0)
                            {
                                userRoleAssingList = userRoleList.Where(x => userRoleIdList.Contains(x.SystemRoleId ?? 0)).ToList();
                                if (userRoleAssingList.Count() > 0)
                                {
                                    account.UserRole = userRoleBySystemMenuGroupList.Where(x => x.Id == userRoleAssingList.OrderByDescending(x => x.Priority).FirstOrDefault().SystemRoleId).FirstOrDefault();
                                }
                                //account.UserRole = userRoleBySystemMenuGroupList.Where(x => x.Id == userRoleIdList.FirstOrDefault()).FirstOrDefault();

                            }
                        }
                        break;
                }


                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, JsonConvert.SerializeObject(account)),
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                new Appz(HttpContext).CurrentSignInUser = account;

                return RedirectToAction("SignIn", "Authen");
            }
            else
            {
                return RedirectToAction("ChooseSystem", "System");
            }
        }

        public IActionResult UserManage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UserManage(VSystemUser model)
        {
            var data = new List<VSystemUser>();
            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/System/GetListUser?Username={model.Username}&FirstName={model.FirstName}&LoginType={model.LoginType}&Active={model.Active}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VSystemUser>>(json) ?? new List<VSystemUser>();
            }
            ViewBag.openId = TempData["openId"];
            return PartialView("_tableUserManage", data);
        }
        [HttpPost]
        public async Task<IActionResult> UserDetail(int userId)
        {
            var data = new UserDetailModel { SystemUser = new SystemUser(), VSystemUserRoleAssign = new List<VSystemUserRoleAssign>() };
            if (userId != 0)
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/System/GetUser?Id={userId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<UserDetailModel>(json) ?? new UserDetailModel();
                }
            }
            return PartialView("_modalUserDetail", data);
        }
        [HttpPost]
        public async Task<IActionResult> UserRoleDetail(int roleAssignId, int userId)
        {
            var data = new SystemUserRoleAssign();
            data.SystemUserId = userId;

            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetSystemRoles");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.SystemRoles = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }
            response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/CMB/GetSystemMenuGroups");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewBag.SystemMenuGroups = JsonConvert.DeserializeObject<List<SelectListItem>>(json) ?? new List<SelectListItem>();
            }

            if (roleAssignId != 0)
            {
                response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/System/GetUserRoleAssign?Id={roleAssignId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<SystemUserRoleAssign>(json) ?? new SystemUserRoleAssign();
                }
            }


            return PartialView("_modalUserRole", data);
        }
        [HttpPost]
        public async Task<IActionResult> SaveUserManage(UserDetailModel model, string? typeSubmit)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;
            if (model.SystemUser.Id == 0)
            {
                model.SystemUser.CreateBy = user.User.Id;
                model.SystemUser.CreateOn = DateTime.Now;
            }
            else
            {
                model.SystemUser.UpdateBy = user.User.Id;
                model.SystemUser.UpdateOn = DateTime.Now;
            }

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/System/SaveUser", content);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                if (apiResults.Success)
                {
                    ViewBag.success = "บันทึกสำเร็จ";
                    if (typeSubmit == "open") TempData["openId"] = apiResults.Id;

                }
                else
                {
                    ViewBag.error = apiResults.Message;
                }
            }
            ViewBag.hideModal = "mdlUserDetail";
            return PartialView("_tableUserManage", new List<VSystemUser>());
        }
        [HttpPost]
        public async Task<IActionResult> SaveUserRoleAssign(SystemUserRoleAssign model)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;
            if (model.Id == 0)
            {
                model.CreateBy = user.User.Id;
                model.CreateOn = DateTime.Now;
            }
            else
            {
                model.UpdateBy = user.User.Id;
                model.UpdateOn = DateTime.Now;
            }

            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_settingsModels.BaseUrlApi + "/System/SaveUserSystemUserRoleAssign", content);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                if (apiResults.Success)
                {
                    ViewBag.success = "บันทึกสำเร็จ";
                }
                else
                {
                    ViewBag.error = apiResults.Message;
                }
            }

            response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/System/GetVSystemUserRoleAssign?Id={model.SystemUserId}");
            var lst = new List<VSystemUserRoleAssign>();
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                lst = JsonConvert.DeserializeObject<List<VSystemUserRoleAssign>>(result) ?? new List<VSystemUserRoleAssign>();

            }
            ViewBag.hideModal = "mdlUserDetailRole";

            return PartialView("_tableUserRoleAssign", lst);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteSystemUsers(int userId)
        {
            var user = new Appz(HttpContext).CurrentSignInUser;
            if (user.User.Id == userId) ViewBag.error = "ไม่สามารถลบรหัสของตัวเองได้";
            else if (userId == 1) ViewBag.error = "ไม่สามารถลบ admin ได้";
            else
            {
                var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/System/DeleteUser?userId={userId}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var apiResults = JsonConvert.DeserializeObject<ApiResultsModel>(result) ?? new ApiResultsModel();
                    if (apiResults.Success) ViewBag.success = "ลบข้อมูลผู้ใช้งานสำเร็จ";
                    else ViewBag.error = apiResults.Message;
                }
            }
            ViewBag.hideModal = "";
            return PartialView("_tableUserManage", new List<VSystemUser>());
        }
        [HttpPost]
        public async Task<IActionResult> DeleteUserRole(int roleAssignId)
        {
            var lst = new List<VSystemUserRoleAssign>();

            var response = await _httpClient.GetAsync(_settingsModels.BaseUrlApi + $"/System/DeleteUserRole?roleAssignId={roleAssignId}");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                lst = JsonConvert.DeserializeObject<List<VSystemUserRoleAssign>>(result) ?? new List<VSystemUserRoleAssign>();
                ViewBag.success = "ลบระดับการใช้งานสำเร็จ";
            }
            else ViewBag.error = "เกิดข้อผิดพลาดกรุณาติดต่อ Admin";



            return PartialView("_tableUserRoleAssign", lst);
        }

        public IActionResult SystemMenuRoleAssignManage()
        {
            return View();
        }

    }
}
