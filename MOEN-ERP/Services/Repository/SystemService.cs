using MOEN_ERP.Components;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace MOEN_ERP.Services.Repository
{
    public interface ISystemService {
        public Task<ApiResultsModel> AddSystemBookingLogAsync(SystemBookingLog data);
    }
    public class SystemService : ISystemService
    {
        private readonly SettingsModel _settings;
        //private readonly HttpContext _httpContext;
        public SystemService(IOptions<SettingsModel> options
            //, HttpContext httpContext
            )
        {
            _settings = options.Value;
            //_httpContext = httpContext;
        }
        public async Task<ApiResultsModel> AddSystemBookingLogAsync(SystemBookingLog data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                data.Time = DateTime.Now;
                data.UserId = userCur?.User?.Id;
                data.SessionId = new Appz(MyHttpContext.Current)?.CurrentSessionId;
                //data.IpAddress = _httpContext?.Connection?.RemoteIpAddress?.ToString() ?? null;
                data.SystemInfo = userCur?.SystemInfo?.SystemInfoName;

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                var url = $"{_settings.BaseUrlApi}/System/AddSystemBookingLog";

               
                request.Method = HttpMethod.Post;
                request.Content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", userCur?.UserToken);
                request.RequestUri = new Uri(url);

                var response = _httpClient.SendAsync(request).ConfigureAwait(false);

                var res = response.GetAwaiter().GetResult();

                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<ApiResultsModel>(json);
                }


            }
            catch (Exception ex)
            {
                result.Type = ApiResultsType.error.ToString();
                result.Message = ex.Message;
            }
            return result;
        }
    }

}
