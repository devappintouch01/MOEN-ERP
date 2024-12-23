using MOEN_ERP.Components;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Services.Repository;

namespace MOEN_ERP.Services
{
    public interface IAccount
    {
        public Task<AccountModel> SignIn(SignInModel data);
        public Task<AccountModel> SignInSSO(SignInSSOModel data);
    }
    public class Account : IAccount
    {
        private readonly IAuthenService _authen;
        public Account(IAuthenService authen)
        {
            _authen = authen;
        }
        public async Task<AccountModel> SignIn(SignInModel data)
        {
            //Logz.AddLog("Start Sign In (service)");
            AccountModel result = new AccountModel();
          
            try
            {              
                result = await _authen.SignInAsync(data);
                //Logz.AddLog("Start Sign In (service)");
            }
            catch (Exception ex)
            {
                //Logz.AddLog("Error Sign In (service)");
                result.ApiResults.Message = ex.Message;
            }
            //Logz.AddLog("Finish Sign In (service)");
            return result;
        }

        public async Task<AccountModel> SignInSSO(SignInSSOModel data)
        {
            AccountModel result = new AccountModel();

            try
            {
                result = await _authen.SignInSSOAsync(data);
            }
            catch (Exception ex)
            {
                result.ApiResults.Message = ex.Message;
            }

            return result;
        }

    }
}
