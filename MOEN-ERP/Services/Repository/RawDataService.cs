using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using MOEN_ERP.Models.ViewModel;
using MOEN_ERP.Models.ViewModel.VehicleManagement;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using MOEN_ERP.DAL.Models;
using VBudgetRequest = MOEN_ERP.DAL.Models.VBudgetRequest;

namespace MOEN_ERP.Services.Repository
{
    public interface IRawDataService
    {

        #region V_VehicleTaxPaymentHistoryDetail
        public Task<List<VVehicleTaxPaymentHistoryDetail>> GetViewVehicleTaxPaymentHistoryDetailListAsync(VVehicleTaxPaymentHistoryDetail sch);
        public Task<VVehicleTaxPaymentHistoryDetail> GetViewVehicleTaxPaymentHistoryDetailAsync(int Id);
        #endregion

        #region V_VehicleTaxPaymentHistory
        public Task<List<VVehicleTaxPaymentHistory>> GetViewVehicleTaxPaymentHistoryListAsync(VVehicleTaxPaymentHistory sch);
        public Task<VVehicleTaxPaymentHistory> GetViewVehicleTaxPaymentHistoryAsync(int VehicleId);
        #endregion

        #region V_AudioVisualDevice
        public Task<List<VAudioVisualDevice>> GetViewAudioVisualDeviceListAsync(VAudioVisualDevice sch);
        public Task<VAudioVisualDevice> GetViewAudioVisualDeviceAsync(int VehicleId);
        #endregion

        #region V_Vehicle
        public Task<List<VVehicle>> GetViewVehicleListAsync(VVehicle sch);
        public Task<VVehicle> GetViewVehicleAsync(int VehicleId);
        #endregion

        #region V_Officer
        public Task<List<VOfficer>> GetViewOfficerListAsync(VOfficer sch);
        public Task<VOfficer> GetViewOfficerAsync(int Id);
        public Task<VOfficer> GetViewOfficerBySystemUserIdAsync(int SystemUserId);
        public Task<List<VOfficer>> GetViewOfficerVehicleBookingDirectorListAsync();
        #endregion

        #region V_MeetingRoom
        public Task<List<VMeetingRoom>> GetViewMeetingRoomListAsync(VMeetingRoom sch);
        public Task<VMeetingRoom> GetViewMeetingRoomAsync(int RoomId);
        #endregion

        #region V_VideoConferenceLicense
        public Task<List<VVideoConferenceLicense>> GetViewVideoConferenceLicenseListAsync(VVideoConferenceLicense sch);
        public Task<VVideoConferenceLicense> GetViewVideoConferenceLicenseAsync(int LicenseId);
        #endregion

        #region V_VehicleBrandModel
        public Task<List<VVehicleBrandModel>> GetViewVehicleBrandModelListAsync(VVehicleBrandModel sch);
        public Task<VVehicleBrandModel> GetViewVehicleBrandModelAsync(int BrandId);
        #endregion

        #region V_Restaurant
        public Task<List<VRestaurant>> GetViewRestaurantListAsync(VRestaurant sch);
        public Task<VRestaurant> GetViewRestaurantAsync(int RestaurantId);
        #endregion

        #region V_VehicleMaintenanceHistory
        public Task<List<VVehicleMaintenanceHistory>> GetViewVehicleMaintenanceHistoryListAsync(VVehicleMaintenanceHistory sch);
        public Task<VVehicleMaintenanceHistory> GetViewVehicleMaintenanceHistoryAsync(int VehicleId);
        #endregion

        #region V_VehicleMaintenanceHistoryDetail
        public Task<List<VVehicleMaintenanceHistoryDetail>> GetViewVehicleMaintenanceHistoryDetailListAsync(VVehicleMaintenanceHistoryDetail sch);
        public Task<VVehicleMaintenanceHistoryDetail> GetViewVehicleMaintenanceHistoryDetailAsync(int Id);
        #endregion

        #region V_AudioVisualService
        public Task<List<VAudioVisualService>> GetViewAudioVisualServiceListAsync(VAudioVisualService sch);
        public Task<VAudioVisualService> GetViewAudioVisualServiceAsync(int Id);
        #endregion

        #region V_MeetingRoomDevice
        public Task<List<VMeetingRoomDevice>> GetViewMeetingRoomDeviceListAsync(VMeetingRoomDevice sch);
        public Task<VMeetingRoomDevice> GetViewMeetingRoomDeviceAsync(int Id);
        #endregion

        #region V_SystemUserRoleAssign
        public Task<List<VSystemUserRoleAssign>> GetViewSystemUserRoleAssignListAsync(VSystemUserRoleAssign sch);
        public Task<VSystemUserRoleAssign> GetViewSystemUserRoleAssignAsync(int Id);
        #endregion

        #region FN_BookingSystemMenu
        public Task<List<SystemMenu>> GetFunctionSystemMenuListAsync(FunctionSystemMenu sch);
        #endregion

        #region V_VehicleBooking
        public Task<List<VVehicleDashboard>> GetViewVehicleBookingListAsync(VVehicleDashboard sch);
        public Task<VVehicleBooking> GetViewVehicleBookingAsync(int BookingId);
        #endregion

        #region V_VehicleBookingHistory
        public Task<List<VVehicleBookingHistory>> GetViewVehicleBookingHistoryListAsync(VVehicleBookingHistory sch);
        public Task<VVehicleBookingHistory> GetViewVehicleBookingHistoryAsync(int HistoryId);
        #endregion

        #region V_MasterOrganization
        public Task<List<VMasterOrganization>> GetViewMasterOrganizationListAsync(VMasterOrganization sch);
        public Task<VMasterOrganization> GetViewMasterOrganizationAsync(int Id);
        #endregion

