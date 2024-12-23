using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using MOEN_ERP.Models.ViewModel.VehicleBooking;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using MOEN_ERP.DAL.Models;

namespace MOEN_ERP.Models.ViewModel.MeetingRoomBooking
{

    public class SearchMeetingRoomBooking
    {
        public string? BookingCode { get; set; }
        public int? MeetingRoomId { get; set; }
        public string? Topic { get; set; }
        public int? LastStatusId { get; set; }
        public DateTime? BookingDateFrom { get; set; }
        public DateTime? BookingDateTo { get; set; }
        public DateTime? UseDateFromFrom { get; set; }
        public DateTime? UseDateFromTo { get; set; }
        public int? SystemUserId { get; set; }
        public int? SystemUserRoleId { get; set; }


    }


    public class MeetingRoomBookingFormEvent
    {
        public int? MeetingRoomBookingId { get; set; }
        public int? AudioVisualServiceRequestId { get; set; }
        public int? VideoConferenceBookingId { get; set; }
        public int? CateringServiceRequestId { get; set; }
        public int? CateringServiceExpensesId { get; set; }
        public int? MeetingRoomBookingStatusId { get; set; }
        public string? ActionType { get; set; }
        public string? ActionRemark { get; set; }
        public int? CurrentSystemUserId { get; set; }
        public int? CurrentOfficerId { get; set; }

    }


    public class MeetingRoomBookingViewModel
    {
        public List<VMeetingRoomBooking> VMeetingRoomBookingList { get; set; }
    }


    public class MeetingRoomBookingForm
    {

        /// <summary>
        /// รหัสเลขที่จอง
        /// </summary>
        public int? MeetingRoomBookingId { get; set; }

        /// <summary>
        /// เลขที่จอง
        /// </summary>
        public string? BookingCode { get; set; }
        /// <summary>
        /// สถานะล่าสุด
        /// </summary>
        /// 
        public int? LastStatusId { get; set; }
        public string? LastWorkProcessActorType { get; set; }
        public int? NextActorUserId { get; set; }
        public int? LastWorkProcessRoleId { get; set; }


        /// <summary>
        /// เลือกวันที่หน้า Timeline
        /// </summary>
        public DateTime? TabTime_SelectUseDateFrom { get; set; }
        /// <summary>
        /// เลือกวันที่หน้า Timeline To
        /// </summary>
        public DateTime? TabTime_SelectUseDateFromTo { get; set; }

        /// <summary>
        /// รหัสห้องประชุม
        /// </summary>
        public int? TabTime_MeetingRoomId { get; set; }
        /// <summary>
        /// วันที่จอง จากวันที่
        /// </summary>
        public DateTime? TabTime_UseDateFrom { get; set; }
        /// <summary>
        /// วันที่จอง ถึงวันที่
        /// </summary>
        public DateTime? TabTime_UseDateTo { get; set; }
        /// <summary>
        /// เวลาที่จอง จากวันที่
        /// </summary>
        public DateTime? TabTime_UseDateFromTime { get; set; }
        /// <summary>
        /// เวลาที่จอง ถึงวันที่
        /// </summary>
        public DateTime? TabTime_UseDateToTime { get; set; }

