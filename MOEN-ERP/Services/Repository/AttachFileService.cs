using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using System.Runtime;
using MOEN_ERP.DAL.Models;

namespace MOEN_ERP.Services.Repository
{
    public interface IAttachFileService
    {
        #region AttachFile
        public Task<List<AttachFile>> GetAttachFileListAsync(AttachFile sch);
        public Task<List<AssetImage>> GetAttachFileListImageAsync(AssetImage sch);
        public Task<List<AttachFile>> GetAttachFileNoDataListAsync(AttachFile sch);
        public Task<List<AttachFile>> GetAttachFileGuidListAsync(AttachFile sch);
        public Task<AttachFile> GetAttachFileAsync(int Id);
        public Task<AttachFile> GetAttachFileGuidAsync(string GuidId);
        public Task<AssetImage> GetAttachFileImageGuidAsync(string GuidId);
        public Task<AttachFile> GetAttachFileGuidNoDataAsync(string GuidId);
        public Task<AssetImage> GetAttachFileImageGuidNoDataAsync(string GuidId);
        public Task<AttachFile> GetAttachFileImageByRef(string refTable, int id);
        public Task<ApiResultsModel> AddAttachFileAsync(AttachFile data);
        public Task<ApiResultsModel> AddAttachFileImageAsync(AssetImage data);
        public Task<ApiResultsModel> UpdateAttachFileAsync(AttachFile data);
        public Task<ApiResultsModel> DeleteAttachFileAsync(int Id);
        public Task<ApiResultsModel> DeleteAttachFileGuidAsync(string GuidId);
        public Task<ApiResultsModel> DeleteAttachFileImageGuidAsync(string GuidId);
        public Task<ApiResultsModel> GetAttachFileByteListAsync(AttachFile sch);
        #endregion
    }
    public class AttachFileService : IAttachFileService
    {
        private readonly SettingsModel _settings;
        private readonly ITokenService _tokenService;
        public AttachFileService(IOptions<SettingsModel> options, ITokenService tokenService)
        {
            _settings = options.Value;
            _tokenService = tokenService;
        }

        #region AttachFile
        public async Task<List<AttachFile>> GetAttachFileListAsync(AttachFile sch)
        {
            var results = new List<AttachFile>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;



                var url = $"{_settings.BaseUrlApi}/AttachFile/GetAttachFileList";
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
                    results = JsonConvert.DeserializeObject<List<AttachFile>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<List<AssetImage>> GetAttachFileListImageAsync(AssetImage sch)
        {
            var results = new List<AssetImage>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

                var url = $"{_settings.BaseUrlApi}/AttachFile/GetAttachImageFileList";
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
                    results = JsonConvert.DeserializeObject<List<AssetImage>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        
        public async Task<List<AttachFile>> GetAttachFileNoDataListAsync(AttachFile sch)
        {
            var results = new List<AttachFile>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

                var url = $"{_settings.BaseUrlApi}/AttachFile/GetAttachFileNoDataList";
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
                    results = JsonConvert.DeserializeObject<List<AttachFile>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<List<AttachFile>> GetAttachFileGuidListAsync(AttachFile sch)
        {
            var results = new List<AttachFile>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

                var url = $"{_settings.BaseUrlApi}/AttachFile/GetAttachFileGuidList";
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
                    results = JsonConvert.DeserializeObject<List<AttachFile>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<AttachFile> GetAttachFileAsync(int Id)
        {
            var result = new AttachFile();
            try
            {
                //--Get Token
                // var token = await _tokenService.GetTokenAsync();
                var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

                var url = $"{_settings.BaseUrlApi}/AttachFile/GetAttachFile/{Id}";
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
                    result = JsonConvert.DeserializeObject<AttachFile>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<AttachFile> GetAttachFileGuidAsync(string GuidId)
        {
            var result = new AttachFile();
            try
            {
                //--Get Token
                var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/AttachFile/GetAttachFileGuid/{GuidId}";
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
                    result = JsonConvert.DeserializeObject<AttachFile>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }
        public async Task<AssetImage> GetAttachFileImageGuidAsync(string GuidId)
        {
            var result = new AssetImage();
            try
            {
                //--Get Token
                var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/AttachFile/GetAttachFileImageGuid/{GuidId}";
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
                    result = JsonConvert.DeserializeObject<AssetImage>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }
        
        public async Task<AttachFile> GetAttachFileGuidNoDataAsync(string GuidId)
        {
            var result = new AttachFile();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

                var url = $"{_settings.BaseUrlApi}/AttachFile/GetAttachFileGuidNoData/{GuidId}";
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
                    result = JsonConvert.DeserializeObject<AttachFile>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }
        public async Task<AssetImage> GetAttachFileImageGuidNoDataAsync(string GuidId)
        {
            var result = new AssetImage();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

                var url = $"{_settings.BaseUrlApi}/AttachFile/GetAttachFileImageGuidNoData/{GuidId}";
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
                    result = JsonConvert.DeserializeObject<AssetImage>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<AttachFile> GetAttachFileImageByRef(string refTable, int id)
        {
            var result = new AttachFile();
            try
            {
                //--Get Token
                var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

                // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/AttachFile/GetAttachFileImageByRef?refTable={refTable}&id={id}";
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
                    result = JsonConvert.DeserializeObject<AttachFile>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddAttachFileImageAsync(AssetImage data)
        {
            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();

                //--Get Token
                var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/AttachFile/AddAttachFileImage";

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

            }
            return result;
        }

        public async Task<ApiResultsModel> AddAttachFileAsync(AttachFile data)
        {
            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();

                //--Get Token
                var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/AttachFile/AddAttachFile";

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

            }
            return result;
        }
        public async Task<ApiResultsModel> UpdateAttachFileAsync(AttachFile data)
        {
            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();

                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

                var url = $"{_settings.BaseUrlApi}/AttachFile/UpdateAttachFile";

                data.UpdateBy = -1;
                //url += "/Data/UpdateAudioVisualDevice";
                request.Method = HttpMethod.Put;
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

            }
            return result;
        }
        public async Task<ApiResultsModel> DeleteAttachFileAsync(int Id)
        {
            var result = new ApiResultsModel();
            try
            {
                var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;


                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/AttachFile/DeleteAttachFile/{Id}";
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

            }
            return result;
        }

        public async Task<ApiResultsModel> DeleteAttachFileGuidAsync(string GuidId)
        {
            var result = new ApiResultsModel();
            try
            {
                var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;


                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/AttachFile/DeleteAttachFileGuid/{GuidId}";
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

            }
            return result;
        }
        public async Task<ApiResultsModel> DeleteAttachFileImageGuidAsync(string GuidId)
        {
            var result = new ApiResultsModel();
            try
            {
                var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;


                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/AttachFile/DeleteAttachFileImageGuid/{GuidId}";
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

            }
            return result;
        }
      
        
        public async Task<ApiResultsModel> GetAttachFileByteListAsync(AttachFile sch)
        {
            var results = new ApiResultsModel();
            try
            {
                var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/AttachFile/GetAttachFileByteList";
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

        #endregion
    }
}
