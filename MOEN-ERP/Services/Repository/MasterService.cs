using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Text;
using MOEN_ERP.DAL.Models;

namespace MOEN_ERP.Services.Repository
{
    public interface IMasterService
    {


        #region MasterVehicleBrand
        public Task<List<MasterVehicleBrand>> GetMasterVehicleBrandList(MasterVehicleBrand sch);
        public Task<MasterVehicleBrand> GetMasterVehicleBrand(int Id);
        public Task<ApiResultsModel> AddMasterVehicleBrand(MasterVehicleBrand data);
        public Task<ApiResultsModel> UpdateMasterVehicleBrand(MasterVehicleBrand data);
        public Task<ApiResultsModel> DeleteMasterVehicleBrand(int Id);
        #endregion

        #region MasterVehicleModel
        public Task<List<MasterVehicleModel>> GetMasterVehicleModelList(MasterVehicleModel sch);
        public Task<MasterVehicleModel> GetMasterVehicleModel(int Id);
        public Task<ApiResultsModel> AddMasterVehicleModel(MasterVehicleModel data);
        public Task<ApiResultsModel> UpdateMasterVehicleModel(MasterVehicleModel data);
        public Task<ApiResultsModel> DeleteMasterVehicleModel(int Id);
        #endregion

        #region MasterVehicleType
        public Task<List<MasterVehicleType>> GetMasterVehicleTypeList(MasterVehicleType sch);
        public Task<MasterVehicleType> GetMasterVehicleType(int Id);
        public Task<ApiResultsModel> AddMasterVehicleType(MasterVehicleType data);
        public Task<ApiResultsModel> UpdateMasterVehicleType(MasterVehicleType data);
        public Task<ApiResultsModel> DeleteMasterVehicleType(int Id);
        #endregion

        #region MasterFuelType
        public Task<List<MasterFuelType>> GetMasterFuelTypeList(MasterFuelType sch);
        public Task<MasterFuelType> GetMasterFuelType(int Id);
        public Task<ApiResultsModel> AddMasterFuelType(MasterFuelType data);
        public Task<ApiResultsModel> UpdateMasterFuelType(MasterFuelType data);
        public Task<ApiResultsModel> DeleteMasterFuelType(int Id);
        #endregion

        #region MasterGarage
        public Task<List<MasterGarage>> GetMasterGarageList(MasterGarage sch);
        public Task<MasterGarage> GetMasterGarage(int Id);
        public Task<ApiResultsModel> AddMasterGarage(MasterGarage data);
        public Task<ApiResultsModel> UpdateMasterGarage(MasterGarage data);
        public Task<ApiResultsModel> DeleteMasterGarage(int Id);
        #endregion

        #region MasterVehicleMaintenanceType
        public Task<List<MasterVehicleMaintenanceType>> GetMasterVehicleMaintenanceTypeList(MasterVehicleMaintenanceType sch);
        public Task<MasterVehicleMaintenanceType> GetMasterVehicleMaintenanceType(int Id);
        public Task<ApiResultsModel> AddMasterVehicleMaintenanceType(MasterVehicleMaintenanceType data);
        public Task<ApiResultsModel> UpdateMasterVehicleMaintenanceType(MasterVehicleMaintenanceType data);
        public Task<ApiResultsModel> DeleteMasterVehicleMaintenanceType(int Id);
        #endregion

        #region MasterVideoConference
        public Task<List<MasterVideoConference>> GetMasterVideoConferenceListAsync(MasterVideoConference sch);
        public Task<MasterVideoConference> GetMasterVideoConferenceAsync(int Id);
        public Task<ApiResultsModel> AddMasterVideoConferenceAsync(MasterVideoConference data);
        public Task<ApiResultsModel> UpdateMasterVideoConferenceAsync(MasterVideoConference data);
        public Task<ApiResultsModel> DeleteMasterVideoConferenceAsync(int Id);
        #endregion

        #region MasterFoodCategory
        public Task<List<MasterFoodCategory>> GetMasterFoodCategoryListAsync(MasterFoodCategory sch);
        public Task<MasterFoodCategory> GetMasterFoodCategoryAsync(int Id);
        public Task<ApiResultsModel> AddMasterFoodCategoryAsync(MasterFoodCategory data);
        public Task<ApiResultsModel> UpdateMasterFoodCategoryAsync(MasterFoodCategory data);
        public Task<ApiResultsModel> DeleteMasterFoodCategoryAsync(int Id);
        #endregion   