        public bool? TabDetail_IsDailyBooking { get; set; }
        public int? TabDetail_BookerId { get; set; }
        public string? TabDetail_BookerName { get; set; }
        public int? TabDetail_BookerPosId { get; set; }
        public string? TabDetail_BookerPosName { get; set; }
        public int? TabDetail_BookerOrgId { get; set; }
        public string? TabDetail_BookerOrgName { get; set; }
        public DateTime? TabDetail_BookingDate { get; set; }
        public DateTime? TabDetail_UseDateFrom { get; set; }
        public DateTime? TabDetail_UseDateTo { get; set; }
        public DateTime? TabDetail_UseDateFromTime { get; set; }
        public DateTime? TabDetail_UseDateToTime { get; set; }
        public int? TabDetail_ParticipantsPerRoom { get; set; }
        public int? TabDetail_Participants { get; set; }
        public int? TabDetail_BookingTypeId { get; set; }
        public string? TabDetail_BookingTypeName { get; set; }
        public string? TabDetail_Topic { get; set; }
        public int? TabDetail_RealUserId { get; set; }
        public string? TabDetail_RealUserName { get; set; }
        public string? TabDetail_BookerPhone { get; set; }
        public string? TabDetail_Remark { get; set; }
        public int? TabDetail_DivisionId { get; set; }
        public string? TabDetail_DivisionName { get; set; }
        /// <summary>
        /// ชื่อห้องประชุม
        /// </summary>
        public string? TabDetail_MeetingRoomName { get; set; }
        public string? TabDetail_Floor { get; set; }
        public string? TabDetail_Location { get; set; }
        public string? TabDetail_RoomNumber { get; set; }



        /// <summary>
        /// ประธานบุคคลภายใน
        /// </summary>
        public List<int>? TabParticipant_ListOfficerPosition1 { get; set; }
        /// <summary>
        /// ชื่อประธานบุคคลภายนอก
        /// </summary>
        public string? TabParticipant_ParticipantName { get; set; }
        /// <summary>
        /// เลขานุการ
        /// </summary>
        public List<int>? TabParticipant_ListOfficerPosition3 { get; set; }
        /// <summary>
        /// ผู้เข้าร่วมประชุมภายใน
        /// </summary>
        public List<int>? TabParticipant_ListOfficerPosition4 { get; set; }

        public string[]? TabParticipant_FileGuidId { get; set; }


        public List<VMeetingRoomBookingParticipant>? TabParticipant_BookingParticipantList { get; set; }

        public DateTime? TabParticipant_LastSendMail { get; set; }

        /// <summary>
        /// List ห้องประชุม
        /// </summary>
        public List<VMeetingRoomBooking>? VMeetingRoomBookingList { get; set; }

        public MeetingRoomBookingLayout? TabLayout_MeetingRoomFormatList { get; set; }
        //--Layout End.   

        public bool? TabLayout_IsFormatChange { get; set; }
        public int? TabLayout_RoomFormatId { get; set; }
        public string? TabLayout_RoomFormatRemark { get; set; }



        public int? TabAudiovisual_AudioVisualServiceRequestId { get; set; }
        public string? TabAudiovisual_BookingCode { get; set; }
        public bool? TabAudiovisual_IsAudioVisualServiceRequest { get; set; }
        public bool? TabAudiovisual_IsMonitorRequest { get; set; }
        public bool? TabAudiovisual_IsSpeakerRequest { get; set; }
        public bool? TabAudiovisual_IsMicrophoneRequest { get; set; }
        public bool? TabAudiovisual_IsConferenceCamRequest { get; set; }
        public List<int>? TabAudiovisual_AudioVisualServiceRequestList { get; set; }
        public bool? TabAudiovisual_IsOtherWork { get; set; }
        public string? TabAudiovisual_WorkDetail { get; set; }
        public DateTime? TabAudiovisual_SetupTime { get; set; }
        public string[]? TabAudiovisual_FileGuidId { get; set; }
        public int? TabAudiovisual_DirectorApproveId1 { get; set; }
        public int? TabAudiovisual_DirectorApproveId2 { get; set; }
        public int? TabAudiovisual_AudioVisualServiceRequestLastStatusId { get; set; }
        public string? TabAudiovisual_AudioVisualServiceRequestLastStatusName { get; set; }
        public string? TabAudiovisual_ActionRemark { get; set; }


        public int? TabAudiovisual_VideoConferenceBoookingLastStatusId { get; set; }
        public int? TabAudiovisual_VideoConferenceBoookingId { get; set; }


