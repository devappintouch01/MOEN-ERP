using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Common;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Security.Cryptography;
using Novell.Directory.Ldap;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;

namespace MOEN_ERP.API.Services.Repository
{
    public interface IAuthenService
    {
        public Task<MOEN_ERP.Models.Common.AccountModel> SignInAsync(MOEN_ERP.Models.Common.SignInModel data);
        public Task<MOEN_ERP.Models.Common.AccountModel> SignInSSOAsync(MOEN_ERP.Models.Common.SignInSSOModel data);
        public string GetEncrypt(string zStr);
    }
    public class AuthenService : IAuthenService
    {
        private IJwtTokenManager _tokenManager;
        MOENDBContext context;
        public AuthenService(MOENDBContext _context, IJwtTokenManager tokenManager)
        {
            context = _context;
            _tokenManager = tokenManager;
        }

        public async Task<MOEN_ERP.Models.Common.AccountModel> SignInAsync(MOEN_ERP.Models.Common.SignInModel data)
        {
            //Logz.AddLog("Start Sign In Api (with service)");

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            var isDevelopment = configuration.GetValue<bool?>("DTNBOOKINGAPISettings:DevelopmentMode");
            var optionsBuilder = new DbContextOptionsBuilder<MOENDBContext>();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MOENDBContext"));


            var res = new MOEN_ERP.Models.Common.AccountModel();


            //--

            res.User = new SystemUser();
            res.Officer = new VOfficer();
            res.ApiResults = new MOEN_ERP.Models.Common.ApiResultsModel();
            try
            {
                //Logz.AddLog("Start Sign In Api (try)");

                var user = await context.SystemUsers.FirstOrDefaultAsync(x => x.Username == data.UserName);

                if (user == null) throw new Exception("ไม่พบรหัสเข้าใช้งาน");


                if (user.LoginType == "A")
                {
                    //--AD
                    if (isDevelopment != true)
                    {
                        string host = "dtn.moc.go.th";
                        int port = 389;
                        if (string.IsNullOrEmpty(host)) throw new Exception("ไม่สามารถเชื่อมต่อ Active Directory ได้");
                        var conn = new LdapConnection();
                        conn.ConnectAsync(host, port);
                        string aduser = string.Format("{0}@{1}", data.UserName, "dtn.moc.go.th");
                        conn.BindAsync(aduser, data.Password);

                    }
                    //--AD End.
                }
                else
                {
                    if (GetEncrypt(data.Password) != user.Password) throw new Exception("รหัสผ่านไม่ถูกต้อง");
                }





                //Logz.AddLog("Update Login SystemUser");
                #region Update Login SystemUser
                user.LastIpaddress = data.IpAddress;
                user.LastLogin = DateTime.Now;
                await context.SaveChangesAsync();
                #endregion
                //Logz.AddLog("Finish Update Login SystemUser");


                //Logz.AddLog("Start Get SystemUser To Model");
                res.User = new SystemUser
                {
                    Id = user.Id,
                    CreateBy = user.CreateBy,
                    CreateOn = user.CreateOn,
                    UpdateBy = user.UpdateBy,
                    UpdateOn = user.UpdateOn,
                    Username = user.Username,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                };
                //Logz.AddLog("Finish Get SystemUser To Model");

                int distinctRole = (await context.VSystemUserRoleAssigns
                                    .Where(x => x.SystemUserId == user.Id)
                                    .Select(x => x.SystemRoleId)
                                    .Distinct()
                                    .FirstAsync()) ?? default(int);

                res.UserRole = await context.SystemRoles.FirstOrDefaultAsync(x => x.Id == distinctRole) ?? new MOEN_ERP.DAL.Models.SystemRole();
                //Logz.AddLog("Finish Get VOfficer To Model");

                //Logz.AddLog("Start Get Token To Model");
                res.UserToken = _tokenManager.Authenticate(data.UserName, data.Password);
                //Logz.AddLog("Finish Get Token To Model");

                res.ApiResults.Type = ApiResultsType.success.ToString();
            }
            catch (Exception ex)
            {
                //Logz.AddLog("Finish Sign In Api (with service) Error");
                res.ApiResults.Type = ApiResultsType.error.ToString();
                res.ApiResults.Message = ex.Message;
            }


            //--
            //Logz.AddLog("Finish Sign In Api (with service) Success");

            return res;
        }

        public async Task<MOEN_ERP.Models.Common.AccountModel> SignInSSOAsync(MOEN_ERP.Models.Common.SignInSSOModel data)
        {

            var res = new MOEN_ERP.Models.Common.AccountModel();
            res.User = new SystemUser();
            res.Officer = new VOfficer();
            res.ApiResults = new MOEN_ERP.Models.Common.ApiResultsModel();
            try
            {

                var user = await context.SystemUsers.FirstOrDefaultAsync(x => x.Username == data.UserName);

                if (user == null) throw new Exception("ไม่พบรหัสเข้าใช้งาน");




                #region Update Login SystemUser
                user.LastIpaddress = data.IpAddress;
                user.LastLogin = DateTime.Now;
                await context.SaveChangesAsync();
                #endregion

                res.User = new SystemUser
                {
                    Id = user.Id,
                    CreateBy = user.CreateBy,
                    CreateOn = user.CreateOn,
                    UpdateBy = user.UpdateBy,
                    UpdateOn = user.UpdateOn,
                    Username = user.Username,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                };

                res.UserToken = _tokenManager.Authenticate(data.UserName, data.UserName);


                res.ApiResults.Type = ApiResultsType.success.ToString();
            }
            catch (Exception ex)
            {
                res.ApiResults.Type = ApiResultsType.error.ToString();
                res.ApiResults.Message = ex.Message;
            }

            return res;
        }

        // encrypt
        #region Encrypt Method

        private const string eKey = "DTN-ERP.2020";
        private static byte[] IV = { 55, 44, 11, 33, 77, 66, 22, 99 };

        public string GetEncrypt(string zStr)
        {
            string ret = zStr;
            TripleDESCryptoServiceProvider tdsp = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider md5csp = new MD5CryptoServiceProvider();
            byte[] buffer = Encoding.ASCII.GetBytes(zStr);
            tdsp.Key = md5csp.ComputeHash(ASCIIEncoding.ASCII.GetBytes(eKey));
            tdsp.IV = IV;
            ret = Convert.ToBase64String(tdsp.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length));
            return ret;
        }

        public string GetDecrypt(string zEnStr)
        {
            string ret = zEnStr;
            TripleDESCryptoServiceProvider tdsp = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider md5csp = new MD5CryptoServiceProvider();
            byte[] buffer = Encoding.ASCII.GetBytes(zEnStr);
            buffer = Convert.FromBase64String(zEnStr);
            tdsp.Key = md5csp.ComputeHash(ASCIIEncoding.ASCII.GetBytes(eKey));
            tdsp.IV = IV;
            ret = Encoding.ASCII.GetString(tdsp.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length));
            return ret;
        }
        #endregion


    }
}
