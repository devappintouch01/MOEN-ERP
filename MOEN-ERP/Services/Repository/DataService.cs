using DevExpress.Data.Mask.Internal;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using MOEN_ERP.Models.ViewModel;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using MOEN_ERP.DAL.Models;

namespace MOEN_ERP.Services.Repository
{
    public interface IDataService
    {
        #region Vehicel
        public Task<List<Vehicle>> GetVehicleListAsync(Vehicle sch);
        public Task<Vehicle> GetVehicleAsync(int Id);
        public Task<ApiResultsModel> AddVehicleAsync(Vehicle data);
        public Task<ApiResultsModel> UpdateVehicleAsync(Vehicle data);
        public Task<ApiResultsModel> DeleteVehicleAsync(int Id);
        #endregion

        #region VehicleTaxPaymentHistory
        public Task<List<VehicleTaxPaymentHistory>> GetVehicleTaxPaymentHistoryListAsync(VehicleTaxPaymentHistory sch);
        public Task<VehicleTaxPaymentHistory> GetVehicleTaxPaymentHistoryAsync(int Id);
        public Task<ApiResultsModel> AddVehicleTaxPaymentHistoryAsync(VehicleTaxPaymentHistory data);
        public Task<ApiResultsModel> UpdateVehicleTaxPaymentHistoryAsync(VehicleTaxPaymentHistory data);
        public Task<ApiResultsModel> DeleteVehicleTaxPaymentHistoryAsync(int Id);
        #endregion

        #region AudioVisualDevice
        public Task<List<AudioVisualDevice>> GetAudioVisualDeviceListAsync(AudioVisualDevice sch);
        public Task<AudioVisualDevice> GetAudioVisualDeviceAsync(int Id);
        public Task<ApiResultsModel> AddAudioVisualDeviceAsync(AudioVisualDevice data);
        public Task<ApiResultsModel> UpdateAudioVisualDeviceAsync(AudioVisualDevice data);
        public Task<ApiResultsModel> DeleteAudioVisualDeviceAsync(int Id);
        #endregion

        #region MeetingRoom
        public Task<List<MeetingRoom>> GetMeetingRoomListAsync(MeetingRoom sch);
        public Task<MeetingRoom> GetMeetingRoomAsync(int Id);
        public Task<ApiResultsModel> AddMeetingRoomAsync(MeetingRoom data);
        public Task<ApiResultsModel> UpdateMeetingRoomAsync(MeetingRoom data);
        public Task<ApiResultsModel> DeleteMeetingRoomAsync(int Id);
        #endregion

        #region CateringRestaurant
        public Task<List<CateringRestaurant>> GetCateringRestaurantListAsync(CateringRestaurant sch);
        public Task<CateringRestaurant> GetCateringRestaurantAsync(int Id);
        public Task<ApiResultsModel> AddCateringRestaurantAsync(CateringRestaurant data);
        public Task<ApiResultsModel> UpdateCateringRestaurantAsync(CateringRestaurant data);
        public Task<ApiResultsModel> DeleteCateringRestaurantAsync(int Id);
        #endregion

        #region CateringRestaurantFoodCategory
        public Task<List<CateringRestaurantFoodCategory>> GetCateringRestaurantFoodCategoryListAsync(CateringRestaurantFoodCategory sch);
        public Task<CateringRestaurantFoodCategory> GetCateringRestaurantFoodCategoryAsync(int Id);
        public Task<ApiResultsModel> AddCateringRestaurantFoodCategoryAsync(CateringRestaurantFoodCategory data);
        public Task<ApiResultsModel> UpdateCateringRestaurantFoodCategoryAsync(CateringRestaurantFoodCategory data);
        public Task<ApiResultsModel> DeleteCateringRestaurantFoodCategoryAsync(int Id);
        #endregion

        #region VehicleMaintenanceHistory
        public Task<List<VehicleMaintenanceHistory>> GetVehicleMaintenanceHistoryListAsync(VehicleMaintenanceHistory sch);
        public Task<VehicleMaintenanceHistory> GetVehicleMaintenanceHistoryAsync(int Id);
        public Task<ApiResultsModel> AddVehicleMaintenanceHistoryAsync(VehicleMaintenanceHistory data);
        public Task<ApiResultsModel> UpdateVehicleMaintenanceHistoryAsync(VehicleMaintenanceHistory data);
        public Task<ApiResultsModel> DeleteVehicleMaintenanceHistoryAsync(int Id);
        #endregion

        #region VehicleMaintenanceList
        public Task<List<VehicleMaintenanceList>> GetVehicleMaintenanceListListAsync(VehicleMaintenanceList sch);
        public Task<VehicleMaintenanceList> GetVehicleMaintenanceListAsync(int Id);
        public Task<ApiResultsModel> AddVehicleMaintenanceListAsync(VehicleMaintenanceList data);
        public Task<ApiResultsModel> UpdateVehicleMaintenanceListAsync(VehicleMaintenanceList data);
        public Task<ApiResultsModel> DeleteVehicleMaintenanceListAsync(int Id);
        #endregion