        public int? TabCatering_CateringServiceRequestId { get; set; }
        public bool? TabCatering_IsCateringServiceRequest { get; set; }
        public int? TabCatering_CateringServiceRequestLastStatusId { get; set; }
        public string? TabCatering_CateringServiceRequestLastStatusName { get; set; }
        public string? TabCatering_ActionRemark { get; set; }
        public string? TabCatering_BookingCode { get; set; }
        public List<int>? TabCatering_CateringServiceParticipantTypeList { get; set; }

        public bool? TabCatering_IsSnackRequest { get; set; }
        public bool? TabCatering_IsSnackMorning { get; set; }
        public bool? TabCatering_IsSnackAfternoon { get; set; }
        public DateTime? TabCatering_SnackServeInsideTime { get; set; }
        public DateTime? TabCatering_SnackServeOutsideTime { get; set; }
        public string? TabCatering_SnackDetail { get; set; }

        public DateTime? TabCatering_SnackAfternoonServiceInsideTime { get; set; }
        public DateTime? TabCatering_SnackAfternoonServiceOutsideTime { get; set; }
        public List<VCateringServiceRequestSnackList>? TabCatering_CateringServiceRequestSnackList { get; set; }

        public bool? TabCatering_IsLunchRequest { get; set; }
     
        public int? TabCatering_LunchNumber { get; set; }
        public int? TabCatering_LunchFoodCategoryId { get; set; }
        public int? TabCatering_LunchRestaurantId { get; set; }
        public DateTime? TabCatering_LunchServeTime { get; set; }

        public string? TabCatering_LunchDetail { get; set; }

        public MeetingRoomBookingCateringServiceRequestLunch? TabCatering_CateringServiceRequestLunch { get; set; }
        public bool? TabCatering_IsDinnerRequest { get; set; }
        public int? TabCatering_DinnerNumber { get; set; }
        public int? TabCatering_DinnerFoodCategoryId { get; set; }
        public int? TabCatering_DinnerRestaurantId { get; set; }
        public DateTime? TabCatering_DinnerServeTime { get; set; }

        public string? TabCatering_DinnerDetail { get; set; }
        public MeetingRoomBookingCateringServiceRequestDinner? TabCatering_CateringServiceRequestDinner { get; set; }
        //public bool? TabCatering_IsServeInside { get; set; }
        //public string? TabCatering_ServeInsideDetail { get; set; }
        //public bool? TabCatering_IsServeOutside { get; set; }
        public string? TabCatering_ServeOutsideDetail { get; set; }
        public bool? TabCatering_IsVegetarianFood { get; set; }
        public int? TabCatering_VegetarianFoodNumber { get; set; }
        public bool? TabCatering_IsHalalFood { get; set; }
        public int? TabCatering_HalalFoodNumber { get; set; }

        public int? TabCatering_DirectorApproveId1 { get; set; }
        public int? TabCatering_DirectorApproveId2 { get; set; }

        /// <summary>
        /// เบิกค่าใช้จ่าย
        /// </summary>
        public bool? TabCatering_IsExpensesRequest { get; set; }
        public int? TabCatering_CateringServiceExpensesId { get; set; }
        public int? TabCatering_CateringServiceExpensesLastStatus { get; set; }

        public string? RequestEditActionRemark { get; set; }
        public string? CurrentTab { get; set; }
        public string? SubmitType { get; set; }
        /// <summary>
        /// รหัส SystemUserId
        /// </summary>
        public int? CurrentSystemUserId { get; set; }

        public int? CurrentOfficerId { get; set; }
    }


    public class EventPreviewMeetingRoomBookingPreviewForm
    {
        //public VMeetingRoomBooking? MeetingRoomBooking { get; set; }
        public int? MeetingRoomBookingId { get; set; }
        public string? SubmitType { get; set; }
        public string? CurrentTab { get; set; }

    }

