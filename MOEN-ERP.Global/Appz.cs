using MOEN_ERP.Models.Common;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Text.Json;


namespace MOEN_ERP
{
    public class Appz
    {

        HttpContext _httpContext;
        public Appz(HttpContext httpContextAccessor)
        {
            _httpContext = httpContextAccessor;
        }
        public string CurrentSessionId
        {
            get
            {
                return _httpContext?.Session.Id ?? "";
            }
        }

        public AccountModel CurrentSignInUser
        {

            get
            {
                var str = _httpContext?.Session.GetString("MOEN_ERP.USER_SES");
                if (str == null && _httpContext != null)
                {
                    ClaimsPrincipal claimAccount = _httpContext.User;
                    if (claimAccount.Identity.IsAuthenticated)
                    {
                        var currentUser = JsonSerializer.Deserialize<AccountModel>(claimAccount.Identity.Name);
                        if (currentUser.User != null)
                        {
                            _httpContext.Session.SetString("MOEN_ERP.USER_SES", JsonSerializer.Serialize(currentUser));
                            return currentUser;
                        }
                        else
                        {
                            return new AccountModel();
                        }
                        
                    }
                    else
                    {
                        return new AccountModel();
                    }

                }
                else
                {
                    return str == null ? default : JsonSerializer.Deserialize<AccountModel>(str);
                }

            }
            set
            {
                _httpContext.Session.SetString("MOEN_ERP.USER_SES", JsonSerializer.Serialize(value));
            }

        }


    }

}