        #region MasterOrganization
        public Task<List<MasterOrganization>> GetMasterOrganizationListAsync(MasterOrganization sch);
        public Task<MasterOrganization> GetMasterOrganizationAsync(int Id);
        public Task<ApiResultsModel> AddMasterOrganizationAsync(MasterOrganization data);
        public Task<ApiResultsModel> UpdateMasterOrganizationAsync(MasterOrganization data);
        public Task<ApiResultsModel> DeleteMasterOrganizationAsync(int Id);
        #endregion

        #region MasterVideoConferenceLicense
        public Task<List<MasterVideoConferenceLicense>> GetMasterVideoConferenceLicenseListAsync(MasterVideoConferenceLicense sch);
        public Task<MasterVideoConferenceLicense> GetMasterVideoConferenceLicenseAsync(int Id);
        public Task<ApiResultsModel> AddMasterVideoConferenceLicenseAsync(MasterVideoConferenceLicense data);
        public Task<ApiResultsModel> UpdateMasterVideoConferenceLicenseAsync(MasterVideoConferenceLicense data);
        public Task<ApiResultsModel> DeleteMasterVideoConferenceLicenseAsync(int Id);
        #endregion

        #region MasterAudioVisualDeviceStatus
        public Task<List<MasterAudioVisualDeviceStatus>> GetMasterAudioVisualDeviceStatusListAsync(MasterAudioVisualDeviceStatus sch);
        public Task<MasterAudioVisualDeviceStatus> GetMasterAudioVisualDeviceStatusAsync(int Id);
        public Task<ApiResultsModel> AddMasterAudioVisualDeviceStatusAsync(MasterAudioVisualDeviceStatus data);
        public Task<ApiResultsModel> UpdateMasterAudioVisualDeviceStatusAsync(MasterAudioVisualDeviceStatus data);
        public Task<ApiResultsModel> DeleteMasterAudioVisualDeviceStatusAsync(int Id);
        #endregion

        #region MasterVehicleOwnership
        public Task<List<MasterVehicleOwnership>> GetMasterVehicleOwnershipListAsync(MasterVehicleOwnership sch);
        public Task<MasterVehicleOwnership> GetMasterVehicleOwnershipAsync(int Id);
        public Task<ApiResultsModel> AddMasterVehicleOwnershipAsync(MasterVehicleOwnership data);
        public Task<ApiResultsModel> UpdateMasterVehicleOwnershipAsync(MasterVehicleOwnership data);
        public Task<ApiResultsModel> DeleteMasterVehicleOwnershipAsync(int Id);
        #endregion

        #region MasterNamePrefix
        public Task<List<MasterNamePrefix>> GetMasterNamePrefixListAsync(MasterNamePrefix sch);
        public Task<MasterNamePrefix> GetMasterNamePrefixAsync(int Id);
        public Task<ApiResultsModel> AddMasterNamePrefixAsync(MasterNamePrefix data);
        public Task<ApiResultsModel> UpdateMasterNamePrefixAsync(MasterNamePrefix data);
        //public Task<ApiResultsModel> DeleteMasterNamePrefixAsync(int Id);
        #endregion

        #region MasterMeetingRoomFormat
        public Task<List<MasterMeetingRoomFormat>> GetMasterMeetingRoomFormatList(MasterMeetingRoomFormat sch);
        public Task<MasterMeetingRoomFormat> GetMasterMeetingRoomFormat(int Id);
        public Task<ApiResultsModel> AddMasterMeetingRoomFormat(MasterMeetingRoomFormat data);
        public Task<ApiResultsModel> UpdateMasterMeetingRoomFormat(MasterMeetingRoomFormat data);
        public Task<ApiResultsModel> DeleteMasterMeetingRoomFormat(int Id);
        #endregion

        #region MasterVehicleBookingFormat
        public Task<List<MasterVehicleBookingFormat>> GetMasterVehicleBookingFormatListAsync(MasterVehicleBookingFormat sch);
        public Task<MasterVehicleBookingFormat> GetMasterVehicleBookingFormatAsync(int Id);
        #endregion

        #region MasterVehicleBookingStatus
        public Task<List<MasterVehicleBookingStatus>> GetMasterVehicleBookingStatusListAsync(MasterVehicleBookingStatus sch);
        public Task<MasterVehicleBookingStatus> GetMasterVehicleBookingStatusAsync(int Id);
        #endregion

        #region MasterVehicleBookingType
        public Task<List<MasterVehicleBookingType>> GetMasterVehicleBookingTypeListAsync(MasterVehicleBookingType sch);
        public Task<MasterVehicleBookingType> GetMasterVehicleBookingTypeAsync(int Id);
        #endregion