    public class MeetingRoomBookingFormTest
    {
        public int? MeetingRoomBookingId { get; set; }
        public string? MeetingRoomBookingCode { get; set; }
        public int? MeetingRoomBookingMeetingRoomId { get; set; }
        public string? MeetingRoomBookingMeetingRoomName { get; set; }
        public string? MeetingRoomBookingFloor { get; set; }
        public string? MeetingRoomBookingLocation { get; set; }
        public string? MeetingRoomBookingRoomNumber { get; set; }
        public DateTime? MeetingRoomBookingDate { get; set; }
        public DateTime? MeetingRoomBookingUseDateFrom { get; set; }
        public DateTime? MeetingRoomBookingUseDateTo { get; set; }
        public DateTime? MeetingRoomBookingUseDateFromTime { get; set; }
        public DateTime? MeetingRoomBookingUseDateToTime { get; set; }
        
        public bool? MeetingRoomBookingIsDailyBooking { get; set; }
        public int? MeetingRoomBookingParticipants { get; set; }
        public int? MeetingRoomBookingParticipantsPerRoom { get; set; }

        public int? MeetingRoomBookingTypeId { get; set; }
        public string? MeetingRoomBookingTypeName { get; set; }
        public string? MeetingRoomBookingTopic { get; set; }
        public int? MeetingRoomBookingRealUserId { get; set; }
        public string? MeetingRoomBookingRealUserName { get; set; }
        public string? MeetingRoomBookingBookerPhone { get; set; }
        public string? MeetingRoomBookingRemark { get; set; }

        public int? MeetingRoomBookingLastStatusId { get; set; }

      
        public string? MeetingRoomBookingLastWorkProcessActorType { get; set; }
        public int? MeetingRoomBookingNextActorUserId { get; set; }
        public int? MeetingRoomBookingLastWorkProcessRoleId { get; set; }
        public int? MeetingRoomBookingDivisionId { get; set; }
        public string? MeetingRoomBookingDivisionName { get; set; }
        public string? MeetingRoomBookingBookerName { get; set; }
        public string? MeetingRoomBookingBookerPosName { get; set; }
        public string? MeetingRoomBookingBookerOrgName { get; set; }

        public DateTime? SelectUseDateFrom { get; set; }
        public DateTime? SelectUseDateFromTo { get; set; }
        public string? CurrentTab { get; set; }
    }

    public class MeetingRoomBookingLayout
    {
        public PaginationModel? PaginationResultModel { get; set; }
        public List<VMeetingRoomFormat>? MasterMeetingRoomFormat { get; set; }
        public List<AttachFile>? AttachFileList { get; set; }
        public int? SelectMeetingRoomFormat { get; set; }
        public string? ActionType { get; set; }
    }


    public class MeetingRoomBookingCateringService
    {
        public List<VCateringServiceRequestSnackList>? CateringServiceRequestSnackList { get; set; }
        public List<VCateringRestaurantSnack>? CateringRestaurantList { get; set; }

        //public List<VCateringServiceRequestSnackList>? NewCateringServiceRequestSnackList { get; set; }
        public List<int>? NewSelectRestaurantIdList { get; set; }
        //public List<int>? NewSelectFoodCategoryIdList { get; set; }

    }


    public class MeetingRoomBookingCateringServiceRequestLunch
    {
        public List<VCateringRestaurant>? CateringServiceRequestLunchList { get; set; }
        public int? SelectLunchRestaurantId { get; set; }
        public int? SelectLunchFoodCategoryId { get; set; }
        //public List<AttachFile>? AttachFileList { get; set; }
    }

  
    public class MeetingRoomBookingCateringServiceRequestDinner
    {
        public List<VCateringRestaurant>? CateringServiceRequestDinnerList { get; set; }
        public int? SelectDinnerRestaurantId { get; set; }
        public int? SelectDinnerFoodCategoryId { get; set; }
        //public List<AttachFile>? AttachFileList { get; set; }
    }


