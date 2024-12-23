using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using MOEN_ERP.Models.ViewModel.MeetingRoomBooking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.CateringServiceRequest
{
    //internal class CateringServiceRequest
    //{
    //}

    public class SearchCateringServiceRequest
    {
        public string? SearchBookingCode { get; set; }
        public int? SearchBookingTypeId { get; set; }
        public string? SearchTopic { get; set; }
        public int? SearchLastStatusId { get; set; }
        public DateTime? SearchBookingDateFrom { get; set; }
        public DateTime? SearchBookingDateTo { get; set; }
        public DateTime? SearchUseDateFrom { get; set; }
        public DateTime? SearchUseDateTo { get; set; }
        public int? SearchSystemUserId { get; set; }
        public int? SearchSystemUserRoleId { get; set; }

    }

    public class CateringServiceRequestDetailForm
    {
        public int? CateringServiceRequestId { get; set; }
        public int? MeetingRoomBookingId { get; set; }
        public string? BookingCode { get; set; }
        public DateTime? BookingDate { get; set; }
        public int? BookerId { get; set; }
        public string? BookerName { get; set; }
        public int? BookerOrgId { get; set; }
        public string? BookerOrgName { get; set; }
        public int? DivisionId { get; set; }
        public string? BookerPhone { get; set; }
        public int? BookingTypeId { get; set; }
        public string? Topic { get; set; }
        public DateTime? UseDateFrom { get; set; }
        public DateTime? UseDateTo { get; set; }
        public DateTime? UseDateFromTime { get; set; }
        public DateTime? UseDateToTime { get; set; }
        public int? MeetingRoomId { get; set; }
        public string? Location { get; set; }
        public bool? ChairmanType { get; set; }
        public int? ChairmanId { get; set; }
        public string? ChairmanOutsider { get; set; }
        /// <summary>
        /// จำนวนผู้เข้าร่วมประชุม
        /// </summary>
        public int? Participants { get; set; }

        public List<int>? CateringServiceParticipantTypeList { get; set; }
        public bool? IsSnackRequest { get; set; }
        public bool? IsSnackMorning { get; set; }
        public bool? IsSnackAfternoon { get; set; }
        public DateTime? SnackServeInsideTime { get; set; }
        public DateTime? SnackServeOutsideTime { get; set; }

        public string? SnackDetail { get; set; }
        public DateTime? SnackAfternoonServiceInsideTime { get; set; }
        public DateTime? SnackAfternoonServiceOutsideTime { get; set; }
        public List<VCateringServiceRequestSnackList>? CateringServiceRequestSnackList { get; set; }
        public int? LunchRestaurantId { get; set; }

        public bool? IsLunchRequest { get; set; }
        public DateTime? LunchServeTime { get; set; }
        public int? LunchNumber { get; set; }
        public int? LunchFoodCategoryId { get; set; }
        public string? LunchDetail { get; set; }
        public CateringServiceRequestLunch? CateringServiceRequestLunch { get; set; }


        public int? DinnerRestaurantId { get; set; }
        public bool? IsDinnerRequest { get; set; }
        public DateTime? DinnerServeTime { get; set; }
        public int? DinnerNumber { get; set; }
        public int? DinnerFoodCategoryId { get; set; }
        public string? DinnerDetail { get; set; }
        public CateringServiceRequestDinner? CateringServiceRequestDinner { get; set; }


        public bool? IsVegetarianFood { get; set; }
        public int? VegetarianFoodNumber { get; set; }
        public bool? IsHalalFood { get; set; }
        public int? HalalFoodNumber { get; set; }

        public bool? IsExpensesRequest { get; set; }
        public int? CateringServiceRequestLastStatusId { get; set; }
        public int? CateringServiceExpensesId { get; set; }
        public int? CateringServiceExpensesLastStatusId { get; set; }

        public string? LastWorkProcessActorType { get; set; }
        public string? RequestEditActionRemark { get; set; }
        public int? NextActorUserId { get; set; }
        public int? LastWorkProcessRoleId { get; set; }
        //public string? ActionRemark { get; set; }

        public string? RemarkCancel { get; set; }
        public string? RemarkSendBackEdit { get; set; }
        public string? RemarkRequestEdit { get; set; }

        public int? DirectorApproveId1 { get; set; }
        public int? DirectorApproveId2 { get; set; }

        public string[]? FileGuidId { get; set; }
        public string? SubmitType { get; set; }
        public int? CurrentSystemUserId { get; set; }
        public int? CurrentOfficerId { get; set; }
    }

    public class CateringServiceRequestLunch
    {
        public List<VCateringRestaurant>? CateringServiceRequestLunchList { get; set; }
        public int? SelectLunchRestaurantId { get; set; }
        public int? SelectLunchFoodCategoryId { get; set; }
        //public List<AttachFile>? AttachFileList { get; set; }
    }

    public class CateringServiceRequestDinner
    {
        public List<VCateringRestaurant>? CateringServiceRequestDinnerList { get; set; }
        public int? SelectDinnerRestaurantId { get; set; }
        public int? SelectDinnerFoodCategoryId { get; set; }
        //public List<AttachFile>? AttachFileList { get; set; }
    }

    public class CateringServiceRequestSelectSnack
    {
        public List<VCateringServiceRequestSnackList>? CateringServiceRequestSnackList { get; set; }
        public List<VCateringRestaurantSnack>? CateringRestaurantList { get; set; }
        public List<int>? NewSelectRestaurantIdList { get; set; }

    }

    public class CateringServiceRequestBookingFormEvent
    {
        public int? CateringServiceRequestId { get; set; }
        public int? CateringServiceRequestStatusId { get; set; }    
        public string? ActionType { get; set; }
        public string? ActionRemark { get; set; }
        public int? CurrentSystemUserId { get; set; }
        public int? CurrentOfficerId { get; set; }

    }


    public class EventPreviewCateringServiceRequestBookingParameter
    {
        public int? CateringServiceRequestId { get; set; }
        public string? ActionType { get; set; }
    }


    public class EventPreviewCateringServicePreviewForm
    {
        //public VCateringServiceRequest? CateringServiceRequestBooking { get; set; } 
        public int? CateringServiceRequestId { get; set; }
        public bool? IsExpensesRequest { get; set; }
        public int? CateringServiceExpensesId { get; set; }
        public string? SubmitType { get; set; }

    }

    public class EventPreviewCateringServiceRequestBooking
    {
        public VCateringServiceRequest? CateringServiceRequestBooking { get; set; }
        public List<VCateringServiceRequestHistory>? CateringServiceRequestHistoryList { get; set; }
        public EventsModel? EventsModel { get; set; }

    }


    /// <summary>
    /// เบิกค่าจัดเลี้ยง
    /// </summary>
    public class CateringServiceExpensesForm
    {
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

        public int? LastStatusId { get; set; }



        public string? LastStatusName { get; set; }
        public int? BudgetRequestId { get; set; }
        public string? BudgetRequestName { get; set; }
        public string? RequestDetail { get; set; }
        public string? RequestPurpose { get; set; }

        public bool? IsSnackRequest { get; set; }
        public int? SnackRepast { get; set; }

        public bool? IsLunchRequest { get; set; }
        public decimal? LunchCost { get; set; }
        public int? LunchNumber { get; set; }
        public decimal? LunchCostAmount { get; set; }

        public bool? IsDinnerRequest { get; set; }
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
        //public bool? IsRequestByMeetingRoomBooking { get; set; }
        public string? ActionType { get; set; }
        public int? CurrentSystemUserId { get; set; }
        public int? CurrentOfficerId { get; set; }
        public string? CurrentSubmitType { get; set; }

    }

    public class CateringServiceExpensesFormEvent
    {
        public int? CateringServiceExpensesId { get; set; }
        public int? MeetingRoomBookingId { get; set; }
        public string? ActionRemark { get; set; }
        public int? CurrentSystemUserId { get; set; }
        public int? CurrentOfficerId { get; set; }

    }


    public class RequestExpensesForCateringServiceRequestDetailForm
    {
        public int? CateringServiceRequestId { get; set; }
        public int? MeetingRoomBookingId { get; set; }
        //public bool? IsRequestByAudioVisualService { get; set; }
    }


}