        #region MasterBookingType
        public Task<List<MasterBookingType>> GetMasterBookingTypeListAsync(MasterBookingType sch);
        public Task<MasterBookingType> GetMasterBookingTypeAsync(int Id);
        #endregion

        #region MasterBookingStatus
        public Task<List<MasterBookingStatus>> GetMasterBookingStatusListAsync(MasterBookingStatus sch);
        public Task<MasterBookingStatus> GetMasterBookingStatusAsync(int Id);
        #endregion

        #region MasterVideoConferenceBookingPriority
        public Task<List<MasterVideoConferenceBookingPriority>> GetMasterVideoConferenceBookingPriorityListAsync(MasterVideoConferenceBookingPriority sch);
        public Task<MasterVideoConferenceBookingPriority> GetMasterVideoConferenceBookingPriorityAsync(int Id);
        #endregion

        #region MasterCateringServiceParticipantType
        public Task<List<MasterCateringServiceParticipantType>> GetMasterCateringServiceParticipantTypeListAsync(MasterCateringServiceParticipantType sch);
        public Task<MasterCateringServiceParticipantType> GetMasterCateringServiceParticipantTypeAsync(int Id);
        #endregion

        #region MasterFuelCode
        public  Task<ApiResultsModel> GetMasterFuelCodeListAsync(MasterFuelCode sch);
        public Task<ApiResultsModel> GetMasterFuelCodeAsync(int Id);
        public Task<ApiResultsModel> AddMasterFuelCodeAsync(MasterFuelCode data);
        public Task<ApiResultsModel> UpdateMasterFuelCodeAsync(MasterFuelCode data);
        public Task<ApiResultsModel> DeleteMasterFuelCodeAsync(int Id);
        #endregion

        #region MasterBudgetExpenseType
        public Task<ApiResultsModel> GetMasterBudgetExpenseTypeListAsync(MasterBudgetExpenseType sch);
        #endregion

        #region MasterUnit
        public Task<List<VMasterUnit>> GetMasterUnitListAsync();
        #endregion
    }

    public class MasterService : IMasterService
    {
        private readonly SettingsModel _settings;
        private readonly ITokenService _tokenService;
        public MasterService(IOptions<SettingsModel> options, ITokenService tokenService)
        {
            _settings = options.Value;
            _tokenService = tokenService;
        }