        #region R_VehicleBookingForm
        public Task<List<RVehicleBookingForm>> GetReportVehicleBookingFormListAsync(RVehicleBookingForm sch);
        public Task<RVehicleBookingForm> GetReportVehicleBookingFormAsync(int BookingId);
        public Task<RVehicleBookingForm> GetReportVehicleBookingFormByVehicleBookingAssignIdAsync(int VehicleBookingAssignId);
        #endregion

        #region V_MasterFoodCategory
        public Task<List<VMasterFoodCategory>> GetViewMasterFoodCategoryListAsync(VMasterFoodCategory sch);
        public Task<VMasterFoodCategory> GetViewMasterFoodCategoryAsync(int Id);
        #endregion

        #region V_MeetingRoomBooking
        public Task<List<VMeetingRoomBooking>> GetViewMeetingRoomBookingListAsync(VMeetingRoomBooking sch);
        public Task<VMeetingRoomBooking> GetViewMeetingRoomBookingAsync(int MeetingRoomBookingId);
        #endregion

        #region V_AudioVisualServiceFormDisplay
        public Task<List<VAudioVisualServiceFormDisplay>> GetViewAudioVisualServiceFormDisplayListAsync(VAudioVisualServiceFormDisplay sch);
        public Task<VAudioVisualServiceFormDisplay> GetViewAudioVisualServiceFormDisplayAsync(int Id);
        #endregion

        #region V_VideoConferenceBooking
        public Task<List<VVideoConferenceBooking>> GetViewVideoConferenceBookingListAsync(VVideoConferenceBooking sch);
        public Task<VVideoConferenceBooking> GetViewVideoConferenceBookingAsync(int VideoConferenceBookingId);
        #endregion

        #region V_CateringRestaurant
        public Task<List<VCateringRestaurant>> GetViewCateringRestaurantListAsync(VCateringRestaurant sch);
        public Task<VCateringRestaurant> GetViewCateringRestaurantAsync(int Id);
        #endregion

        #region R_AudioVisualServiceRequestForm
        public Task<List<RAudioVisualServiceRequestForm>> GetReportAudioVisualServiceRequestFormListAsync(RAudioVisualServiceRequestForm sch);
        public Task<ApiResultsModel> GetReportAudioVisualServiceRequestFormAsync(int BookingId);
        #endregion

        #region V_MeetingRoomBookingHistory
        public Task<List<VMeetingRoomBookingHistory>> GetViewMeetingRoomBookingHistoryListAsync(VMeetingRoomBookingHistory sch);
        public Task<VMeetingRoomBookingHistory> GetViewMeetingRoomBookingHistoryAsync(int HistoryId);
        #endregion

        #region V_AudioVisualServiceRequestList
        public Task<List<VAudioVisualServiceRequestList>> GetViewAudioVisualServiceRequestListListAsync(VAudioVisualServiceRequestList sch);
        public Task<VAudioVisualServiceRequestList> GetViewAudioVisualServiceRequestListListAsync(int Id);
        #endregion

        #region V_AudioVisualServiceRequest
        public Task<List<VAudioVisualServiceRequest>> GetViewAudioVisualServiceRequestListAsync(VAudioVisualServiceRequest sch);
        public Task<ApiResultsModel> GetViewAudioVisualServiceRequestAsync(int AudioVisualServiceRequestId);
        #endregion

        #region V_VehicleQueue
        public Task<List<VVehicleQueue>> GetViewVehicleQueueListAsync(VVehicleQueue sch);
        public Task<VVehicleQueue> GetViewVehicleQueueAsync(int VehicleQueueId);
        #endregion

        #region V_VehicleBookingRecord
        public Task<ApiResultsModel> GetViewVehicleBookingRecordListAsync(VVehicleBookingRecord sch);
        public Task<ApiResultsModel> GetViewVehicleBookingRecordAsync(int VehicleBookingRecordId);
        public Task<ApiResultsModel> GetViewVehicleBookingRecordByBookingAsync(int VehicleBookingId);
        #endregion

        #region V_AssetChangeFormItem
        public Task<List<VAssetChangeFormItem>> GetViewAssetChangeFormItemListAsync(VAssetChangeFormItem sch);
        public Task<VAssetChangeFormItem> GetViewAssetChangeFormItemAsync(int Id);
        #endregion

        #region V_AssetChangeForm
        public Task<List<VAssetChangeForm>> GetViewAssetChangeFormListAsync(VAssetChangeForm sch);
        public Task<VAssetChangeForm> GetViewAssetChangeFormAsync(int Id);
        #endregion

        #region V_CateringRestaurantSnack
        public Task<List<VCateringRestaurantSnack>> GetViewCateringRestaurantSnackListAsync(VCateringRestaurantSnack sch);
        public Task<VCateringRestaurantSnack> GetViewCateringRestaurantSnackAsync(int Id);
        #endregion

        #region V_AudioVisualServiceRequestHistory
        public Task<ApiResultsModel> GetViewAudioVisualServiceRequestHistoryListAsync(VAudioVisualServiceRequestHistory sch);
        public Task<ApiResultsModel> GetViewAudioVisualServiceRequestHistoryAsync(int HistoryId);
        #endregion


        #region V_VideoConferenceBookingHistory
        public Task<ApiResultsModel> GetViewVideoConferenceBookingHistoryListAsync(VVideoConferenceBookingHistory sch);
        public Task<ApiResultsModel> GetViewVideoConferenceBookingHistoryAsync(int HistoryId);
        #endregion

        #region V_CateringServiceRequestHistory
        public Task<ApiResultsModel> GetViewCateringServiceRequestHistoryListAsync(VCateringServiceRequestHistory sch);
        public Task<ApiResultsModel> GetViewCateringServiceRequestHistoryAsync(int HistoryId);
        #endregion


        #region V_CateringServiceExpensesHistory
        public Task<ApiResultsModel> GetViewCateringServiceExpensesHistoryListAsync(VCateringServiceExpensesHistory sch);
        public Task<ApiResultsModel> GetViewCateringServiceExpensesHistoryAsync(int HistoryId);
        #endregion