        #region AudioVisualServiceFormType
        public Task<List<AudioVisualServiceFormType>> GetAudioVisualServiceFormTypeListAsync(AudioVisualServiceFormType sch);
        public Task<AudioVisualServiceFormType> GetAudioVisualServiceFormTypeAsync(int Id);
        public Task<ApiResultsModel> AddAudioVisualServiceFormTypeAsync(AudioVisualServiceFormType data);
        public Task<ApiResultsModel> UpdateAudioVisualServiceFormTypeAsync(AudioVisualServiceFormType data);
        public Task<ApiResultsModel> DeleteAudioVisualServiceFormTypeAsync(int Id);
        #endregion

        #region AudioVisualService
        public Task<List<AudioVisualService>> GetAudioVisualServiceListAsync(AudioVisualService sch);
        public Task<AudioVisualService> GetAudioVisualServiceAsync(int Id);
        public Task<ApiResultsModel> AddAudioVisualServiceAsync(AudioVisualService data);
        public Task<ApiResultsModel> UpdateAudioVisualServiceAsync(AudioVisualService data);
        public Task<ApiResultsModel> DeleteAudioVisualServiceAsync(int Id);
        #endregion

        #region Asset
        public Task<List<Asset>> GetAssetListAsync(Asset sch);
        public Task<Asset> GetAssetAsync(int Id);
        #endregion

        #region Officer
        public Task<List<Officer>> GetOfficerListAsync(Officer sch);
        public Task<Officer> GetOfficerAsync(int Id);
        public Task<ApiResultsModel> AddOfficerAsync(Officer data);
        public Task<ApiResultsModel> UpdateOfficerAsync(Officer data);
        public Task<ApiResultsModel> DeleteOfficerAsync(int Id);
        #endregion

        #region MeetingRoomDevice
        public Task<List<MeetingRoomDevice>> GetMeetingRoomDeviceListAsync(MeetingRoomDevice sch);
        public Task<MeetingRoomDevice> GetMeetingRoomDeviceAsync(int Id);
        public Task<ApiResultsModel> AddMeetingRoomDeviceAsync(MeetingRoomDevice data);
        public Task<ApiResultsModel> UpdateMeetingRoomDeviceAsync(MeetingRoomDevice data);
        public Task<ApiResultsModel> DeleteMeetingRoomDeviceAsync(int Id);
        public Task<ApiResultsModel> DeleteMeetingRoomDeviceListAsync(int MeetingRoomId, int DeviceId);
        #endregion

        #region MeetingRoomFormat
        public Task<List<MeetingRoomFormat>> GetMeetingRoomFormatListAsync(MeetingRoomFormat sch);
        public Task<MeetingRoomFormat> GetMeetingRoomFormatAsync(int Id);
        public Task<ApiResultsModel> AddMeetingRoomFormatAsync(MeetingRoomFormat data);
        public Task<ApiResultsModel> UpdateMeetingRoomFormatAsync(MeetingRoomFormat data);
        public Task<ApiResultsModel> DeleteMeetingRoomFormatAsync(int Id);
        #endregion

        #region SystemRole
        public Task<List<SystemRole>> GetSystemRoleListAsync(SystemRole sch);
        public Task<SystemRole> GetSystemRoleAsync(int Id);
        public Task<List<SystemRole>> GetSystemRoleBySystemMenuGroupListAsync(int SystemMenuGroupId);
        #endregion

        #region Dashboard
        public Task<List<CalendarEvent>> GetEventsCars();
        public Task<List<CalendarTimelineEvent>> GetEventsTimelineCars(DateTime BookingId);
        public Task<List<CalendarTimelineResources>> GetEventsTimelineResourcesCars(DateTime BookingId);


        #endregion

        #region VideoConferenceBooking
        public Task<List<VideoConferenceBooking>> GetVideoConferenceBookingListAsync(VideoConferenceBooking sch);
        public Task<VideoConferenceBooking> GetVideoConferenceBookingAsync(int Id);
        public Task<VideoConferenceBooking> GetVideoConferenceBookingByMeetingRoomBookingIdAsync(int MeetingRoomBookingId);
        public Task<ApiResultsModel> AddVideoConferenceBookingAsync(VideoConferenceBooking data);
        public Task<ApiResultsModel> UpdateVideoConferenceBookingAsync(VideoConferenceBooking data);
        public Task<ApiResultsModel> DeleteVideoConferenceBookingAsync(int Id);

        #endregion

        #region MeetingRoomCalendar
        public Task<List<CalendarEvent>> GetEventsMeetingRoom();
        public Task<List<CalendarTimelineEvent>> GetEventsTimelineMeetingRoom(DateTime dateStart);
        public Task<List<CalendarTimelineResources>> GetEventsTimelineResourcesMeetingRoom(DateTime dateStart);
        #endregion

        #region VehicleQueue
        public Task<List<VehicleQueue>> GetVehicleQueueListAsync(VehicleQueue sch);
        public Task<VehicleQueue> GetVehicleQueueAsync(int Id);
        public Task<ApiResultsModel> AddVehicleQueueAsync(VehicleQueue data);
        public Task<ApiResultsModel> AddVehicleQueueListAsync(List<VehicleQueue> data);
        public Task<ApiResultsModel> UpdateVehicleQueueAsync(VehicleTaxPaymentHistory data);
        public Task<ApiResultsModel> DeleteVehicleQueueAsync(int Id);
        #endregion