        #region MasterVehicleBrand
        public async Task<List<MasterVehicleBrand>> GetMasterVehicleBrandList(MasterVehicleBrand sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MasterVehicleBrand>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterVehicleBrandList";
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var cotentData = JsonConvert.SerializeObject(sch);
                // var cotentData = JsonConvert.SerializeObject(sch);
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
                    results = JsonConvert.DeserializeObject<List<MasterVehicleBrand>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<MasterVehicleBrand> GetMasterVehicleBrand(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MasterVehicleBrand();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterVehicleBrand/{Id}";
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
                    result = JsonConvert.DeserializeObject<MasterVehicleBrand>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddMasterVehicleBrand(MasterVehicleBrand data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                data.CreateBy = -1;

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/AddMasterVehicleBrand";

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
        public async Task<ApiResultsModel> UpdateMasterVehicleBrand(MasterVehicleBrand data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}";

                data.UpdateBy = -1;
                url += "/Master/UpdateMasterVehicleBrand";
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

        public async Task<ApiResultsModel> DeleteMasterVehicleBrand(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Master/DeleteMasterVehicleBrand/{Id}";
                var request = new HttpRequestMessage();
                //--Get Token
               // var token = await _tokenService.GetTokenAsync();
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
        #endregion

        #region MasterVehicleModel
        public async Task<List<MasterVehicleModel>> GetMasterVehicleModelList(MasterVehicleModel sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MasterVehicleModel>();
            try
            {
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterVehicleModelList";
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var cotentData = JsonConvert.SerializeObject(sch);
                // var cotentData = JsonConvert.SerializeObject(sch);
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
                    results = JsonConvert.DeserializeObject<List<MasterVehicleModel>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MasterVehicleModel> GetMasterVehicleModel(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MasterVehicleModel();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterVehicleModel/{Id}";
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
                    result = JsonConvert.DeserializeObject<MasterVehicleModel>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddMasterVehicleModel(MasterVehicleModel data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                data.CreateBy = -1;

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();

                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/AddMasterVehicleModel";
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

        public async Task<ApiResultsModel> UpdateMasterVehicleModel(MasterVehicleModel data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                //var cotentData = JsonConvert.SerializeObject(data);
                var request = new HttpRequestMessage();

                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}";

                data.UpdateBy = -1;
                url += "/Master/UpdateMasterVehicleModel";
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

        public async Task<ApiResultsModel> DeleteMasterVehicleModel(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Master/DeleteMasterVehicleModel/{Id}";
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

        #endregion

        #region MasterVehicleType
        public async Task<List<MasterVehicleType>> GetMasterVehicleTypeList(MasterVehicleType sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MasterVehicleType>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterVehicleTypeList";
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
                    results = JsonConvert.DeserializeObject<List<MasterVehicleType>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MasterVehicleType> GetMasterVehicleType(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MasterVehicleType();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterVehicleType/{Id}";
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
                    result = JsonConvert.DeserializeObject<MasterVehicleType>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddMasterVehicleType(MasterVehicleType data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                data.CreateBy = -1;

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/AddMasterVehicleType";

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
                result.Message = ex.Message;
                result.Type = ApiResultsType.error.ToString();
            }
            return result;
        }

        public async Task<ApiResultsModel> UpdateMasterVehicleType(MasterVehicleType data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                data.UpdateBy = -1;

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}";


                url += "/Master/UpdateMasterVehicleType";
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

        public async Task<ApiResultsModel> DeleteMasterVehicleType(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Master/DeleteMasterVehicleType/{Id}";
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

        #endregion

        #region MasterFuelType
        public async Task<List<MasterFuelType>> GetMasterFuelTypeList(MasterFuelType sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MasterFuelType>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterFuelTypeList";
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
                    results = JsonConvert.DeserializeObject<List<MasterFuelType>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MasterFuelType> GetMasterFuelType(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MasterFuelType();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterFuelType/{Id}";
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
                    result = JsonConvert.DeserializeObject<MasterFuelType>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddMasterFuelType(MasterFuelType data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                data.CreateBy = -1;

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/AddMasterFuelType";

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

        public async Task<ApiResultsModel> UpdateMasterFuelType(MasterFuelType data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}";

                data.UpdateBy = -1;
                url += "/Master/UpdateMasterFuelType";
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

        public async Task<ApiResultsModel> DeleteMasterFuelType(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Master/DeleteMasterFuelType/{Id}";
                var request = new HttpRequestMessage();
                //--Get Token
               // var token = await _tokenService.GetTokenAsync();
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

        #endregion

        #region MasterGarage
        public async Task<List<MasterGarage>> GetMasterGarageList(MasterGarage sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MasterGarage>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterGarageList";
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
                    results = JsonConvert.DeserializeObject<List<MasterGarage>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MasterGarage> GetMasterGarage(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MasterGarage();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterGarage/{Id}";
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
                    result = JsonConvert.DeserializeObject<MasterGarage>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddMasterGarage(MasterGarage data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                data.CreateBy = -1;

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/AddMasterGarage";

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
                result.Message = ex.Message;
                result.Type = ApiResultsType.error.ToString();
            }
            return result;
        }

        public async Task<ApiResultsModel> UpdateMasterGarage(MasterGarage data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                data.UpdateBy = -1;

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}";

                url += "/Master/UpdateMasterGarage";
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
                result.Message = ex.Message;
                result.Type = ApiResultsType.error.ToString();
            }
            return result;
        }

        public async Task<ApiResultsModel> DeleteMasterGarage(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Master/DeleteMasterGarage/{Id}";
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

        #endregion

        #region MasterVehicleMaintenanceType
        public async Task<List<MasterVehicleMaintenanceType>> GetMasterVehicleMaintenanceTypeList(MasterVehicleMaintenanceType sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MasterVehicleMaintenanceType>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterVehicleMaintenanceTypeList";
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
                    results = JsonConvert.DeserializeObject<List<MasterVehicleMaintenanceType>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MasterVehicleMaintenanceType> GetMasterVehicleMaintenanceType(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MasterVehicleMaintenanceType();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterVehicleMaintenanceType/{Id}";
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
                    result = JsonConvert.DeserializeObject<MasterVehicleMaintenanceType>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddMasterVehicleMaintenanceType(MasterVehicleMaintenanceType data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/AddMasterVehicleMaintenanceType";

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

        public async Task<ApiResultsModel> UpdateMasterVehicleMaintenanceType(MasterVehicleMaintenanceType data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}";

                data.UpdateBy = -1;
                url += "/Master/UpdateMasterVehicleMaintenanceType";
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

        public async Task<ApiResultsModel> DeleteMasterVehicleMaintenanceType(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Master/DeleteMasterVehicleMaintenanceType/{Id}";
                var request = new HttpRequestMessage();
                //--Get Token
               // var token = await _tokenService.GetTokenAsync();
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

        #endregion

        #region MasterVideoConference
        public async Task<List<MasterVideoConference>> GetMasterVideoConferenceListAsync(MasterVideoConference sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MasterVideoConference>();
            try
            {

                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterVideoConferenceList";
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
                    results = JsonConvert.DeserializeObject<List<MasterVideoConference>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MasterVideoConference> GetMasterVideoConferenceAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MasterVideoConference();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterVideoConference/{Id}";
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
                    result = JsonConvert.DeserializeObject<MasterVideoConference>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }
        public async Task<ApiResultsModel> AddMasterVideoConferenceAsync(MasterVideoConference data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                data.CreateBy = -1;

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/AddMasterVideoConference";

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
        public async Task<ApiResultsModel> UpdateMasterVideoConferenceAsync(MasterVideoConference data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                data.UpdateBy = -1;

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/UpdateMasterVideoConference";

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

        public async Task<ApiResultsModel> DeleteMasterVideoConferenceAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Master/DeleteMasterVideoConference/{Id}";
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

        #endregion

        #region MasterFoodCategory
        public async Task<List<MasterFoodCategory>> GetMasterFoodCategoryListAsync(MasterFoodCategory sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MasterFoodCategory>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterFoodCategoryList";
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
                    results = JsonConvert.DeserializeObject<List<MasterFoodCategory>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MasterFoodCategory> GetMasterFoodCategoryAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MasterFoodCategory();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterFoodCategory/{Id}";
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
                    result = JsonConvert.DeserializeObject<MasterFoodCategory>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddMasterFoodCategoryAsync(MasterFoodCategory data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/AddMasterFoodCategory";

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
        public async Task<ApiResultsModel> UpdateMasterFoodCategoryAsync(MasterFoodCategory data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/UpdateMasterFoodCategory";
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

        public async Task<ApiResultsModel> DeleteMasterFoodCategoryAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Master/DeleteMasterFoodCategory/{Id}";
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

        #endregion

        #region MasterOrganization
        public async Task<List<MasterOrganization>> GetMasterOrganizationListAsync(MasterOrganization sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MasterOrganization>();
            try
            {
               //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterOrganizationList";
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
                    results = JsonConvert.DeserializeObject<List<MasterOrganization>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MasterOrganization> GetMasterOrganizationAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MasterOrganization();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterOrganization/{Id}";
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
                    result = JsonConvert.DeserializeObject<MasterOrganization>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddMasterOrganizationAsync(MasterOrganization data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                //data.CreateBy = -1;

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/AddMasterOrganization";

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
        public async Task<ApiResultsModel> UpdateMasterOrganizationAsync(MasterOrganization data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                data.UpdateBy = -1;

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/UpdateMasterOrganization";

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

        public async Task<ApiResultsModel> DeleteMasterOrganizationAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Master/DeleteMasterOrganization/{Id}";
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

        #endregion

        #region MasterVideoConferenceLicense
        public async Task<List<MasterVideoConferenceLicense>> GetMasterVideoConferenceLicenseListAsync(MasterVideoConferenceLicense sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MasterVideoConferenceLicense>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterVideoConferenceLicenseList";
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
                    results = JsonConvert.DeserializeObject<List<MasterVideoConferenceLicense>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MasterVideoConferenceLicense> GetMasterVideoConferenceLicenseAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MasterVideoConferenceLicense();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterVideoConferenceLicense/{Id}";
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
                    result = JsonConvert.DeserializeObject<MasterVideoConferenceLicense>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddMasterVideoConferenceLicenseAsync(MasterVideoConferenceLicense data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                //data.CreateBy = -1;


                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/AddMasterVideoConferenceLicense";

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
        public async Task<ApiResultsModel> UpdateMasterVideoConferenceLicenseAsync(MasterVideoConferenceLicense data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}";

                data.UpdateBy = -1;
                url += "/Master/UpdateMasterVideoConferenceLicense";
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

        public async Task<ApiResultsModel> DeleteMasterVideoConferenceLicenseAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Master/DeleteMasterVideoConferenceLicense/{Id}";
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

        #endregion

        #region MasterAudioVisualDeviceStatus
        public async Task<List<MasterAudioVisualDeviceStatus>> GetMasterAudioVisualDeviceStatusListAsync(MasterAudioVisualDeviceStatus sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MasterAudioVisualDeviceStatus>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterAudioVisualDeviceStatusList";
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
                    results = JsonConvert.DeserializeObject<List<MasterAudioVisualDeviceStatus>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MasterAudioVisualDeviceStatus> GetMasterAudioVisualDeviceStatusAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MasterAudioVisualDeviceStatus();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterAudioVisualDeviceStatus/{Id}";
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
                    result = JsonConvert.DeserializeObject<MasterAudioVisualDeviceStatus>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddMasterAudioVisualDeviceStatusAsync(MasterAudioVisualDeviceStatus data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                //data.CreateBy = -1;


                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/AddMasterAudioVisualDeviceStatus";

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
        public async Task<ApiResultsModel> UpdateMasterAudioVisualDeviceStatusAsync(MasterAudioVisualDeviceStatus data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}";

                data.UpdateBy = -1;
                url += "/Master/UpdateMasterAudioVisualDeviceStatus";
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

        public async Task<ApiResultsModel> DeleteMasterAudioVisualDeviceStatusAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                MasterAudioVisualDeviceStatus data = new MasterAudioVisualDeviceStatus();
                data.Id = Id;
                data.UpdateBy = userCur?.User?.Id;

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/DeleteMasterAudioVisualDeviceStatus";
                request.Method = HttpMethod.Delete;
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

        #endregion

        #region MasterVehicleOwnership
        public async Task<List<MasterVehicleOwnership>> GetMasterVehicleOwnershipListAsync(MasterVehicleOwnership sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MasterVehicleOwnership>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterVehicleOwnershipList";
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
                    results = JsonConvert.DeserializeObject<List<MasterVehicleOwnership>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MasterVehicleOwnership> GetMasterVehicleOwnershipAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MasterVehicleOwnership();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterVehicleOwnership/{Id}";
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
                    result = JsonConvert.DeserializeObject<MasterVehicleOwnership>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddMasterVehicleOwnershipAsync(MasterVehicleOwnership data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                //data.CreateBy = -1;


                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/AddMasterVehicleOwnership";

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
        public async Task<ApiResultsModel> UpdateMasterVehicleOwnershipAsync(MasterVehicleOwnership data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}";

                data.UpdateBy = -1;
                url += "/Master/UpdateMasterAudioVisualDeviceStatus";
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

        public async Task<ApiResultsModel> DeleteMasterVehicleOwnershipAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                MasterVehicleOwnership data = new MasterVehicleOwnership();
                data.Id = Id;
                data.UpdateBy = -1;

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/DeleteMasterVehicleOwnership";
                request.Method = HttpMethod.Delete;
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

        #endregion

        #region MasterNamePrefix
        public async Task<List<MasterNamePrefix>> GetMasterNamePrefixListAsync(MasterNamePrefix sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MasterNamePrefix>();
            try
            {
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterNamePrefixList";
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
                    results = JsonConvert.DeserializeObject<List<MasterNamePrefix>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MasterNamePrefix> GetMasterNamePrefixAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MasterNamePrefix();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterNamePrefix/{Id}";
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
                    result = JsonConvert.DeserializeObject<MasterNamePrefix>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddMasterNamePrefixAsync(MasterNamePrefix data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                //data.CreateBy = -1;


                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/AddMasterNamePrefix";

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
        public async Task<ApiResultsModel> UpdateMasterNamePrefixAsync(MasterNamePrefix data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}";

                //data.UpdateBy = -1;
                url += "/Master/UpdateMasterNamePrefix";
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

        //public async Task<ApiResultsModel> DeleteMasterNamePrefixAsync(int Id)
        //{
        //    var result = new ApiResultsModel();
        //    try
        //    {
        //        MasterNamePrefix data = new MasterNamePrefix();
        //        data.Id = Id;
        //        data.UpdateBy = -1;

        //        HttpClientHandler handler = new HttpClientHandler();
        //        using var _httpClient = new HttpClient(handler, false);
        //        var request = new HttpRequestMessage();
        //        //--Get Token
        //        var token = await _tokenService.GetTokenAsync();
        //        var url = $"{_settings.BaseUrlApi}/Master/DeleteMasterNamePrefix";
        //        request.Method = HttpMethod.Delete;
        //        request.Content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
        //        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        //        request.RequestUri = new Uri(url);

        //        var response = _httpClient.SendAsync(request).ConfigureAwait(false);
        //        var res = response.GetAwaiter().GetResult();

        //        res.EnsureSuccessStatusCode();
        //        if (res.IsSuccessStatusCode)
        //        {
        //            var json = await res.Content.ReadAsStringAsync();
        //            result = JsonConvert.DeserializeObject<ApiResultsModel>(json);
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return result;
        //}

        #endregion

        #region MasterMeetingRoomFormat
        public async Task<List<MasterMeetingRoomFormat>> GetMasterMeetingRoomFormatList(MasterMeetingRoomFormat sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MasterMeetingRoomFormat>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterMeetingRoomFormatList";
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
                    results = JsonConvert.DeserializeObject<List<MasterMeetingRoomFormat>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MasterMeetingRoomFormat> GetMasterMeetingRoomFormat(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MasterMeetingRoomFormat();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterMeetingRoomFormat/{Id}";
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
                    result = JsonConvert.DeserializeObject<MasterMeetingRoomFormat>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddMasterMeetingRoomFormat(MasterMeetingRoomFormat data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
               // data.CreateBy = -1;

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/AddMasterMeetingRoomFormat";

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
                result.Message = ex.Message;
                result.Type = ApiResultsType.error.ToString();
            }
            return result;
        }

        public async Task<ApiResultsModel> UpdateMasterMeetingRoomFormat(MasterMeetingRoomFormat data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                //data.UpdateBy = -1;

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}";

                url += "/Master/UpdateMasterMeetingRoomFormat";
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
                result.Message = ex.Message;
                result.Type = ApiResultsType.error.ToString();
            }
            return result;
        }

        public async Task<ApiResultsModel> DeleteMasterMeetingRoomFormat(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                //HttpClientHandler handler = new HttpClientHandler();
                //using var _httpClient = new HttpClient(handler, false);
                //var url = $"{_settings.BaseUrlApi}/Master/DeleteMasterGarage/{Id}";
                //var request = new HttpRequestMessage();
                ////--Get Token
                //var token = await _tokenService.GetTokenAsync();
                //request.Method = HttpMethod.Delete;
                //request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                //request.RequestUri = new Uri(url);

                //var response = _httpClient.SendAsync(request).ConfigureAwait(false);

                //var res = response.GetAwaiter().GetResult();

                MasterMeetingRoomFormat data = new MasterMeetingRoomFormat();
                data.Id = Id;
                data.UpdateBy = -1;

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/DeleteMasterMeetingRoomFormat";
                request.Method = HttpMethod.Delete;
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
                result.Message = ex.Message;
                result.Type = ApiResultsType.error.ToString();
            }
            return result;
        }

        #endregion

        #region MasterVehicleBookingFormat
        public async Task<List<MasterVehicleBookingFormat>> GetMasterVehicleBookingFormatListAsync(MasterVehicleBookingFormat sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MasterVehicleBookingFormat>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterVehicleBookingFormatList";
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
                    results = JsonConvert.DeserializeObject<List<MasterVehicleBookingFormat>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MasterVehicleBookingFormat> GetMasterVehicleBookingFormatAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MasterVehicleBookingFormat();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterVehicleBookingFormat/{Id}";
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
                    result = JsonConvert.DeserializeObject<MasterVehicleBookingFormat>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        #endregion

        #region MasterVehicleBookingStatus
        public async Task<List<MasterVehicleBookingStatus>> GetMasterVehicleBookingStatusListAsync(MasterVehicleBookingStatus sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MasterVehicleBookingStatus>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterVehicleBookingStatusList";
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
                    results = JsonConvert.DeserializeObject<List<MasterVehicleBookingStatus>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MasterVehicleBookingStatus> GetMasterVehicleBookingStatusAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MasterVehicleBookingStatus();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterVehicleBookingStatus/{Id}";
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
                    result = JsonConvert.DeserializeObject<MasterVehicleBookingStatus>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        #endregion

        #region MasterVehicleBookingType
        public async Task<List<MasterVehicleBookingType>> GetMasterVehicleBookingTypeListAsync(MasterVehicleBookingType sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MasterVehicleBookingType>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterVehicleBookingTypeList";
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
                    results = JsonConvert.DeserializeObject<List<MasterVehicleBookingType>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MasterVehicleBookingType> GetMasterVehicleBookingTypeAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MasterVehicleBookingType();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterVehicleBookingType/{Id}";
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
                    result = JsonConvert.DeserializeObject<MasterVehicleBookingType>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        #endregion

        #region MasterBookingType
        public async Task<List<MasterBookingType>> GetMasterBookingTypeListAsync(MasterBookingType sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MasterBookingType>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterBookingTypeList";
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
                    results = JsonConvert.DeserializeObject<List<MasterBookingType>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MasterBookingType> GetMasterBookingTypeAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MasterBookingType();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterBookingType/{Id}";
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
                    result = JsonConvert.DeserializeObject<MasterBookingType>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        #endregion

        #region MasterBookingStatus
        public async Task<List<MasterBookingStatus>> GetMasterBookingStatusListAsync(MasterBookingStatus sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MasterBookingStatus>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterBookingStatusList";
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
                    results = JsonConvert.DeserializeObject<List<MasterBookingStatus>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MasterBookingStatus> GetMasterBookingStatusAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MasterBookingStatus();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterBookingStatus/{Id}";
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
                    result = JsonConvert.DeserializeObject<MasterBookingStatus>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        #endregion

        #region MasterVideoConferenceBookingPriority
        public async Task<List<MasterVideoConferenceBookingPriority>> GetMasterVideoConferenceBookingPriorityListAsync(MasterVideoConferenceBookingPriority sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MasterVideoConferenceBookingPriority>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterVideoConferenceBookingPriorityList";
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
                    results = JsonConvert.DeserializeObject<List<MasterVideoConferenceBookingPriority>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MasterVideoConferenceBookingPriority> GetMasterVideoConferenceBookingPriorityAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MasterVideoConferenceBookingPriority();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterVideoConferenceBookingPriority/{Id}";
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
                    result = JsonConvert.DeserializeObject<MasterVideoConferenceBookingPriority>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        #endregion

        #region MasterCateringServiceParticipantType
        public async Task<List<MasterCateringServiceParticipantType>> GetMasterCateringServiceParticipantTypeListAsync(MasterCateringServiceParticipantType sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MasterCateringServiceParticipantType>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterCateringServiceParticipantTypeList";
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
                    results = JsonConvert.DeserializeObject<List<MasterCateringServiceParticipantType>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MasterCateringServiceParticipantType> GetMasterCateringServiceParticipantTypeAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MasterCateringServiceParticipantType();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterCateringServiceParticipantType/{Id}";
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
                    result = JsonConvert.DeserializeObject<MasterCateringServiceParticipantType>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        #endregion


        #region MasterFuelCode
        public async Task<ApiResultsModel> GetMasterFuelCodeListAsync(MasterFuelCode sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterFuelCodeList";
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
                    //var json = await res.Content.ReadAsStringAsync();
                    //results = JsonConvert.DeserializeObject<List<MasterFuelCode>>(json);
                    var json = await res.Content.ReadAsStringAsync();
                    results.Data = json;
                    results.Type = ApiResultsType.success.ToString();
                }
            }
            catch (Exception ex)
            {
                results.Type= ApiResultsType.error.ToString();
                results.Message = ex.Message;
            }
            return results;
        }

        public async Task<ApiResultsModel> GetMasterFuelCodeAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //--Get Token
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterFuelCode/{Id}";
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
                    //var json = await res.Content.ReadAsStringAsync();
                    //result = JsonConvert.DeserializeObject<MasterFuelCode>(json);
                    var json = await res.Content.ReadAsStringAsync();
                    results.Data = json;
                    results.Type = ApiResultsType.success.ToString();
                }

            }
            catch (Exception ex)
            {
                results.Type = ApiResultsType.error.ToString();
                results.Message = ex.Message;
            }
            return results;
        }

        public async Task<ApiResultsModel> AddMasterFuelCodeAsync(MasterFuelCode data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                //data.CreateBy = -1;

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/AddMasterFuelCode";

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

        public async Task<ApiResultsModel> UpdateMasterFuelCodeAsync(MasterFuelCode data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/UpdateMasterFuelCode";
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
                result.Type = ApiResultsType.error.ToString();
                result.Message = ex.Message;
            }
            return result;
        }

        public async Task<ApiResultsModel> DeleteMasterFuelCodeAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Master/DeleteMasterFuelCode/{Id}";
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
                result.Type = ApiResultsType.error.ToString();
                result.Message = ex.Message;
            }
            return result;
        }
        #endregion

        #region MasterBudgetExpenseType
        public async Task<ApiResultsModel> GetMasterBudgetExpenseTypeListAsync(MasterBudgetExpenseType sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetMasterBudgetExpenseTypeList";
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
                    //var json = await res.Content.ReadAsStringAsync();
                    //results = JsonConvert.DeserializeObject<List<MasterFuelCode>>(json);
                    var json = await res.Content.ReadAsStringAsync();
                    results.Data = json;
                    results.Type = ApiResultsType.success.ToString();
                }
            }
            catch (Exception ex)
            {
                results.Type = ApiResultsType.error.ToString();
                results.Message = ex.Message;
            }
            return results;
        }
        #endregion

        #region MasterUnit
        public async Task<List<VMasterUnit>> GetMasterUnitListAsync()
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VMasterUnit>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetListVMasterUnit?Active=true";
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();
                request.Method = HttpMethod.Get;
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", userCur?.UserToken);
                request.RequestUri = new Uri(url);

                var response = _httpClient.SendAsync(request).ConfigureAwait(false);
                var res = response.GetAwaiter().GetResult();

                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    results = JsonConvert.DeserializeObject<List<VMasterUnit>>(json);

                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return results;
        }
        #endregion
    }

}