        #region V_MeetingRoomBookingDetail
        public Task<ApiResultsModel> GetViewMeetingRoomBookingDetailListAsync(VMeetingRoomBookingDetail sch);
        public Task<ApiResultsModel> GetViewMeetingRoomBookingDetailAsync(int MeetingRoomBookingDetailId);
        #endregion

        #region V_AudioVisualServiceRequestDetail
        public Task<ApiResultsModel> GetViewAudioVisualServiceRequestDetailListAsync(VAudioVisualServiceRequestDetail sch);
        public Task<ApiResultsModel> GetViewAudioVisualServiceRequestDetailAsync(int AudioVisualServiceRequestDetailId);
        #endregion


        #region  DriverForAssign ==> V_Officer

        public Task<ApiResultsModel> GetDriverListForAssignAsync(SearchDriverListForAssign sch);
        #endregion

        #region  VehicleForAssign ==> V_Officer

        public Task<ApiResultsModel> GetVehicleListForAssignAsync(SearchVehicleListForAssign sch);

        #endregion


        #region  LicenseForVideoConferenceBooking ==> V_Officer
        public Task<ApiResultsModel> GetLicenseForVideoConferenceBookingAsync(SearchLicenseForVideoConferenceBooking sch);   
        #endregion


        #region V_CateringServiceRequest
        public Task<ApiResultsModel> GetViewCateringServiceRequestListAsync(VCateringServiceRequest sch);
        public Task<ApiResultsModel> GetViewCateringServiceRequestAsync(int CateringServiceRequestId);
        #endregion

        #region V_CateringServiceRequestSnackList
        public Task<ApiResultsModel> GetViewCateringServiceRequestSnackListListAsync(VCateringServiceRequestSnackList sch);

        #endregion


        #region V_CateringServiceRequestParticipant
        public Task<ApiResultsModel> GetViewCateringServiceRequestParticipantListAsync(VCateringServiceRequestParticipant sch);
        public Task<ApiResultsModel> GetViewCateringServiceRequestParticipantAsync(int Id);
        #endregion


        #region V_CateringServiceRequestDetail
        public Task<ApiResultsModel> GetViewCateringServiceRequestDetailListAsync(VCateringServiceRequestDetail sch);
        public Task<ApiResultsModel> GetViewCateringServiceRequestDetailAsync(int CateringServiceRequestDetailId);
        #endregion

        #region V_MasterReportDetail
        public Task<ApiResultsModel> GetViewMasterReportDetailListAsync(VMasterReportDetail sch);
        #endregion


        #region V_MasterFuelCode
        public Task<ApiResultsModel> GetViewMasterFuelCodeListAsync(VMasterFuelCode sch);
        public Task<ApiResultsModel> GetViewMasterFuelCodeAsync(int FuelCardId);
        #endregion

        #region V_VehicleBookingAssign 
        public Task<ApiResultsModel> GetViewVehicleBookingAssignListAsync(VVehicleBookingAssign sch);
        public Task<ApiResultsModel> GetViewVehicleBookingAssignAsync(int VehicleBookingAssign);
        #endregion


        #region V_CateringServiceExpense 
        public Task<ApiResultsModel> GetViewCateringServiceExpenseListAsync(VCateringServiceExpense sch);
        public  Task<ApiResultsModel> GetViewCateringServiceExpenseAsync(int CateringServiceExpensesId);
        #endregion


        #region V_BudgetRequest 
        public Task<ApiResultsModel> GetViewBudgetRequestListAsync(VBudgetRequest sch);
        public Task<ApiResultsModel> GetViewBudgetRequestAsync(int Id);
        #endregion


        #region V_MeetingRoomBookingAssetChangeItem 
        public Task<ApiResultsModel> GetViewMeetingRoomBookingAssetChangeItemListAsync(VMeetingRoomBookingAssetChangeItem sch);
        public Task<ApiResultsModel> GetViewMeetingRoomBookingAssetChangeItemAsync(int MeetingRoomBookingAssetChangeId);
        #endregion

        #region V_MeetingRoomFormat 
        public Task<ApiResultsModel> GetViewMeetingRoomFormatListAsync(VMeetingRoomFormat sch);
        public Task<ApiResultsModel> GetViewMeetingRoomFormatAsync(int MeetingRoomId);
        #endregion


        #region R_AudioVisualServiceRequestForm
        public Task<ApiResultsModel> GetReportCateringServiceRequestFormAsync(int BookingId);
        #endregion

        #region R_MeetingRoomBookingForm
        public Task<ApiResultsModel> GetReportMeetingRoomBookingFormAsync(int BookingId);
        #endregion

        #region R_CateringServiceExpensesForm
        public Task<ApiResultsModel> GetReportCateringServiceExpensesFormAsync(int BookingId);
        #endregion

        #region R_VehicleQueue
        public Task<ApiResultsModel> GetReportVehicleQueueListAsync(DateTime QueueDate);
        #endregion

        public Task<ApiResultsModel> GetSPVehicleForAssignListAsync(int VehicleBookingId);
        public Task<ApiResultsModel> GetSPDriverForAssignListAsync(int VehicleBookingId);

    }
    public class RawDataService : IRawDataService
    {
        private readonly SettingsModel _settings;
        private readonly ITokenService _tokenService;
        public RawDataService(IOptions<SettingsModel> options, ITokenService tokenService)
        {
            _settings = options.Value;
            _tokenService = tokenService;
        }