        #region VehicleBookingRecord
        public Task<ApiResultsModel> GetVehicleBookingRecordListAsync(VehicleBookingRecord sch);
        public Task<ApiResultsModel> GetVehicleBookingRecordAsync(int Id);
        public Task<ApiResultsModel> AddVehicleQueueAsync(VehicleBookingRecord data);
        public Task<ApiResultsModel> UpdateVehicleBookingRecordAsync(VehicleBookingRecord data);
        public Task<ApiResultsModel> DeleteVehicleBookingRecordAsync(int Id);
        #endregion

        #region VehicleBookingAssign
        public Task<ApiResultsModel> GetVehicleBookingAssignListAsync(VehicleBookingAssign sch);
        public Task<ApiResultsModel> GetVehicleBookingAssignAsync(int Id);
        public Task<ApiResultsModel> AddVehicleBookingAssignAsync(VehicleBookingAssign data);
        public Task<ApiResultsModel> UpdateVehicleBookingAssignAsync(VehicleBookingAssign data);
        public Task<ApiResultsModel> DeleteVehicleBookingAssignAsync(int Id);
        #endregion

        #region SystemUser
        public Task<SystemUser> GetSystemUserAsync(int Id);
        #endregion

        #region SendEmailMeetingRoom
        public Task<ApiResultsModel> GetSendEmailMeetingRoomListAsync(SendEmailMeetingRoom sch);
        #endregion

        #region OfficerLineToken
        public  Task<ApiResultsModel> GetOfficerLineTokenAsync(int OfficerId);
        public Task<ApiResultsModel> AddOfficerLineTokenAsync(OfficerLineToken data);
        public Task<ApiResultsModel> DeleteOfficerLineTokenAsync(int Id);
        #endregion

    }

    public class DataService : IDataService
    {
        private readonly SettingsModel _settings;
        private readonly ITokenService _tokenService;

        public DataService(IOptions<SettingsModel> options, ITokenService tokenService)
        {
            _settings = options.Value;
            _tokenService = tokenService;
        }

