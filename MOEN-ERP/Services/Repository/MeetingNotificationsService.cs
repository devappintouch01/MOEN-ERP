using MOEN_ERP.Models.Common;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace MOEN_ERP.Services.Repository
{
    public interface IMeetingNotificationsService
    {
        public Task<ApiResultsModel> GetMeetingNotificationsAsync(int Id, int SystemUserId);
        public Task<ApiResultsModel> GetMeetingNotificationsListAsync(int OfficerId, int RoleId);
        public Task<ApiResultsModel> OpenMeetingNotificationsAsync(int SystemUserId, int OfficerId);
        public Task<ApiResultsModel> ReadMeetingNotificationsAsync(int Id, int SystemUserId);
        public Task<ApiResultsModel> DeleteMeetingNotificationsAsync(int Id, int OfficerId);
    }
    public class MeetingNotificationsService : IMeetingNotificationsService
    {
        private readonly SettingsModel _settings;
        private readonly ITokenService _tokenService;
        public MeetingNotificationsService(IOptions<SettingsModel> options, ITokenService tokenService) {
            _settings = options.Value;
            _tokenService = tokenService;
        }


        public async Task<ApiResultsModel> GetMeetingNotificationsAsync(int Id, int SystemUserId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/MeetingNotifications/GetMeetingNotifications?Id={Id}&SystemUserId={SystemUserId}";
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                string contentType = "application/json";
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {userCur?.UserToken}");
                var userAgent = "d-fens HttpClient";
                _httpClient.DefaultRequestHeaders.Add("User-Agent", userAgent);
                var res = await _httpClient.GetAsync(url);
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

        public async Task<ApiResultsModel> GetMeetingNotificationsListAsync(int OfficerId, int RoleId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/MeetingNotifications/GetMeetingNotificationsList/{OfficerId}/{RoleId}";
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                string contentType = "application/json";
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {userCur?.UserToken}");
                var userAgent = "d-fens HttpClient";
                _httpClient.DefaultRequestHeaders.Add("User-Agent", userAgent);
                var res = await _httpClient.GetAsync(url);
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

        public async Task<ApiResultsModel> OpenMeetingNotificationsAsync(int SystemUserId, int OfficerId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/MeetingNotifications/OpenMeetingNotifications/{SystemUserId}/{OfficerId}";
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                request.Method = HttpMethod.Put;
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
                result.Message = ex.Message;
                result.Type = ApiResultsType.error.ToString();
            }
            return result;
        }

        public async Task<ApiResultsModel> ReadMeetingNotificationsAsync(int Id, int SystemUserId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/MeetingNotifications/ReadMeetingNotifications/{Id}/{SystemUserId}";
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                request.Method = HttpMethod.Put;
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
                result.Message = ex.Message;
                result.Type = ApiResultsType.error.ToString();
            }
            return result;
        }

        public async Task<ApiResultsModel> DeleteMeetingNotificationsAsync(int Id, int OfficerId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/MeetingNotifications/DeleteMeetingNotifications/{Id}/{OfficerId}";
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                request.Method = HttpMethod.Delete;
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
                result.Message = ex.Message;
                result.Type = ApiResultsType.error.ToString();
            }
            return result;
        }




    }


}