        #region V_VehicleTaxPaymentHistoryDetail
        public async Task<List<VVehicleTaxPaymentHistoryDetail>> GetViewVehicleTaxPaymentHistoryDetailListAsync(VVehicleTaxPaymentHistoryDetail sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VVehicleTaxPaymentHistoryDetail>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicleTaxPaymentHistoryDetailList";
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
                    results = JsonConvert.DeserializeObject<List<VVehicleTaxPaymentHistoryDetail>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VVehicleTaxPaymentHistoryDetail> GetViewVehicleTaxPaymentHistoryDetailAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VVehicleTaxPaymentHistoryDetail();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicleTaxPaymentHistoryDetail/{Id}";
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
                    results = JsonConvert.DeserializeObject<VVehicleTaxPaymentHistoryDetail>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_VehicleTaxPaymentHistory
        public async Task<List<VVehicleTaxPaymentHistory>> GetViewVehicleTaxPaymentHistoryListAsync(VVehicleTaxPaymentHistory sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VVehicleTaxPaymentHistory>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicleTaxPaymentHistoryList";
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
                    results = JsonConvert.DeserializeObject<List<VVehicleTaxPaymentHistory>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VVehicleTaxPaymentHistory> GetViewVehicleTaxPaymentHistoryAsync(int VehicleId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VVehicleTaxPaymentHistory();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicleTaxPaymentHistory/{VehicleId}";
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
                    results = JsonConvert.DeserializeObject<VVehicleTaxPaymentHistory>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_AudioVisualDevice
        public async Task<List<VAudioVisualDevice>> GetViewAudioVisualDeviceListAsync(VAudioVisualDevice sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VAudioVisualDevice>();
            try
            {
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewAudioVisualDeviceList";
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
                    results = JsonConvert.DeserializeObject<List<VAudioVisualDevice>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VAudioVisualDevice> GetViewAudioVisualDeviceAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VAudioVisualDevice();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewAudioVisualDevice/{Id}";
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
                    results = JsonConvert.DeserializeObject<VAudioVisualDevice>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_Vehicle
        public async Task<List<VVehicle>> GetViewVehicleListAsync(VVehicle sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VVehicle>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicleList";
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
                    results = JsonConvert.DeserializeObject<List<VVehicle>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VVehicle> GetViewVehicleAsync(int VehicleId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VVehicle();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicle/{VehicleId}";
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
                    results = JsonConvert.DeserializeObject<VVehicle>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_Officer
        public async Task<List<VOfficer>> GetViewOfficerListAsync(VOfficer sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VOfficer>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewOfficerList";
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
                    results = JsonConvert.DeserializeObject<List<VOfficer>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VOfficer> GetViewOfficerAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VOfficer();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewOfficer/{Id}";
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
                    results = JsonConvert.DeserializeObject<VOfficer>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<VOfficer> GetViewOfficerBySystemUserIdAsync(int SystemUserId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VOfficer();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewOfficerBySystemUserId/{SystemUserId}";
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
                    results = JsonConvert.DeserializeObject<VOfficer>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<List<VOfficer>> GetViewOfficerVehicleBookingDirectorListAsync()
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VOfficer>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewOfficerVehicleBookingDirectorList";
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                //var cotentData = JsonConvert.SerializeObject(sch);
                var request = new HttpRequestMessage();
                request.Method = HttpMethod.Get;
                // request.Content = new MediaTypeWithQualityHeaderValue("application/json");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", userCur?.UserToken);
                request.RequestUri = new Uri(url);

                var response = _httpClient.SendAsync(request).ConfigureAwait(false);
                var res = response.GetAwaiter().GetResult();
                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    results = JsonConvert.DeserializeObject<List<VOfficer>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_MeetingRoom
        public async Task<List<VMeetingRoom>> GetViewMeetingRoomListAsync(VMeetingRoom sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VMeetingRoom>();
            try
            {
                

                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewMeetingRoomList";
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


                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    results = JsonConvert.DeserializeObject<List<VMeetingRoom>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VMeetingRoom> GetViewMeetingRoomAsync(int RoomId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VMeetingRoom();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewMeetingRoom/{RoomId}";
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
                    results = JsonConvert.DeserializeObject<VMeetingRoom>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_VideoConferenceLicense
        public async Task<List<VVideoConferenceLicense>> GetViewVideoConferenceLicenseListAsync(VVideoConferenceLicense sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VVideoConferenceLicense>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVideoConferenceLicenseList";
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
                    results = JsonConvert.DeserializeObject<List<VVideoConferenceLicense>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VVideoConferenceLicense> GetViewVideoConferenceLicenseAsync(int LicenseId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VVideoConferenceLicense();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVideoConferenceLicense/{LicenseId}";
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
                    results = JsonConvert.DeserializeObject<VVideoConferenceLicense>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_VehicleBrandModel
        public async Task<List<VVehicleBrandModel>> GetViewVehicleBrandModelListAsync(VVehicleBrandModel sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VVehicleBrandModel>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicleBrandModelList";
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
                    results = JsonConvert.DeserializeObject<List<VVehicleBrandModel>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VVehicleBrandModel> GetViewVehicleBrandModelAsync(int BrandId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VVehicleBrandModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicleBrandModel/{BrandId}";
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
                    results = JsonConvert.DeserializeObject<VVehicleBrandModel>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_Restaurant
        public async Task<List<VRestaurant>> GetViewRestaurantListAsync(VRestaurant sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VRestaurant>();
            try
            {
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewRestaurantList";
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
                    results = JsonConvert.DeserializeObject<List<VRestaurant>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VRestaurant> GetViewRestaurantAsync(int RestaurantId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VRestaurant();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewRestaurant/{RestaurantId}";
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
                    results = JsonConvert.DeserializeObject<VRestaurant>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_VehicleMaintenanceHistory
        public async Task<List<VVehicleMaintenanceHistory>> GetViewVehicleMaintenanceHistoryListAsync(VVehicleMaintenanceHistory sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VVehicleMaintenanceHistory>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicleMaintenanceHistoryList";
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
                    results = JsonConvert.DeserializeObject<List<VVehicleMaintenanceHistory>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VVehicleMaintenanceHistory> GetViewVehicleMaintenanceHistoryAsync(int VehicleId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VVehicleMaintenanceHistory();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicleMaintenanceHistory/{VehicleId}";
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
                    results = JsonConvert.DeserializeObject<VVehicleMaintenanceHistory>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_VehicleMaintenanceHistoryDetail
        public async Task<List<VVehicleMaintenanceHistoryDetail>> GetViewVehicleMaintenanceHistoryDetailListAsync(VVehicleMaintenanceHistoryDetail sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VVehicleMaintenanceHistoryDetail>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicleMaintenanceHistoryDetailList";
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
                    results = JsonConvert.DeserializeObject<List<VVehicleMaintenanceHistoryDetail>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VVehicleMaintenanceHistoryDetail> GetViewVehicleMaintenanceHistoryDetailAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VVehicleMaintenanceHistoryDetail();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicleMaintenanceHistoryDetail/{Id}";
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
                    results = JsonConvert.DeserializeObject<VVehicleMaintenanceHistoryDetail>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_AudioVisualService
        public async Task<List<VAudioVisualService>> GetViewAudioVisualServiceListAsync(VAudioVisualService sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VAudioVisualService>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewAudioVisualServiceList";
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
                    results = JsonConvert.DeserializeObject<List<VAudioVisualService>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VAudioVisualService> GetViewAudioVisualServiceAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VAudioVisualService();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewAudioVisualService/{Id}";
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
                    results = JsonConvert.DeserializeObject<VAudioVisualService>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_MeetingRoomDevice
        public async Task<List<VMeetingRoomDevice>> GetViewMeetingRoomDeviceListAsync(VMeetingRoomDevice sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VMeetingRoomDevice>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewMeetingRoomDeviceList";
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
                    results = JsonConvert.DeserializeObject<List<VMeetingRoomDevice>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VMeetingRoomDevice> GetViewMeetingRoomDeviceAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VMeetingRoomDevice();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewMeetingRoomDevice/{Id}";
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
                    results = JsonConvert.DeserializeObject<VMeetingRoomDevice>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_SystemUserRoleAssign
        public async Task<List<VSystemUserRoleAssign>> GetViewSystemUserRoleAssignListAsync(VSystemUserRoleAssign sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VSystemUserRoleAssign>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewSystemUserRoleAssignList";
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
                    results = JsonConvert.DeserializeObject<List<VSystemUserRoleAssign>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VSystemUserRoleAssign> GetViewSystemUserRoleAssignAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VSystemUserRoleAssign();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewSystemUserRoleAssign/{Id}";
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
                    results = JsonConvert.DeserializeObject<VSystemUserRoleAssign>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region FN_BookingSystemMenu
        public async Task<List<SystemMenu>> GetFunctionSystemMenuListAsync(FunctionSystemMenu sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<SystemMenu>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetFunctionSystemMenuList";
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
                    results = JsonConvert.DeserializeObject<List<SystemMenu>>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_VehicleBooking
        public async Task<List<VVehicleDashboard>> GetViewVehicleBookingListAsync(VVehicleDashboard sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VVehicleDashboard>();
            try
            {
               
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicleHistory/{sch.VehicleId}";
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
                    results = JsonConvert.DeserializeObject<List<VVehicleDashboard>>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VVehicleBooking> GetViewVehicleBookingAsync(int BookingId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VVehicleBooking();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicleBooking/{BookingId}";
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
                    results = JsonConvert.DeserializeObject<VVehicleBooking>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion


        #region V_VehicleBookingHistory
        public async Task<List<VVehicleBookingHistory>> GetViewVehicleBookingHistoryListAsync(VVehicleBookingHistory sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VVehicleBookingHistory>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicleBookingHistoryList";
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
                    results = JsonConvert.DeserializeObject<List<VVehicleBookingHistory>>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VVehicleBookingHistory> GetViewVehicleBookingHistoryAsync(int HistoryId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VVehicleBookingHistory();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicleBookingHistory/{HistoryId}";
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
                    results = JsonConvert.DeserializeObject<VVehicleBookingHistory>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion


        #region V_MasterOrganization
        public async Task<List<VMasterOrganization>> GetViewMasterOrganizationListAsync(VMasterOrganization sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VMasterOrganization>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Master/GetListMasterOrganization";
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
                    results = JsonConvert.DeserializeObject<List<VMasterOrganization>>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VMasterOrganization> GetViewMasterOrganizationAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VMasterOrganization();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewMasterOrganization/{Id}";
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
                    results = JsonConvert.DeserializeObject<VMasterOrganization>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region R_VehicleBookingForm
        public async Task<List<RVehicleBookingForm>> GetReportVehicleBookingFormListAsync(RVehicleBookingForm sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<RVehicleBookingForm>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetReportVehicleBookingFormList";
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
                    results = JsonConvert.DeserializeObject<List<RVehicleBookingForm>>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<RVehicleBookingForm> GetReportVehicleBookingFormAsync(int BookingId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new RVehicleBookingForm();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetReportVehicleBookingForm/{BookingId}";
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
                    results = JsonConvert.DeserializeObject<RVehicleBookingForm>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }

        public async Task<RVehicleBookingForm> GetReportVehicleBookingFormByVehicleBookingAssignIdAsync(int VehicleBookingAssignId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new RVehicleBookingForm();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetReportVehicleBookingFormByVehicleBookingAssignId/{VehicleBookingAssignId}";
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
                    results = JsonConvert.DeserializeObject<RVehicleBookingForm>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_MasterFoodCategory
        public async Task<List<VMasterFoodCategory>> GetViewMasterFoodCategoryListAsync(VMasterFoodCategory sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VMasterFoodCategory>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewMasterFoodCategoryList";
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
                    results = JsonConvert.DeserializeObject<List<VMasterFoodCategory>>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VMasterFoodCategory> GetViewMasterFoodCategoryAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VMasterFoodCategory();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewMasterFoodCategory/{Id}";
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
                    results = JsonConvert.DeserializeObject<VMasterFoodCategory>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_MeetingRoomBooking
        public async Task<List<VMeetingRoomBooking>> GetViewMeetingRoomBookingListAsync(VMeetingRoomBooking sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VMeetingRoomBooking>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewMeetingRoomBookingList";
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
                    results = JsonConvert.DeserializeObject<List<VMeetingRoomBooking>>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VMeetingRoomBooking> GetViewMeetingRoomBookingAsync(int MeetingRoomBookingId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VMeetingRoomBooking();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewMeetingRoomBooking/{MeetingRoomBookingId}";
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
                    results = JsonConvert.DeserializeObject<VMeetingRoomBooking>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_AudioVisualServiceFormDisplay
        public async Task<List<VAudioVisualServiceFormDisplay>> GetViewAudioVisualServiceFormDisplayListAsync(VAudioVisualServiceFormDisplay sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VAudioVisualServiceFormDisplay>();
            try
            {
                ///var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewAudioVisualServiceFormDisplayList";
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
                    results = JsonConvert.DeserializeObject<List<VAudioVisualServiceFormDisplay>>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VAudioVisualServiceFormDisplay> GetViewAudioVisualServiceFormDisplayAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VAudioVisualServiceFormDisplay();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewAudioVisualServiceFormDisplay/{Id}";
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
                    results = JsonConvert.DeserializeObject<VAudioVisualServiceFormDisplay>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_VideoConferenceBooking
        public async Task<List<VVideoConferenceBooking>> GetViewVideoConferenceBookingListAsync(VVideoConferenceBooking sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VVideoConferenceBooking>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVideoConferenceBookingList";
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
                    results = JsonConvert.DeserializeObject<List<VVideoConferenceBooking>>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VVideoConferenceBooking> GetViewVideoConferenceBookingAsync(int VideoConferenceBookingId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VVideoConferenceBooking();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVideoConferenceBooking/{VideoConferenceBookingId}";
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
                    results = JsonConvert.DeserializeObject<VVideoConferenceBooking>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_CateringRestaurant
        public async Task<List<VCateringRestaurant>> GetViewCateringRestaurantListAsync(VCateringRestaurant sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VCateringRestaurant>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewCateringRestaurantList";
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
                    results = JsonConvert.DeserializeObject<List<VCateringRestaurant>>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VCateringRestaurant> GetViewCateringRestaurantAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VCateringRestaurant();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewCateringRestaurant/{Id}";
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
                    results = JsonConvert.DeserializeObject<VCateringRestaurant>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region R_AudioVisualServiceRequestForm
        public async Task<List<RAudioVisualServiceRequestForm>> GetReportAudioVisualServiceRequestFormListAsync(RAudioVisualServiceRequestForm sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<RAudioVisualServiceRequestForm>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetReportAudioVisualServiceRequestFormList";
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
                    results = JsonConvert.DeserializeObject<List<RAudioVisualServiceRequestForm>>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<ApiResultsModel> GetReportAudioVisualServiceRequestFormAsync(int BookingId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetReportAudioVisualServiceRequestForm/{BookingId}";
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
        #endregion

        #region V_MeetingRoomBookingHistory
        public async Task<List<VMeetingRoomBookingHistory>> GetViewMeetingRoomBookingHistoryListAsync(VMeetingRoomBookingHistory sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VMeetingRoomBookingHistory>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewMeetingRoomBookingHistoryList";
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
                    results = JsonConvert.DeserializeObject<List<VMeetingRoomBookingHistory>>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VMeetingRoomBookingHistory> GetViewMeetingRoomBookingHistoryAsync(int HistoryId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VMeetingRoomBookingHistory();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewMeetingRoomBookingHistory/{HistoryId}";
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
                    results = JsonConvert.DeserializeObject<VMeetingRoomBookingHistory>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_AudioVisualServiceRequestList
        public async Task<List<VAudioVisualServiceRequestList>> GetViewAudioVisualServiceRequestListListAsync(VAudioVisualServiceRequestList sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VAudioVisualServiceRequestList>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewAudioVisualServiceRequestListList";
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
                    results = JsonConvert.DeserializeObject<List<VAudioVisualServiceRequestList>>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VAudioVisualServiceRequestList> GetViewAudioVisualServiceRequestListListAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VAudioVisualServiceRequestList();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewAudioVisualServiceRequestList/{Id}";
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
                    results = JsonConvert.DeserializeObject<VAudioVisualServiceRequestList>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_AudioVisualServiceRequest
        public async Task<List<VAudioVisualServiceRequest>> GetViewAudioVisualServiceRequestListAsync(VAudioVisualServiceRequest sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VAudioVisualServiceRequest>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewAudioVisualServiceRequestList";
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
                    results = JsonConvert.DeserializeObject<List<VAudioVisualServiceRequest>>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<ApiResultsModel> GetViewAudioVisualServiceRequestAsync(int AudioVisualServiceRequestId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewAudioVisualServiceRequest/{AudioVisualServiceRequestId}";
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
        #endregion

        #region V_VehicleQueue
        public async Task<List<VVehicleQueue>> GetViewVehicleQueueListAsync(VVehicleQueue sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VVehicleQueue>();
            try
            {
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicleQueueList";
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
                    results = JsonConvert.DeserializeObject<List<VVehicleQueue>>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VVehicleQueue> GetViewVehicleQueueAsync(int VehicleQueueId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VVehicleQueue();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicleQueue/{VehicleQueueId}";
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
                    results = JsonConvert.DeserializeObject<VVehicleQueue>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion


        #region V_VehicleBookingRecord
        public async Task<ApiResultsModel> GetViewVehicleBookingRecordListAsync(VVehicleBookingRecord sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicleBookingRecordList";
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
        public async Task<ApiResultsModel> GetViewVehicleBookingRecordAsync(int VehicleBookingRecordId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicleBookingRecord/{VehicleBookingRecordId}";
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

        public async Task<ApiResultsModel> GetViewVehicleBookingRecordByBookingAsync(int VehicleBookingId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicleBookingRecordByBooking/{VehicleBookingId}";
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
        #endregion


        #region V_AssetChangeFormItem
        public async Task<List<VAssetChangeFormItem>> GetViewAssetChangeFormItemListAsync(VAssetChangeFormItem sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VAssetChangeFormItem>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewAssetChangeFormItemList";
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
                    results = JsonConvert.DeserializeObject<List<VAssetChangeFormItem>>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VAssetChangeFormItem> GetViewAssetChangeFormItemAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VAssetChangeFormItem();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewAssetChangeFormItem/{Id}";
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
                    results = JsonConvert.DeserializeObject<VAssetChangeFormItem>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_AssetChangeForm
        public async Task<List<VAssetChangeForm>> GetViewAssetChangeFormListAsync(VAssetChangeForm sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VAssetChangeForm>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewAssetChangeFormList";
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
                    results = JsonConvert.DeserializeObject<List<VAssetChangeForm>>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VAssetChangeForm> GetViewAssetChangeFormAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VAssetChangeForm();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewAssetChangeForm/{Id}";
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
                    results = JsonConvert.DeserializeObject<VAssetChangeForm>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion


        #region V_CateringRestaurantSnack
        public async Task<List<VCateringRestaurantSnack>> GetViewCateringRestaurantSnackListAsync(VCateringRestaurantSnack sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new List<VCateringRestaurantSnack>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewCateringRestaurantSnackList";
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
                    results = JsonConvert.DeserializeObject<List<VCateringRestaurantSnack>>(json);
                }

            }
            catch (Exception ex)
            {

            }
            return results;
        }
        public async Task<VCateringRestaurantSnack> GetViewCateringRestaurantSnackAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new VCateringRestaurantSnack();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewCateringRestaurantSnack/{Id}";
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
                    results = JsonConvert.DeserializeObject<VCateringRestaurantSnack>(json);
                }
            }
            catch (Exception ex)
            {

            }
            return results;
        }
        #endregion

        #region V_AudioVisualServiceRequestHistory
        public async Task<ApiResultsModel> GetViewAudioVisualServiceRequestHistoryListAsync(VAudioVisualServiceRequestHistory sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewAudioVisualServiceRequestHistoryList";
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
        public async Task<ApiResultsModel> GetViewAudioVisualServiceRequestHistoryAsync(int HistoryId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewAudioVisualServiceRequestHistory/{HistoryId}";
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
        #endregion

        #region V_VideoConferenceBookingHistory
        public async Task<ApiResultsModel> GetViewVideoConferenceBookingHistoryListAsync(VVideoConferenceBookingHistory sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVideoConferenceBookingHistoryList";
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
        public async Task<ApiResultsModel> GetViewVideoConferenceBookingHistoryAsync(int HistoryId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVideoConferenceBookingHistory/{HistoryId}";
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
        #endregion

        #region V_CateringServiceRequestHistory
        public async Task<ApiResultsModel> GetViewCateringServiceRequestHistoryListAsync(VCateringServiceRequestHistory sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewCateringServiceRequestHistoryList";
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
        public async Task<ApiResultsModel> GetViewCateringServiceRequestHistoryAsync(int HistoryId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewCateringServiceRequestHistory/{HistoryId}";
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
        #endregion

        #region V_CateringServiceExpensesHistory
        public async Task<ApiResultsModel> GetViewCateringServiceExpensesHistoryListAsync(VCateringServiceExpensesHistory sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewCateringServiceExpensesHistoryList";
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
        public async Task<ApiResultsModel> GetViewCateringServiceExpensesHistoryAsync(int HistoryId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewCateringServiceExpensesHistory/{HistoryId}";
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
        #endregion

        #region V_MeetingRoomBookingDetail
        public async Task<ApiResultsModel> GetViewMeetingRoomBookingDetailListAsync(VMeetingRoomBookingDetail sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewMeetingRoomBookingDetailList";
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
        public async Task<ApiResultsModel> GetViewMeetingRoomBookingDetailAsync(int MeetingRoomBookingDetailId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewMeetingRoomBookingDetail/{MeetingRoomBookingDetailId}";
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
        #endregion

        #region V_AudioVisualServiceRequestDetail
        public async Task<ApiResultsModel> GetViewAudioVisualServiceRequestDetailListAsync(VAudioVisualServiceRequestDetail sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewAudioVisualServiceRequestDetailList";
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
        public async Task<ApiResultsModel> GetViewAudioVisualServiceRequestDetailAsync(int AudioVisualServiceRequestDetailId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewAudioVisualServiceRequestDetail/{AudioVisualServiceRequestDetailId}";
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
        #endregion




        #region V_CateringServiceRequest
        public async Task<ApiResultsModel> GetViewCateringServiceRequestListAsync(VCateringServiceRequest sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewCateringServiceRequestList";
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
        public async Task<ApiResultsModel> GetViewCateringServiceRequestAsync(int CateringServiceRequestId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewCateringServiceRequest/{CateringServiceRequestId}";
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
        #endregion


        #region V_CateringServiceRequestSnackList
        public async Task<ApiResultsModel> GetViewCateringServiceRequestSnackListListAsync(VCateringServiceRequestSnackList sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewCateringServiceRequestSnackListList";
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


        #region V_CateringServiceRequestParticipant
        public async Task<ApiResultsModel> GetViewCateringServiceRequestParticipantListAsync(VCateringServiceRequestParticipant sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewCateringServiceRequestParticipantList";
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
        public async Task<ApiResultsModel> GetViewCateringServiceRequestParticipantAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewCateringServiceRequestParticipant/{Id}";
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
        #endregion


        #region V_CateringServiceRequestDetail
        public async Task<ApiResultsModel> GetViewCateringServiceRequestDetailListAsync(VCateringServiceRequestDetail sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewCateringServiceRequestDetailList";
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
        public async Task<ApiResultsModel> GetViewCateringServiceRequestDetailAsync(int CateringServiceRequestDetailId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewCateringServiceRequestDetail/{CateringServiceRequestDetailId}";
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
        #endregion

        #region V_MasterReportDetail
        public async Task<ApiResultsModel> GetViewMasterReportDetailListAsync(VMasterReportDetail sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewMasterReportDetailList";
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


        #region V_MasterFuelCode
        public async Task<ApiResultsModel> GetViewMasterFuelCodeListAsync(VMasterFuelCode sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewMasterFuelCodeList";
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
        public async Task<ApiResultsModel> GetViewMasterFuelCodeAsync(int FuelCardId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewMasterFuelCode/{FuelCardId}";
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
        #endregion

        #region V_VehicleBookingAssign 
        public async Task<ApiResultsModel> GetViewVehicleBookingAssignListAsync(VVehicleBookingAssign sch)
        {
            var results = new ApiResultsModel();
            try
            {
                var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

                // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicleBookingAssignList";
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
        public async Task<ApiResultsModel> GetViewVehicleBookingAssignAsync(int VehicleBookingAssignId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewVehicleBookingAssign/{VehicleBookingAssignId}";
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
        #endregion

        #region V_CateringServiceExpense 
        public async Task<ApiResultsModel> GetViewCateringServiceExpenseListAsync(VCateringServiceExpense sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewCateringServiceExpenseList";
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
        public async Task<ApiResultsModel> GetViewCateringServiceExpenseAsync(int CateringServiceExpensesId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
               // var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewCateringServiceExpense/{CateringServiceExpensesId}";
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
        #endregion


        #region V_BudgetRequest 
        public async Task<ApiResultsModel> GetViewBudgetRequestListAsync(VBudgetRequest sch)
        {

            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewBudgetRequestList";
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
        public async Task<ApiResultsModel> GetViewBudgetRequestAsync(int Id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewBudgetRequest/{Id}";
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
        #endregion

        #region V_MeetingRoomBookingAssetChangeItem 
        public async Task<ApiResultsModel> GetViewMeetingRoomBookingAssetChangeItemListAsync(VMeetingRoomBookingAssetChangeItem sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewMeetingRoomBookingAssetChangeItemList";
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
        public async Task<ApiResultsModel> GetViewMeetingRoomBookingAssetChangeItemAsync(int MeetingRoomBookingAssetChangeId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewMeetingRoomBookingAssetChangeItem/{MeetingRoomBookingAssetChangeId}";
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
        #endregion

        #region V_MeetingRoomFormat 
        public async Task<ApiResultsModel> GetViewMeetingRoomFormatListAsync(VMeetingRoomFormat sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewMeetingRoomFormatList";
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
        public async Task<ApiResultsModel> GetViewMeetingRoomFormatAsync(int MeetingRoomId)
        {

            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetViewMeetingRoomFormat/{MeetingRoomId}";
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
        #endregion


        #region  VehicleForAssign ==> V_Officer

        public async Task<ApiResultsModel> GetDriverListForAssignAsync(SearchDriverListForAssign sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
               

                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetDriverListForAssign";
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
                    //results = JsonConvert.DeserializeObject<List<VOfficer>>(json);


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


        #region  VehicleForAssign ==> V_Officer

        public async Task<ApiResultsModel> GetVehicleListForAssignAsync(SearchVehicleListForAssign sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {


                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetVehicleListForAssign";
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
                    //results = JsonConvert.DeserializeObject<List<VOfficer>>(json);


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



        #region  LicenseForVideoConferenceBooking ==> V_Officer

        public async Task<ApiResultsModel> GetLicenseForVideoConferenceBookingAsync(SearchLicenseForVideoConferenceBooking sch)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {


                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetLicenseForVideoConferenceBooking";
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
                    //results = JsonConvert.DeserializeObject<List<VOfficer>>(json);


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


        #region R_AudioVisualServiceRequestForm

        public async Task<ApiResultsModel> GetReportCateringServiceRequestFormAsync(int BookingId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetReportCateringServiceRequestForm/{BookingId}";
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
        #endregion

        #region R_MeetingRoomBookingForm

        public async Task<ApiResultsModel> GetReportMeetingRoomBookingFormAsync(int BookingId)
        {

            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetReportMeetingRoomBookingForm/{BookingId}";
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
        #endregion

        #region R_CateringServiceExpensesForm

        public async Task<ApiResultsModel> GetReportCateringServiceExpensesFormAsync(int BookingId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetReportCateringServiceExpensesForm/{BookingId}";
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
        #endregion

        #region R_VehicleQueue
        public async Task<ApiResultsModel> GetReportVehicleQueueListAsync(DateTime QueueDate)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
             

                var sch = new RVehicleQueue();
                sch.QueueDate = QueueDate;

                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetReportVehicleQueueList";
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


        #region SP_VehicleForAssign
        public async Task<ApiResultsModel> GetSPVehicleForAssignListAsync(int VehicleBookingId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetSPVehicleForAssignList/{VehicleBookingId}";
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
        #endregion

        #region SP_DriverForAssign
        public async Task<ApiResultsModel> GetSPDriverForAssignListAsync(int VehicleBookingId)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            var results = new ApiResultsModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/RawData/GetSPDriverForAssignList/{VehicleBookingId}";
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
        #endregion








    }
}
