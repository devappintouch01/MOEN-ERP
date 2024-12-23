using MOEN_ERP.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using MOEN_ERP.Models.Common;
using Newtonsoft.Json;
using DNTCaptcha.Core;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Components;
using System.Reflection;
using Microsoft.AspNetCore.Http;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Services.Repository;
using MOEN_ERP.Models.RawData;
using MOEN_ERP.Utilities;
using MOEN_ERP.Components;
using System.Net;
using System.Net.Sockets;
using DevExpress.ClipboardSource.SpreadsheetML;
using MOEN_ERP.DAL.Models;

namespace MOEN_ERP.Controllers
{
    public class AuthenController : Controller
    {

        private readonly IAccount _account;
        private readonly IDNTCaptchaValidatorService _captchaService;
        private readonly DNTCaptchaOptions _captchaOption;
        private readonly SettingsModel _settings;
        private readonly IRawDataService _rawData;
        private readonly IDataService _data;
        private readonly IAuthenService _authenService;

        private readonly ISystemService _systemService;
        public AuthenController(IAccount account, IDNTCaptchaValidatorService captchaService, IOptions<DNTCaptchaOptions> captchaOption, IOptions<SettingsModel> options, IRawDataService rawData, IDataService data, ISystemService systemService, IAuthenService authenService)
        {
            _account = account;
            _captchaService = captchaService;
            _captchaOption = captchaOption == null ? throw new ArgumentNullException(nameof(captchaOption)) : captchaOption.Value;
            _settings = options.Value;
            _rawData = rawData;
            _data = data;
            _systemService = systemService;
            _authenService = authenService;
        }

        [HttpGet]
        public async Task<IActionResult> SignIn()
        {
            //Logz.AddLog("Start Sign in (no param)");
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fileVer = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            ViewBag.FileVersion = "V" + fileVer.FileVersion;

            ClaimsPrincipal claimAccount = HttpContext.User;

            if (claimAccount.Identity.IsAuthenticated)
            {
                new Appz(HttpContext).CurrentSignInUser = JsonConvert.DeserializeObject<AccountModel>(claimAccount.Identity.Name);
                var current = JsonConvert.DeserializeObject<AccountModel>(claimAccount.Identity.Name);
                if (current.User != null)
                {
                    if (current.SystemInfo == null)
                    {
                        return RedirectToAction("ChooseSystem", "System");
                    }
                    else
                    {
                        switch (current.SystemInfo.SystemInfoId)
                        {
                            case 1:
                                //Logz.AddLog("Finish Sign in (no param) redirect Meetingroom Calendar");
                                return RedirectToAction("Dashboard", "MaterialDashboard");
                            case 2:
                                //Logz.AddLog("Finish Sign in (no param) redirect Meetingroom Calendar");
                                return RedirectToAction("Dashboard", "MaterialDashboard");
                            case 3:
                                //Logz.AddLog("Finish Sign in (no param) redirect Vehicle Calendar");
                                return RedirectToAction("VehicleDashboard", "VehicleCalendar");
                            case 4:
                                //Logz.AddLog("Finish Sign in (no param) redirect Meetingroom Calendar");
                                return RedirectToAction("Dashboard", "MaterialDashboard");
                            case 5:
                                //Logz.AddLog("Finish Sign in (no param) redirect Meetingroom Calendar");
                                return RedirectToAction("Dashboard", "MaterialDashboard");
                            default:
                                //Logz.AddLog("Finish Sign in (no param) redirect Dashbaoard");
                                return RedirectToAction("Index", "Dashboard");
                        }

                    }
                }
                else
                {
                    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                    //Logz.AddLog("Finish Sign in (no param) redirect to signin");
                    return RedirectToAction("SignIn", "Authen");
                }


            }
            //Logz.AddLog("Finish Sign in (no param)");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(SignInModel model)
        {
            //Logz.AddLog("Start Sign In (with param)");
            if (ModelState.IsValid)
            {



                //if (!_captchaService.HasRequestValidCaptchaEntry(Language.English, DisplayMode.ShowDigits))
                //{
                //    this.ModelState.AddModelError(_captchaOption.CaptchaComponent.CaptchaInputName, "รหัสยืนยันไม่ถูกต้อง");                    
                //    return View("SignIn");
                //}

               

                try
                {

                    // รับชื่อเครื่อง
                    string hostName = Dns.GetHostName();

                    // รับที่อยู่ IP ของเครื่องจากชื่อเครื่อง
                    IPAddress[] addresses = Dns.GetHostAddresses(hostName);
                    // วนลูปเพื่อพิมพ์ IP address ทั้งหมดที่พบ
                    foreach (IPAddress address in addresses)
                    {
                        // พิมพ์เฉพาะ IPv4 address
                        if (address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            //Console.WriteLine("IP Address: " + address.ToString());
                            model.IpAddress = address.ToString();
                        }
                    }

                    //Logz.AddLog($"userName:{model.UserName} || passWord:{model.Password} || remember:{model.RememberMe} || ip:{model.IpAddress}");

                    var accountSignIn = await _authenService.SignInAsync(model);
                    if (accountSignIn?.ApiResults?.Type == ApiResultsType.success.ToString())
                    {
                        accountSignIn.IsAuthenSSO = false;
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, JsonConvert.SerializeObject(accountSignIn)),
                        };

                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                        new Appz(HttpContext).CurrentSignInUser = accountSignIn;

                       

                        //Logz.AddLog("Finish sign in redirect");
                        return RedirectToAction("ChooseSystem", "System");

                    }
                    else
                    {
                        TempData["signinMsg"] = accountSignIn?.ApiResults?.Message;
                       // Logz.AddLog("Finish sign in redirect");
                        return RedirectToAction("SignIn", "Authen");
                    }
                }
                catch (Exception ex)
                {
                    //Logz.AddLog("Finish sign in error");
                    TempData["signinMsg"] = ex.Message;
                    return RedirectToAction("SignIn", "Authen");
                }

            }
            else
            {
                //Logz.AddLog("Finish sign in show view");
                return View("SignIn");
            }


        }