        #region Vehicel
        public async Task<List<Vehicle>> GetVehicleListAsync(Vehicle sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<Vehicle>();
            try
            {
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetVehicleList";
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
                    results = JsonConvert.DeserializeObject<List<Vehicle>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<Vehicle> GetVehicleAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new Vehicle();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetVehicle/{Id}";
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
                    result = JsonConvert.DeserializeObject<Vehicle>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddVehicleAsync(Vehicle data)
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
                var url = $"{_settings.BaseUrlApi}/Data/AddVehicle";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> UpdateVehicleAsync(Vehicle data)
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
                var url = $"{_settings.BaseUrlApi}/Data/UpdateVehicle";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> DeleteVehicleAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                Vehicle data = new Vehicle();
                data.Id = Id;
                data.UpdateBy = -1;

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Data/DeleteVehicle/{Id}";
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

        #region VehicleTaxPaymentHistory
        public async Task<List<VehicleTaxPaymentHistory>> GetVehicleTaxPaymentHistoryListAsync(VehicleTaxPaymentHistory sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VehicleTaxPaymentHistory>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetVehicleTaxPaymentHistoryList";
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
                    results = JsonConvert.DeserializeObject<List<VehicleTaxPaymentHistory>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<VehicleTaxPaymentHistory> GetVehicleTaxPaymentHistoryAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new VehicleTaxPaymentHistory();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetVehicleTaxPaymentHistory/{Id}";
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
                    result = JsonConvert.DeserializeObject<VehicleTaxPaymentHistory>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddVehicleTaxPaymentHistoryAsync(VehicleTaxPaymentHistory data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();

                //--Get Token
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/AddVehicleTaxPaymentHistory";

                data.CreateBy = -1;
                //url += "";
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

        public async Task<ApiResultsModel> UpdateVehicleTaxPaymentHistoryAsync(VehicleTaxPaymentHistory data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();

                //--Get Token
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}";

                data.UpdateBy = -1;
                url += "/Data/UpdateVehicleTaxPaymentHistory";
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

        public async Task<ApiResultsModel> DeleteVehicleTaxPaymentHistoryAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Data/DeleteVehicleTaxPaymentHistory/{Id}";
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

        #region AudioVisualDevice
        public async Task<List<AudioVisualDevice>> GetAudioVisualDeviceListAsync(AudioVisualDevice sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<AudioVisualDevice>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetAudioVisualDeviceList";
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
                    results = JsonConvert.DeserializeObject<List<AudioVisualDevice>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<AudioVisualDevice> GetAudioVisualDeviceAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new AudioVisualDevice();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetAudioVisualDevice/{Id}";
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
                    result = JsonConvert.DeserializeObject<AudioVisualDevice>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }
        public async Task<ApiResultsModel> AddAudioVisualDeviceAsync(AudioVisualDevice data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();

                //--Get Token
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/AddAudioVisualDevice";

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
        public async Task<ApiResultsModel> UpdateAudioVisualDeviceAsync(AudioVisualDevice data)
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
                var url = $"{_settings.BaseUrlApi}/Data/UpdateAudioVisualDevice";

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
        public async Task<ApiResultsModel> DeleteAudioVisualDeviceAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Data/DeleteAudioVisualDevice/{Id}";
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

        #region MeetingRoom
        public async Task<List<MeetingRoom>> GetMeetingRoomListAsync(MeetingRoom sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MeetingRoom>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetMeetingRoomList";
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
                    results = JsonConvert.DeserializeObject<List<MeetingRoom>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MeetingRoom> GetMeetingRoomAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MeetingRoom();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetMeetingRoom/{Id}";
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
                    result = JsonConvert.DeserializeObject<MeetingRoom>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddMeetingRoomAsync(MeetingRoom data)
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
                var url = $"{_settings.BaseUrlApi}/Data/AddMeetingRoom";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> UpdateMeetingRoomAsync(MeetingRoom data)
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
                var url = $"{_settings.BaseUrlApi}/Data/UpdateMeetingRoom";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> DeleteMeetingRoomAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Data/DeleteMeetingRoom/{Id}";
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

        #region CateringRestaurant
        public async Task<List<CateringRestaurant>> GetCateringRestaurantListAsync(CateringRestaurant sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<CateringRestaurant>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetCateringRestaurantList";
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
                    results = JsonConvert.DeserializeObject<List<CateringRestaurant>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<CateringRestaurant> GetCateringRestaurantAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new CateringRestaurant();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetCateringRestaurant/{Id}";
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
                    result = JsonConvert.DeserializeObject<CateringRestaurant>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddCateringRestaurantAsync(CateringRestaurant data)
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
                var url = $"{_settings.BaseUrlApi}/Data/AddCateringRestaurant";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> UpdateCateringRestaurantAsync(CateringRestaurant data)
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
                var url = $"{_settings.BaseUrlApi}/Data/UpdateCateringRestaurant";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> DeleteCateringRestaurantAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Data/DeleteCateringRestaurant/{Id}";
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

        #region CateringRestaurantFoodCategory
        public async Task<List<CateringRestaurantFoodCategory>> GetCateringRestaurantFoodCategoryListAsync(CateringRestaurantFoodCategory sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<CateringRestaurantFoodCategory>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetCateringRestaurantFoodCategoryList";
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
                    results = JsonConvert.DeserializeObject<List<CateringRestaurantFoodCategory>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<CateringRestaurantFoodCategory> GetCateringRestaurantFoodCategoryAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new CateringRestaurantFoodCategory();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetCateringRestaurantFoodCategory/{Id}";
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
                    result = JsonConvert.DeserializeObject<CateringRestaurantFoodCategory>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddCateringRestaurantFoodCategoryAsync(CateringRestaurantFoodCategory data)
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
                var url = $"{_settings.BaseUrlApi}/Data/AddCateringRestaurantFoodCategory";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> UpdateCateringRestaurantFoodCategoryAsync(CateringRestaurantFoodCategory data)
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
                var url = $"{_settings.BaseUrlApi}/Data/UpdateCateringRestaurantFoodCategory";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> DeleteCateringRestaurantFoodCategoryAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Data/DeleteCateringRestaurantFoodCategory/{Id}";
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

        #region VehicleMaintenanceHistory
        public async Task<List<VehicleMaintenanceHistory>> GetVehicleMaintenanceHistoryListAsync(VehicleMaintenanceHistory sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VehicleMaintenanceHistory>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetVehicleMaintenanceHistoryList";
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
                    results = JsonConvert.DeserializeObject<List<VehicleMaintenanceHistory>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<VehicleMaintenanceHistory> GetVehicleMaintenanceHistoryAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new VehicleMaintenanceHistory();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetVehicleMaintenanceHistory/{Id}";
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
                    result = JsonConvert.DeserializeObject<VehicleMaintenanceHistory>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddVehicleMaintenanceHistoryAsync(VehicleMaintenanceHistory data)
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
                var url = $"{_settings.BaseUrlApi}/Data/AddVehicleMaintenanceHistory";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> UpdateVehicleMaintenanceHistoryAsync(VehicleMaintenanceHistory data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();

                //--Get Token
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/UpdateVehicleMaintenanceHistory";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> DeleteVehicleMaintenanceHistoryAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Data/DeleteVehicleMaintenanceHistory/{Id}";
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

        #region VehicleMaintenanceList
        public async Task<List<VehicleMaintenanceList>> GetVehicleMaintenanceListListAsync(VehicleMaintenanceList sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VehicleMaintenanceList>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetVehicleMaintenanceListList";
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
                    results = JsonConvert.DeserializeObject<List<VehicleMaintenanceList>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<VehicleMaintenanceList> GetVehicleMaintenanceListAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new VehicleMaintenanceList();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetVehicleMaintenanceList/{Id}";
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
                    result = JsonConvert.DeserializeObject<VehicleMaintenanceList>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddVehicleMaintenanceListAsync(VehicleMaintenanceList data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();

                //--Get Token
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/AddVehicleMaintenanceList";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> UpdateVehicleMaintenanceListAsync(VehicleMaintenanceList data)
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
                var url = $"{_settings.BaseUrlApi}/Data/UpdateVehicleMaintenanceList";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> DeleteVehicleMaintenanceListAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Data/DeleteVehicleMaintenanceList/{Id}";
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

        #region AudioVisualServiceFormType
        public async Task<List<AudioVisualServiceFormType>> GetAudioVisualServiceFormTypeListAsync(AudioVisualServiceFormType sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<AudioVisualServiceFormType>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetAudioVisualServiceFormTypeList";
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
                    results = JsonConvert.DeserializeObject<List<AudioVisualServiceFormType>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<AudioVisualServiceFormType> GetAudioVisualServiceFormTypeAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new AudioVisualServiceFormType();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetAudioVisualServiceFormType/{Id}";
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
                    result = JsonConvert.DeserializeObject<AudioVisualServiceFormType>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddAudioVisualServiceFormTypeAsync(AudioVisualServiceFormType data)
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
                var url = $"{_settings.BaseUrlApi}/Data/AddAudioVisualServiceFormType";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> UpdateAudioVisualServiceFormTypeAsync(AudioVisualServiceFormType data)
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
                var url = $"{_settings.BaseUrlApi}/Data/UpdateAudioVisualServiceFormType";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> DeleteAudioVisualServiceFormTypeAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Data/DeleteAudioVisualServiceFormType/{Id}";
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

        #region AudioVisualService
        public async Task<List<AudioVisualService>> GetAudioVisualServiceListAsync(AudioVisualService sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<AudioVisualService>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetAudioVisualServiceList";
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
                    results = JsonConvert.DeserializeObject<List<AudioVisualService>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<AudioVisualService> GetAudioVisualServiceAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new AudioVisualService();
            try
            {
                //--Get Token
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetAudioVisualService/{Id}";
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
                    result = JsonConvert.DeserializeObject<AudioVisualService>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddAudioVisualServiceAsync(AudioVisualService data)
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
                var url = $"{_settings.BaseUrlApi}/Data/AddAudioVisualService";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> UpdateAudioVisualServiceAsync(AudioVisualService data)
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
                var url = $"{_settings.BaseUrlApi}/Data/UpdateAudioVisualService";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> DeleteAudioVisualServiceAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Data/DeleteAudioVisualService/{Id}";
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

        #region Asset
        public async Task<List<Asset>> GetAssetListAsync(Asset sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<Asset>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetAssetList";
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
                    results = JsonConvert.DeserializeObject<List<Asset>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<Asset> GetAssetAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new Asset();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetAsset/{Id}";
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
                    result = JsonConvert.DeserializeObject<Asset>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }


        #endregion

        #region Officer
        public async Task<List<Officer>> GetOfficerListAsync(Officer sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<Officer>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetOfficerList";
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
                    results = JsonConvert.DeserializeObject<List<Officer>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<Officer> GetOfficerAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new Officer();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetOfficer/{Id}";
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
                    result = JsonConvert.DeserializeObject<Officer>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddOfficerAsync(Officer data)
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
                var url = $"{_settings.BaseUrlApi}/Data/AddOfficer";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> UpdateOfficerAsync(Officer data)
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
                var url = $"{_settings.BaseUrlApi}/Data/UpdateOfficer";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> DeleteOfficerAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Data/DeleteOfficer/{Id}";
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                request.Method = HttpMethod.Delete;
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", userCur?.UserToken);
                request.RequestUri = new Uri(url);

                var response = _httpClient.SendAsync(request).ConfigureAwait(false);

                var res = response.GetAwaiter().GetResult();

                //Officer data = new Officer();
                //data.Id = Id;
                //data.UpdateBy = -1;

                //HttpClientHandler handler = new HttpClientHandler();
                //using var _httpClient = new HttpClient(handler, false);
                //var request = new HttpRequestMessage();
                ////--Get Token
                //var token = await _tokenService.GetTokenAsync();
                //var url = $"{_settings.BaseUrlApi}/Data/DeleteOfficer";
                //request.Method = HttpMethod.Delete;
                //request.Content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                //request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                //request.RequestUri = new Uri(url);

                //var response = _httpClient.SendAsync(request).ConfigureAwait(false);
                //var res = response.GetAwaiter().GetResult();

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

        #region MeetingRoomDevice
        public async Task<List<MeetingRoomDevice>> GetMeetingRoomDeviceListAsync(MeetingRoomDevice sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MeetingRoomDevice>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetMeetingRoomDeviceList";
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
                    results = JsonConvert.DeserializeObject<List<MeetingRoomDevice>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MeetingRoomDevice> GetMeetingRoomDeviceAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MeetingRoomDevice();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetMeetingRoomDevice/{Id}";
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
                    result = JsonConvert.DeserializeObject<MeetingRoomDevice>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddMeetingRoomDeviceAsync(MeetingRoomDevice data)
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
                var url = $"{_settings.BaseUrlApi}/Data/AddMeetingRoomDevice";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> UpdateMeetingRoomDeviceAsync(MeetingRoomDevice data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
               // data.UpdateBy = -1;

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();

                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/UpdateMeetingRoomDevice";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> DeleteMeetingRoomDeviceAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Data/DeleteMeetingRoomDevice/{Id}";
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                request.Method = HttpMethod.Delete;
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", userCur?.UserToken);
                request.RequestUri = new Uri(url);

                var response = _httpClient.SendAsync(request).ConfigureAwait(false);

                var res = response.GetAwaiter().GetResult();

                //Officer data = new Officer();
                //data.Id = Id;
                //data.UpdateBy = -1;

                //HttpClientHandler handler = new HttpClientHandler();
                //using var _httpClient = new HttpClient(handler, false);
                //var request = new HttpRequestMessage();
                ////--Get Token
                //var token = await _tokenService.GetTokenAsync();
                //var url = $"{_settings.BaseUrlApi}/Data/DeleteOfficer";
                //request.Method = HttpMethod.Delete;
                //request.Content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                //request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                //request.RequestUri = new Uri(url);

                //var response = _httpClient.SendAsync(request).ConfigureAwait(false);
                //var res = response.GetAwaiter().GetResult();

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

        public async Task<ApiResultsModel> DeleteMeetingRoomDeviceListAsync(int MeetingRoomId, int DeviceId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Data/DeleteMeetingRoomDeviceList/{MeetingRoomId}/{DeviceId}";
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

        #region MeetingRoomFormat
        public async Task<List<MeetingRoomFormat>> GetMeetingRoomFormatListAsync(MeetingRoomFormat sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<MeetingRoomFormat>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetMeetingRoomFormatList";
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
                    results = JsonConvert.DeserializeObject<List<MeetingRoomFormat>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<MeetingRoomFormat> GetMeetingRoomFormatAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new MeetingRoomFormat();
            try
            {
                //--Get Token
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetMeetingRoomFormat/{Id}";
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
                    result = JsonConvert.DeserializeObject<MeetingRoomFormat>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddMeetingRoomFormatAsync(MeetingRoomFormat data)
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
                var url = $"{_settings.BaseUrlApi}/Data/AddMeetingRoomFormat";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> UpdateMeetingRoomFormatAsync(MeetingRoomFormat data)
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
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/UpdateMeetingRoomFormat";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> DeleteMeetingRoomFormatAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Data/DeleteMeetingRoomFormat/{Id}";
                var request = new HttpRequestMessage();
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                request.Method = HttpMethod.Delete;
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", userCur?.UserToken);
                request.RequestUri = new Uri(url);

                var response = _httpClient.SendAsync(request).ConfigureAwait(false);

                var res = response.GetAwaiter().GetResult();

                //Officer data = new Officer();
                //data.Id = Id;
                //data.UpdateBy = -1;

                //HttpClientHandler handler = new HttpClientHandler();
                //using var _httpClient = new HttpClient(handler, false);
                //var request = new HttpRequestMessage();
                ////--Get Token
                //var token = await _tokenService.GetTokenAsync();
                //var url = $"{_settings.BaseUrlApi}/Data/DeleteOfficer";
                //request.Method = HttpMethod.Delete;
                //request.Content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                //request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                //request.RequestUri = new Uri(url);

                //var response = _httpClient.SendAsync(request).ConfigureAwait(false);
                //var res = response.GetAwaiter().GetResult();

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

        #region SystemRole
        public async Task<List<SystemRole>> GetSystemRoleListAsync(SystemRole sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<SystemRole>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetSystemRoleList";
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
                    results = JsonConvert.DeserializeObject<List<SystemRole>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<SystemRole> GetSystemRoleAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new SystemRole();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetSystemRole/{Id}";
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
                    result = JsonConvert.DeserializeObject<SystemRole>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<List<SystemRole>> GetSystemRoleBySystemMenuGroupListAsync(int SystemMenuGroupId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<SystemRole>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                //var url = $"{_settings.BaseUrlApi}/Data/GetSystemRole/{Id}";
                //HttpClientHandler handler = new HttpClientHandler();
                //using var _httpClient = new HttpClient(handler, false);
                //var cotentData = JsonConvert.SerializeObject(sch);
                //var request = new HttpRequestMessage();
                //request.Method = HttpMethod.Get;
                //request.Content = new StringContent(cotentData, Encoding.UTF8, "application/json");
                //request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                //request.RequestUri = new Uri(url);


                //var response = _httpClient.SendAsync(request).ConfigureAwait(false);

                //var res = response.GetAwaiter().GetResult();

                //res.EnsureSuccessStatusCode();


                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetSystemRoleBySystemMenuGroupList/{SystemMenuGroupId}";
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                //var cotentData = JsonConvert.SerializeObject(sch);
                var request = new HttpRequestMessage();
                request.Method = HttpMethod.Get;
                //request.Content = new StringContent(cotentData, Encoding.UTF8, "application/json");
                request.Content = new StringContent("application/json");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", userCur?.UserToken);
                request.RequestUri = new Uri(url);


                var response = _httpClient.SendAsync(request).ConfigureAwait(false);

                var res = response.GetAwaiter().GetResult();

                res.EnsureSuccessStatusCode();

                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    results = JsonConvert.DeserializeObject<List<SystemRole>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region Dashboard
        public async Task<List<CalendarEvent>> GetEventsCars()
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<CalendarEvent>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetEventsCars";
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
                    results = JsonConvert.DeserializeObject<List<CalendarEvent>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<List<CalendarTimelineEvent>> GetEventsTimelineCars(DateTime DateStart)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<CalendarTimelineEvent>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetEventsTimelineCars";
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var cotentData = JsonConvert.SerializeObject(new { DateTimeValue = DateStart });
                var request = new HttpRequestMessage();
                request.Method = HttpMethod.Post;
                request.Content = new StringContent(cotentData, Encoding.UTF8, "application/json");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", userCur?.UserToken);
                request.RequestUri = new Uri(url);


                var response = _httpClient.SendAsync(request).ConfigureAwait(false);

                var res = response.GetAwaiter().GetResult();

                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    results = JsonConvert.DeserializeObject<List<CalendarTimelineEvent>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<List<CalendarTimelineResources>> GetEventsTimelineResourcesCars(DateTime DateStart)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<CalendarTimelineResources>();
            try
            {

                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetEventsTimelineResourcesCars";
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var cotentData = JsonConvert.SerializeObject(new { DateTimeValue = DateStart });
                var request = new HttpRequestMessage();
                request.Method = HttpMethod.Post;
                request.Content = new StringContent(cotentData, Encoding.UTF8, "application/json");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", userCur?.UserToken);
                request.RequestUri = new Uri(url);


                var response = _httpClient.SendAsync(request).ConfigureAwait(false);

                var res = response.GetAwaiter().GetResult();

                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    results = JsonConvert.DeserializeObject<List<CalendarTimelineResources>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        #endregion

        #region VideoConferenceBooking
        public async Task<List<VideoConferenceBooking>> GetVideoConferenceBookingListAsync(VideoConferenceBooking sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VideoConferenceBooking>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetVideoConferenceBookingList";
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
                    results = JsonConvert.DeserializeObject<List<VideoConferenceBooking>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<VideoConferenceBooking> GetVideoConferenceBookingAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new VideoConferenceBooking();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetVideoConferenceBooking/{Id}";
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
                    result = JsonConvert.DeserializeObject<VideoConferenceBooking>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<VideoConferenceBooking> GetVideoConferenceBookingByMeetingRoomBookingIdAsync(int MeetingRoomBookingId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new VideoConferenceBooking();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetVideoConferenceBookingByMeetingRoomBookingId/{MeetingRoomBookingId}";
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
                    result = JsonConvert.DeserializeObject<VideoConferenceBooking>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }
        public async Task<ApiResultsModel> AddVideoConferenceBookingAsync(VideoConferenceBooking data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();

                //--Get Token
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/AddVideoConferenceBooking";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> UpdateVideoConferenceBookingAsync(VideoConferenceBooking data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();

                //--Get Token
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/UpdateVideoConferenceBooking";

                data.UpdateBy = -1;
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

        public async Task<ApiResultsModel> DeleteVideoConferenceBookingAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                //VideoConferenceBooking data = new VideoConferenceBooking();
                //data.Id = Id;
                //data.UpdateBy = -1;

                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Data/DeleteVideoConferenceBooking/{Id}";
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

        #region MeetingRoomCalendar

        public async Task<List<CalendarEvent>> GetEventsMeetingRoom()
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<CalendarEvent>();
            try
            {
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetEventsMeetingRoom";
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
                    results = JsonConvert.DeserializeObject<List<CalendarEvent>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<List<CalendarTimelineEvent>> GetEventsTimelineMeetingRoom(DateTime DateStart)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<CalendarTimelineEvent>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetEventsTimelineMeetingRoom";
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var cotentData = JsonConvert.SerializeObject(new { DateTimeValue = DateStart });
                var request = new HttpRequestMessage();
                request.Method = HttpMethod.Post;
                request.Content = new StringContent(cotentData, Encoding.UTF8, "application/json");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", userCur?.UserToken);
                request.RequestUri = new Uri(url);


                var response = _httpClient.SendAsync(request).ConfigureAwait(false);

                var res = response.GetAwaiter().GetResult();

                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    results = JsonConvert.DeserializeObject<List<CalendarTimelineEvent>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<List<CalendarTimelineResources>> GetEventsTimelineResourcesMeetingRoom(DateTime DateStart)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<CalendarTimelineResources>();
            try
            {

               //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetEventsTimelineResourcesMeetingRoom";
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var cotentData = JsonConvert.SerializeObject(new { DateTimeValue = DateStart });
                var request = new HttpRequestMessage();
                request.Method = HttpMethod.Post;
                request.Content = new StringContent(cotentData, Encoding.UTF8, "application/json");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", userCur?.UserToken);
                request.RequestUri = new Uri(url);


                var response = _httpClient.SendAsync(request).ConfigureAwait(false);

                var res = response.GetAwaiter().GetResult();

                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    results = JsonConvert.DeserializeObject<List<CalendarTimelineResources>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        #endregion

        #region VehicleQueue
        public async Task<List<VehicleQueue>> GetVehicleQueueListAsync(VehicleQueue sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VehicleQueue>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetVehicleQueueList";
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
                    results = JsonConvert.DeserializeObject<List<VehicleQueue>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<VehicleQueue> GetVehicleQueueAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new VehicleQueue();
            try
            {
                //--Get Token
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetVehicleQueue/{Id}";
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
                    result = JsonConvert.DeserializeObject<VehicleQueue>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<ApiResultsModel> AddVehicleQueueAsync(VehicleQueue data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();

                //--Get Token
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/AddVehicleQueue";

                data.CreateBy = -1;
                //url += "";
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

        public async Task<ApiResultsModel> AddVehicleQueueListAsync(List<VehicleQueue> data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();

                //--Get Token
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/AddVehicleQueueList";

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

        public async Task<ApiResultsModel> UpdateVehicleQueueAsync(VehicleTaxPaymentHistory data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var request = new HttpRequestMessage();

                //--Get Token
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}";

                data.UpdateBy = -1;
                url += "/Data/UpdateVehicleQueue";
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

        public async Task<ApiResultsModel> DeleteVehicleQueueAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Data/DeleteVehicleQueue/{Id}";
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
                result.Type = ApiResultsType.error.ToString();
                result.Message = ex.Message;
            }
            return result;
        }
        #endregion

        #region VehicleBookingRecord
        public async Task<ApiResultsModel> GetVehicleBookingRecordListAsync(VehicleBookingRecord sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetVehicleBookingRecordList";
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
                    result.Data = json;
                    result.Type = ApiResultsType.success.ToString();
                }
            }
            catch (Exception ex)
            {
                result.Type = ApiResultsType.error.ToString();
                result.Message = ex.Message;
            }
            return result;
        }

        public async Task<ApiResultsModel> GetVehicleBookingRecordAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetVehicleBookingRecord/{Id}";
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
                    result.Data = json;
                    result.Type = ApiResultsType.success.ToString();
                }

            }
            catch (Exception ex)
            {
                result.Type = ApiResultsType.error.ToString();
                result.Message = ex.Message;
            }
            return result;
        }

        public async Task<ApiResultsModel> AddVehicleQueueAsync(VehicleBookingRecord data)
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
                var url = $"{_settings.BaseUrlApi}/Data/AddVehicleBookingRecord";

                data.CreateBy = -1;
                //url += "";
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

        public async Task<ApiResultsModel> UpdateVehicleBookingRecordAsync(VehicleBookingRecord data)
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
                var url = $"{_settings.BaseUrlApi}/Data/UpdateVehicleQueue";
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

        public async Task<ApiResultsModel> DeleteVehicleBookingRecordAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Data/DeleteVehicleBookingRecord/{Id}";
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

        #region VehicleBookingAssign
        public async Task<ApiResultsModel> GetVehicleBookingAssignListAsync(VehicleBookingAssign sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetVehicleBookingAssignList";
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
                    result.Data = json;
                    result.Type = ApiResultsType.success.ToString();
                }
            }
            catch (Exception ex)
            {
                result.Type = ApiResultsType.error.ToString();
                result.Message = ex.Message;
            }
            return result;
        }

        public async Task<ApiResultsModel> GetVehicleBookingAssignAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetVehicleBookingAssign/{Id}";
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
                    result.Data = json;
                    result.Type = ApiResultsType.success.ToString();
                }

            }
            catch (Exception ex)
            {
                result.Type = ApiResultsType.error.ToString();
                result.Message = ex.Message;
            }
            return result;
        }

        public async Task<ApiResultsModel> AddVehicleBookingAssignAsync(VehicleBookingAssign data)
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
                var url = $"{_settings.BaseUrlApi}/Data/AddVehicleBookingAssign";

                data.CreateBy = -1;
                //url += "";
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

        public async Task<ApiResultsModel> UpdateVehicleBookingAssignAsync(VehicleBookingAssign data)
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
                var url = $"{_settings.BaseUrlApi}/Data/UpdateVehicleBookingAssign";
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

        public async Task<ApiResultsModel> DeleteVehicleBookingAssignAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Data/DeleteVehicleBookingAssign/{Id}";
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

        #region SystemUser
        public async Task<SystemUser> GetSystemUserAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new SystemUser();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetSystemUser/{Id}";
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
                    result = JsonConvert.DeserializeObject<SystemUser>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return result;
        }
        #endregion

        #region SendEmailMeetingRoom
        public async Task<ApiResultsModel> GetSendEmailMeetingRoomListAsync(SendEmailMeetingRoom sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetSendEmailMeetingRoomList";
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
                    result.Data = json;
                    result.Type = ApiResultsType.success.ToString();
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

        #region OfficerLineToken
       

        public async Task<ApiResultsModel> GetOfficerLineTokenAsync(int OfficerId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                //--Get Token
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Data/GetOfficerLineToken/{OfficerId}";
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
                    result.Data = json;
                    result.Type = ApiResultsType.success.ToString();
                }
                else {
                    throw new Exception(result.Message);
                }

            }
            catch (Exception ex)
            {
                result.Type = ApiResultsType.error.ToString();
                result.Message = ex.Message;
            }
            return result;
        }

        public async Task<ApiResultsModel> AddOfficerLineTokenAsync(OfficerLineToken data)
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
                var url = $"{_settings.BaseUrlApi}/Data/AddOfficerLineToken";
            
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
                else
                {
                    throw new Exception(result.Message);
                }


            }
            catch (Exception ex)
            {
                result.Type = ApiResultsType.error.ToString();
                result.Message = ex.Message;
            }
            return result;
        }

      

        public async Task<ApiResultsModel> DeleteOfficerLineTokenAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var result = new ApiResultsModel();
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var url = $"{_settings.BaseUrlApi}/Data/DeleteOfficerLineToken/{Id}";
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
                else
                {
                    throw new Exception(result.Message);
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


    }
}
