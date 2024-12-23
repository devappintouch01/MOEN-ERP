using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.ViewModel.ConferenceBooking;
using MOEN_ERP.Models.ViewModel.MeetingDisplay;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace MOEN_ERP.Services.Repository
{
    public interface IMeetingDisplayService
    {
        public Task<ApiResultsModel> GetMeetingRoomDisplayDetailAsync(MeetingDisplayScreenSearch sch);
    }
    public class MeetingDisplayService : IMeetingDisplayService
    {
        private readonly SettingsModel _settings;
        private readonly ITokenService _tokenService;
        public MeetingDisplayService(IOptions<SettingsModel> options, ITokenService tokenService) {
            _settings = options.Value;
            _tokenService = tokenService;
        }

        public async Task<ApiResultsModel> GetMeetingRoomDisplayDetailAsync(MeetingDisplayScreenSearch sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/MeetingDisplay/GetMeetingRoomDisplayDetail";
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var cotentData = JsonConvert.SerializeObject(sch);
                var request = new HttpRequestMessage();
                request.Method = HttpMethod.Get;
                request.Content = new StringContent(cotentData, Encoding.UTF8, "application/json");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", userCur?.UserToken);
                request.RequestUri = new Uri(url);

                var response = _httpClient.SendAsync(request).ConfigureAwait(false);
                var res = response.GetAwaiter().GetResult();
                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    results.Data = json;
                    results.Type = ApiResultsType.success.ToString();
                }

            }
            catch (Exception ex)
            {
                results.Message = ex.Message;
                results.Type = ApiResultsType.error.ToString();
            }
            return results;
        }

    }

}
