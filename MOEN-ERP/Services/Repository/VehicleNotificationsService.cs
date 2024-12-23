using MOEN_ERP.Models.Common;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace MOEN_ERP.Services.Repository
{
    public interface IVehicleNotificationsService
    {
        public Task<ApiResultsModel> GetVehicleNotificationsAsync(int Id);
        public Task<ApiResultsModel> GetVehicleNotificationsListAsync(int OfficerId, int RoleId);
        public Task<ApiResultsModel> OpenVehicleNotificationsAsync(int SystemUserId, int OfficerId);
        public Task<ApiResultsModel> ReadVehicleNotificationsAsync(int Id, int SystemUserId);
        public Task<ApiResultsModel> DeleteVehicleNotificationsAsync(int Id, int OfficerId);
    }
    public class VehicleNotificationsService : IVehicleNotificationsService
    {
        private readonly SettingsModel _settings;
        private readonly ITokenService _tokenService;
        public VehicleNotificationsService(IOptions<SettingsModel> options, ITokenService tokenService) {
            _settings = options.Value;
            _tokenService = tokenService;
        }

        public async Task<ApiResultsModel> GetVehicleNotificationsAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/VehicleNotifications/GetVehicleNotifications/{Id}";
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

        public async Task<ApiResultsModel> GetVehicleNotificationsListAsync(int OfficerId, int RoleId)
        {
            var results = new ApiResultsModel();
            try
            {
                var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/VehicleNotifications/GetVehicleNotificationsList/{OfficerId}/{RoleId}";
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

        public async Task<ApiResultsModel> OpenVehicleNotificationsAsync(int SystemUserId, int OfficerId)
        {
            var result = new ApiResultsModel();
            try
            {
                var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;


                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/VehicleNotifications/OpenVehicleNotifications/{SystemUserId}/{OfficerId}";
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

        public async Task<ApiResultsModel> ReadVehicleNotificationsAsync(int Id, int SystemUserId)
        {
            var result = new ApiResultsModel();
            try
            {
                var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;


                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/VehicleNotifications/ReadVehicleNotifications/{Id}/{SystemUserId}";
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

        public async Task<ApiResultsModel> DeleteVehicleNotificationsAsync(int Id, int OfficerId)
        {
            var result = new ApiResultsModel();
            try
            {
                var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;


                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/VehicleNotifications/DeleteVehicleNotifications/{Id}/{OfficerId}";
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