        public async Task<IActionResult> SignOut()
        {
            var userCur = new Appz(HttpContext)?.CurrentSignInUser;
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            //if (userCur != null && userCur.IsAuthenSSO == true && !string.IsNullOrEmpty(userCur.RetrunUrl))
            //{
            //    return Redirect(userCur.RetrunUrl);
            //}
            //else
            //{
                return RedirectToAction("SignIn", "Authen");
            //}

        }


        public async Task<IActionResult> SignOutSSO()
        {
            //Logz.AddLog("Start SSO Sign In"); 
            var userCur = new Appz(HttpContext)?.CurrentSignInUser;
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            if (userCur != null && userCur.IsAuthenSSO == true && !string.IsNullOrEmpty(userCur.RetrunUrl))
            {
               // Logz.AddLog("Finish SSO Sign in success");
                return Redirect(userCur.RetrunUrl);
            }
            else
            {
                //Logz.AddLog("Finish SSO Sign in failed");
                return RedirectToAction("SignIn", "Authen");
            }

        }

        #region SignInSSO
        /// <summary>
        /// 
        /// </summary>
        /// <param name="systeminfo">MeetingRoomBooking = จองห้องประชุม, VehicleBooking = จองรถ</param>
        /// <param name="code"></param>
        /// <param name="refer"></param>
        /// <param name="returnUrl"> ลิงค์กลับหน้า ระบบที่กดเข้ามา</param>
        /// <returns></returns>
        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("[controller]/{action}/{SystemInfo}")]
        public async Task<IActionResult> SignInSSO(string systeminfo, string code, string refer, string returnUrl)
        {
          

            try
            {
                if (string.IsNullOrEmpty(systeminfo) || (systeminfo != "MeetingRoomBooking" && systeminfo != "VehicleBooking"))
                {
                    throw new Exception("ไม่พบระบบเข้าใช้งาน");
                }

                if (string.IsNullOrEmpty(code) && refer != _settings.IntranetUrl)
                {
                    throw new Exception("Url เข้าใช้งานระบบไม่ถูกต้อง");
                }

                string decodedString = AuthenSSO.DecodingFromBase64(code);
                var endIdx = decodedString.IndexOf("ZHRud2Vi");

                if (endIdx <= 0)
                {
                    throw new Exception();
                }

                var encodeUser = decodedString.Substring(8, endIdx - 8);
                string userName = AuthenSSO.DecodingFromBase64(encodeUser);

                var model = new SignInSSOModel
                {
                    UserName = userName,
                    IpAddress = HttpContext?.Connection?.RemoteIpAddress?.ToString() ?? ""
                };


                

                var account = await _account.SignInSSO(model);

                if (account?.ApiResults?.Type == ApiResultsType.success.ToString())
                {
                    account.IsAuthenSSO = true;
                    account.RetrunUrl = returnUrl;


                    var claimsLoginSuccess = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, JsonConvert.SerializeObject(account)),
                        };

                    var claimsIdentityLoginSuccess = new ClaimsIdentity(claimsLoginSuccess, CookieAuthenticationDefaults.AuthenticationScheme);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentityLoginSuccess));

                    new Appz(HttpContext).CurrentSignInUser = account;

                    //var userRoleList = (await _rawData.GetViewSystemUserRoleAssignListAsync(new VSystemUserRoleAssign { SystemUserId = accountSignIn?.User?.Id })).OrderByDescending(x => x.Priority).ToList();
                    //var userRoleBySystemMenuGroupList = new List<SystemRole>();
                    //var userRoleIdList = new List<int?>();
                    //var userRoleAssingList = new List<VSystemUserRoleAssign>();

                    var userRoleList = (await _rawData.GetViewSystemUserRoleAssignListAsync(new VSystemUserRoleAssign { SystemUserId = account?.User?.Id })).OrderByDescending(x => x.Priority).ToList();

                    var userRoleBySystemMenuGroupList = new List<SystemRole>();
                    var userRoleIdList = new List<int>();
                    var userRoleAssingList = new List<VSystemUserRoleAssign>();

                    switch (systeminfo)
                    {
                        case "MasterManagementSystem":
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
                                userRoleBySystemMenuGroupList = await _data.GetSystemRoleBySystemMenuGroupListAsync(2) ;
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

                            //accountSignIn.SystemInfo = SystemInfo.MeetingRoomBooking;
                            //userRoleBySystemMenuGroupList = await _data.GetSystemRoleBySystemMenuGroupListAsync(2);
                            break;

                        case "BudgetingSystem":
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
                                userRoleBySystemMenuGroupList = await _data.GetSystemRoleBySystemMenuGroupListAsync(2);
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

                            //accountSignIn.SystemInfo = SystemInfo.MeetingRoomBooking;
                            //userRoleBySystemMenuGroupList = await _data.GetSystemRoleBySystemMenuGroupListAsync(2);
                            break;

                        case "ProjectMonitoringSystem":

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
                                userRoleBySystemMenuGroupList = await _data.GetSystemRoleBySystemMenuGroupListAsync(3);
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
                            //accountSignIn.SystemInfo = SystemInfo.VehicleBooking;
                            //userRoleBySystemMenuGroupList = await _data.GetSystemRoleBySystemMenuGroupListAsync(3);
                            break;
                    }

                    //if (userRoleList.Count() > 0 && userRoleList.Any(x => x.SystemRoleId == 1))
                    //{


                    //    accountSignIn.UserRole = await _data.GetSystemRoleAsync(1);
                    //}
                    //else
                    //{



                    //    userRoleIdList = userRoleBySystemMenuGroupList
                    //        .Select(x => x.Id)
                    //        .Where(xList => userRoleList.Select(x => x.SystemRoleId).Any(xGroup => xGroup == xList))
                    //        .ToList();

                    //    if (userRoleIdList.Count() > 0)
                    //    {
                    //        userRoleAssingList = userRoleList.Where(x => userRoleIdList.Contains(x.SystemRoleId)).ToList();
                    //        if (userRoleAssingList.Count() > 0)
                    //        {
                    //            accountSignIn.UserRole = userRoleBySystemMenuGroupList.Where(x => x.Id == userRoleAssingList.OrderByDescending(x => x.Priority).FirstOrDefault().SystemRoleId).FirstOrDefault();
                    //        }
                    //        //accountSignIn.UserRole = userRoleBySystemMenuGroupList.FirstOrDefault(x => x.Id == userRoleIdList.FirstOrDefault());
                    //    }
                    //}

                    //var claims = new List<Claim>{new Claim(ClaimTypes.Name, JsonConvert.SerializeObject(accountSignIn))};

                    //var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    //await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                    //new Appz(HttpContext).CurrentSignInUser = accountSignIn;

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
                    var userCur = new Appz(HttpContext)?.CurrentSignInUser;
                    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

                    TempData["signinMsg"] = account?.ApiResults?.Message;
                    return RedirectToAction("SignIn", "Authen");
                }
            }
            catch (Exception ex)
            {
                var userCur = new Appz(HttpContext)?.CurrentSignInUser;
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

                TempData["signinMsg"] = ex.Message;
                return RedirectToAction("SignIn", "Authen");
            }

        }
        #endregion


    }
}
