using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VCateringServiceRequest
    {
        public int? CateringServiceRequestId { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public int? LastRequestDetailId { get; set; }

        public string? EditRemark { get; set; }

        public bool? IsApprove { get; set; }

        public DateTime? ApproveDate { get; set; }

        public int? DetailCreateBy { get; set; }

        public DateTime? DetailCreateOn { get; set; }

        public int? DetailUpdateBy { get; set; }

        public DateTime? DetailUpdateOn { get; set; }

        public int? BookingFormatId { get; set; }

        public string? BookingFormatName { get; set; }

        public int? MeetingRoomBookingId { get; set; }

        public string? MeetingRoomBookingCode { get; set; }

        public DateTime? MeetingRoomBookingDate { get; set; }

        public string? BookingCode { get; set; }

        public int? BookerUserId { get; set; }

        public int? BookerId { get; set; }

        public string? BookerName { get; set; }

        public int? BookerPosId { get; set; }

        public string? BookerPosName { get; set; }

        public int? BookerOrgId { get; set; }

        public string? BookerOrgName { get; set; }
        public int? BookerOrgDirectorId { get; set; }

        public int? DivisionId { get; set; }

        public string? DivisionName { get; set; }

        public DateTime? BookingDate { get; set; }

        public string? BookerPhone { get; set; }

        public int? BookingTypeId { get; set; }

        public string? BookingTypeName { get; set; }

        public string? Topic { get; set; }

        public DateTime? UseDateFrom { get; set; }

        public DateTime? UseDateTo { get; set; }

        public string? Location { get; set; }

        public int? ChairmanId { get; set; }

        public string? ChairmanName { get; set; }

        public int? ChairmanPosId { get; set; }

        public string? ChairmanPosName { get; set; }

        public int? ChairmanOrgId { get; set; }

        public string? ChairmanOrgName { get; set; }

        public int? Participants { get; set; }

        public bool? IsSnackRequest { get; set; }

        public DateTime? SnackServeInsideTime { get; set; }

        public DateTime? SnackServeOutsideTime { get; set; }

        public bool? IsLunchRequest { get; set; }

        public DateTime? LunchServeTime { get; set; }

        public int? LunchNumber { get; set; }

        public int? LunchFoodCategoryId { get; set; }

        public int? LunchRestaurantId { get; set; }

        public string? LunchRestaurantName { get; set; }

        public bool? IsDinnerRequest { get; set; }

        public DateTime? DinnerServeTime { get; set; }

        public int? DinnerNumber { get; set; }

        public int? DinnerFoodCategoryId { get; set; }

        public int? DinnerRestaurantId { get; set; }

        public string? DinnerRestaurantName { get; set; }

        public bool? IsVegetarianFood { get; set; }

        public int? VegetarianFoodNumber { get; set; }

        public bool? IsHalalFood { get; set; }

        public int? HalalFoodNumber { get; set; }

        public bool? IsExpensesRequest { get; set; }

        public int? LastCateringServiceExpensesId { get; set; }

        public int? LastHistoryId { get; set; }

        public int? LastWorkProcessId { get; set; }

        public string? LastWorkProcessName { get; set; }

        public int? LastWorkProcessRoleId { get; set; }

        public string? LastWorkProcessActorType { get; set; }

        public int? LastActorId { get; set; }

        public int? LastActorUserId { get; set; }

        public string? LastActorName { get; set; }

        public int? NextActorId { get; set; }

        public int? NextActorUserId { get; set; }

        public string? NextActorName { get; set; }

        public int? LastActionId { get; set; }

        public string? LastActionName { get; set; }

        public string? ActionRemark { get; set; }

        public int? LastStatusId { get; set; }

        public string? LastStatusName { get; set; }

        public bool? IsFinish { get; set; }
        public int? DirectorApproveId1 { get; set; }

        public int? DirectorApproveId2 { get; set; }
    }

}