    public class MeetingRoomBookingVideoConferenceBookingForm
    {
        public int? VideoConferenceBookingId { get; set; }
        public int? MeetingRoomBookingId { get; set; }
        public int? AudioVisualServiceRequestId { get; set; }
        public string? BookingCode { get; set; }
        public DateTime? BookingDate { get; set; }
        public int? BookerId { get; set; }
        public string? BookerName { get; set; }
        public string? BookerEmail { get; set; }
        public DateTime? UseDateFrom { get; set; }
        public DateTime? UseDateTo { get; set; }
        public DateTime? UseDateFromTime { get; set; }
        public DateTime? UseDateToTime { get; set; }
        public int? ConferenceId { get; set; }
        public int? LicenseId { get; set; }
        public bool? IsHost { get; set; }
        public int? Participants { get; set; }
        public int? BookingPriorityId { get; set; }
        public string? Remark { get; set; }
        public int? DivisionId { get; set; }
        public bool? IsFinish { get; set; }
        public int? LastStatusId { get; set; }
        public string? LastStatusName { get; set; }

        public int? CurrentSystemUserId { get; set; }
        public int? CurrentOfficerId { get; set; }
    }


    public class MeetingRoomBookingVideoConferenceBookingFormEvent
    {
        public int? VideoConferenceBookingId { get; set; }
        public int? MeetingRoomBookingId { get; set; }
        public string? ActionRemark { get; set; }
        public int? CurrentSystemUserId { get; set; }
        public int? CurrentOfficerId { get; set; }

    }

    /// <summary>
    /// เบิกค่าจัดเลี้ยง
    /// </summary>
    public class MeetingRoomBookingCateringServiceExpensesForm
    {
        //public int? CateringServiceExpensesId { get; set; }
        ///// <summary>
        ///// รหัสจองห้องประชุม
        ///// </summary>
        //public int? MeetingRoomBookingId { get; set; }
        ///// <summary>
        ///// รหัสขอใช้บริการจัดเลี้ยง
        ///// </summary>
        //public int? CateringServiceRequestId { get; set; }
        ///// <summary>
        ///// วันที่ยื่น
        ///// </summary>
        //public DateTime? BookingDate { get; set; }
        ///// <summary>
        ///// รหัสผู้ยื่นคำขอ
        ///// </summary>
        //public int? BookerId { get; set; }
        ///// <summary>
        ///// ชื่อผู้ยื่นคำขอ
        ///// </summary>
        //public string? BookerName { get; set; }
        ///// <summary>
        ///// เลขที่คำขอ
        ///// </summary>
        //public string? BookingCode { get; set; }
        ///// <summary>
        ///// ค่าอาหารว่าง
        ///// </summary>
        //public decimal? SnackCost { get; set; }
        ///// <summary>
        ///// จำนวนคน
        ///// </summary>
        //public int? SnackNumber { get; set; }
        ///// <summary>
        ///// รวมเป็นเงิน
        ///// </summary>
        //public decimal? SnackCostAmount { get; set; }
        ///// <summary>
        ///// ค่าอาหาร
        ///// </summary>
        //public decimal? MealCost { get; set; }
        ///// <summary>
        ///// จำนวนคน
        ///// </summary>
        //public int? MealNumber { get; set; }
        ///// <summary>
        ///// รวมเป็นเงิน
        ///// </summary>
        //public decimal? MealCostAmount { get; set; }
        ///// <summary>
        ///// รวมเบิกทั้งสิ้น
        ///// </summary>
        //public decimal? ExpensesCostAmount { get; set; }
        ///// <summary>
        ///// ดำเนินการในระบบ
        ///// </summary>
        //public int? SystemOperationType { get; set; }



