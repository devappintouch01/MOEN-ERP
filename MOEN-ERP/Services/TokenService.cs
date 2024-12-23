using MOEN_ERP.Models.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Text;

namespace MOEN_ERP.Services
{
    public class TokenService : ITokenService
    {
        private readonly HttpClient _httpClient;
        private readonly SettingsModel _settings;
        public TokenService(HttpClient httpClient, IOptions<SettingsModel> options)
        {
            _httpClient = httpClient;
            _settings = options.Value;
        }

        public async Task<string> GetTokenAsync(string userName, string userPassword)
        {
            string result = "";
            try
            {
                var url = $"{_settings.BaseUrlApi}/Token/Authenticate";
                
                var json = JsonConvert.SerializeObject(new { UserName = userName, Password = userPassword });
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var res = await _httpClient.PostAsync(url, content);
                if (res.IsSuccessStatusCode)
                {
                    result = await res.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }

    }

}
