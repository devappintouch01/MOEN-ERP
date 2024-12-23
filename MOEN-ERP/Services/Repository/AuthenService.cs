using MOEN_ERP.Components;
using MOEN_ERP.Models.Common;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Runtime;
using System.Text;

namespace MOEN_ERP.Services.Repository
{
    public interface IAuthenService
    {
        public Task<AccountModel> SignInAsync(SignInModel data);
        public Task<AccountModel> SignInSSOAsync(SignInSSOModel data);
    }
    public class AuthenService : IAuthenService
    {
        private readonly SettingsModel _settings;
        private readonly ITokenService _token;
        public AuthenService(IOptions<SettingsModel> options, ITokenService token) {
            _settings = options.Value;
            _token = token;
        }
        public async Task<AccountModel> SignInAsync(SignInModel data)
        {
            var result = new AccountModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();

                //--Get Token
                //Logz.AddLog("Start Sign In (with service get token)");
                //var token = await _token.GetTokenAsync(data.UserName, data.Password);
                //Logz.AddLog(token);
                //Logz.AddLog("Start Sign In (with service get token success)");

                //Logz.AddLog("Start Sign In (with service)");
                var url = $"{_settings.BaseUrlApi}/Authen/SignIn";
                //Logz.AddLog("Start Sign In (with service) UrlApi :" + url);
                request.Method = HttpMethod.Post;
                request.Content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
               // request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                request.RequestUri = new Uri(url);

                var response = _httpClient.SendAsync(request).ConfigureAwait(false);

                var res = response.GetAwaiter().GetResult();

                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    //Logz.AddLog("Start Sign In (with service) Json Convert");
                    var json = await res.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<AccountModel>(json);
                    //result.UserToken = token;
                    //new Appz(MyHttpContext.Current).CurrentSignInUser = result;
                    //Logz.AddLog("Finish Sign In (with service) Json Convert");
                }


            }
            catch (Exception ex)
            {
                result.ApiResults.Message = ex.Message;
                result.ApiResults.Type = ApiResultsType.error.ToString();
                //Logz.AddLog("Finish Sign In (with service) Error");
            }
            //Logz.AddLog("Finish Sign In (with service) Success");
            return result;
        }



        public async Task<AccountModel> SignInSSOAsync(SignInSSOModel data)
        {
            var result = new AccountModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();

                //--Get Token
                //var token = await _token.GetTokenAsync(data.UserName, data.UserName);
                var url = $"{_settings.BaseUrlApi}/Authen/SignInSSO";
                request.Method = HttpMethod.Post;
                request.Content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                //request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                request.RequestUri = new Uri(url);

                var response = _httpClient.SendAsync(request).ConfigureAwait(false);

                var res = response.GetAwaiter().GetResult();

                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<AccountModel>(json);
                    //result.UserToken = token;
                    //new Appz(MyHttpContext.Current).CurrentSignInUser = result;
                }


            }
            catch (Exception ex)
            {
                result.ApiResults.Message = ex.Message;
                result.ApiResults.Type = ApiResultsType.error.ToString();
            }
            return result;
        }


    }

}