        public int? CateringServiceExpensesId { get; set; }
        /// <summary>
        /// รหัสจองห้องประชุม
        /// </summary>
        public int? MeetingRoomBookingId { get; set; }
        /// <summary>
        /// รหัสขอใช้บริการจัดเลี้ยง
        /// </summary>
        public int? CateringServiceRequestId { get; set; }
        /// <summary>
        /// วันที่ยื่น
        /// </summary>
        public DateTime? BookingDate { get; set; }
        /// <summary>
        /// รหัสผู้ยื่นคำขอ
        /// </summary>
        public int? BookerId { get; set; }
        /// <summary>
        /// ชื่อผู้ยื่นคำขอ
        /// </summary>
        public string? BookerName { get; set; }
        /// <summary>
        /// เลขที่คำขอ
        /// </summary>
        public string? BookingCode { get; set; }
        /// <summary>
        /// ค่าอาหารว่าง
        /// </summary>
        public decimal? SnackCost { get; set; }
        /// <summary>
        /// จำนวนคน
        /// </summary>
        public int? SnackNumber { get; set; }
        /// <summary>
        /// รวมเป็นเงิน
        /// </summary>
        public decimal? SnackCostAmount { get; set; }
        ///// <summary>
        ///// ค่าอาหาร
        ///// </summary>
        //public decimal? MealCost { get; set; }
        ///// <summary>
        ///// จำนวนคน
        ///// </summary>
        //public int? MealNumber { get; set; }
        ///// <summary>
        ///// รวมเป็นเงิน
        ///// </summary>
        //public decimal? MealCostAmount { get; set; }
        /// <summary>
        /// รวมเบิกทั้งสิ้น
        /// </summary>
        public decimal? ExpensesCostAmount { get; set; }
        /// <summary>
        /// ดำเนินการในระบบ
        /// </summary>
        public int? SystemOperationType { get; set; }

        



        public string? LastStatusName { get; set; }
        public int? BudgetRequestId { get; set; }
        public string? BudgetRequestName { get; set; }
        public string? RequestDetail { get; set; }
        public string? RequestPurpose { get; set; }
        public int? SnackRepast { get; set; }
        public decimal? LunchCost { get; set; }
        public int? LunchNumber { get; set; }
        public decimal? LunchCostAmount { get; set; }
        public decimal? DinnerCost { get; set; }

        public int? DinnerNumber { get; set; }

        public decimal? DinnerCostAmount { get; set; }

        public bool? IsCabinetResolution { get; set; }
        public string? SnackRemark { get; set; }

        public bool? IsLunchCabinetResolution { get; set; }
        public string? LunchRemark { get; set; }

        public bool? IsDinnerCabinetResolution { get; set; }
        public string? DinnerRemark { get; set; }


        public bool? IsRequestByCateringService { get; set; }


        public int? LastStatusId { get; set; }

        public string? ActionType { get; set; }
        public int? CurrentSystemUserId { get; set; }
        public int? CurrentOfficerId { get; set; }
        public string? CurrentSubmitType { get; set; }

    }


    public class MeetingRoomBookingCateringServiceExpensesFormEvent
    {
        public int? CateringServiceExpensesId { get; set; }
        public int? MeetingRoomBookingId { get; set; }
        public string? ActionRemark { get; set; }
        public int? CurrentSystemUserId { get; set; }
        public int? CurrentOfficerId { get; set; }

    }


    public class MeetingRoomBookingEventPreview
    {
        public VMeetingRoomBooking? MeetingRoomBooking { get; set; }
        public List<VMeetingRoomBookingHistory>? MeetingRoomBookingHistoryList { get; set; }
        public EventsModel? EventsModel { get; set; }
        public VAudioVisualServiceRequest? AudioVisualServiceRequest { get; set; }

    }

    public class MeetingRoomBookingEventPreviewParameter
    {
        public int? MeetingRoomBookingId { get; set; }
        public string? ActionType { get; set; }
    }


    public class MeetingRoomBookingSlideImage
    {
        public int? MeetingRoomId { get; set; }
        public string? MeetingRoomName { get; set; }
        public Guid? RowGuid { get; set; }
        //public string? ReferenceTable { get; set; }
    }

    public class MeetingRoomBookingSelectDate
    {
        public DateTime? UseDateFrom { get; set; }
        public DateTime? UseDateTo { get; set; }
    }

    public class MeetingRoomBookingSendMail
    {
        public int? MeetingRoomBookingId { get; set; }
        public int? CurrentSystemUserId { get; set; }
    }

}
