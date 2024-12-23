using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VCateringServiceExpense
    {
        public int? CateringServiceExpensesId { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public int? BookingFormatId { get; set; }

        public string? BookingFormatName { get; set; }

        public int? MeetingRoomBookingId { get; set; }

        public string? MeetingRoomBookingCode { get; set; }

        public DateTime? MeetingRoomBookingDate { get; set; }

        public int? CateringServiceRequestId { get; set; }

        public string? CateringServiceRequestCode { get; set; }

        public DateTime? CateringServiceRequestDate { get; set; }

        public DateTime? UseDateFrom { get; set; }

        public DateTime? UseDateTo { get; set; }

        public string? Topic { get; set; }

        public int? MeetingRoomId { get; set; }

        public string? Location { get; set; }

        public string? MeetingRoomDetail { get; set; }

        public string? BookingCode { get; set; }

        public int? BookerUserId { get; set; }

        public int? BookerId { get; set; }

        public string? BookerName { get; set; }

        public int? BookerPosId { get; set; }

        public string? BookerPosName { get; set; }

        public int? BookerOrgId { get; set; }

        public string? BookerOrgName { get; set; }

        public DateTime? BookingDate { get; set; }

        public int? BudgetRequestId { get; set; }
        public string? BudgetRequestName { get; set; }

        public string? RequestDetail { get; set; }

        public string? RequestPurpose { get; set; }

        public decimal? SnackCost { get; set; }

        public int? SnackNumber { get; set; }

        public int? SnackRepast { get; set; }

        public decimal? SnackCostAmount { get; set; }

        public decimal? LunchCost { get; set; }

        public int? LunchNumber { get; set; }

        public decimal? LunchCostAmount { get; set; }

        public decimal? DinnerCost { get; set; }

        public int? DinnerNumber { get; set; }

        public decimal? DinnerCostAmount { get; set; }

        public decimal? ExpensesCostAmount { get; set; }

        public int? SystemOperationType { get; set; }

        public string? SystemOperationTypeName { get; set; }

        public string? Remark { get; set; }

        public int? LastHistoryId { get; set; }

        public int? LastActorId { get; set; }

        public int? LastActorUserId { get; set; }

        public string? LastActorName { get; set; }

        public int? LastActionId { get; set; }

        public string? LastActionName { get; set; }

        public string? ActionRemark { get; set; }

        public int? NextActorId { get; set; }

        public int? NextActorUserId { get; set; }

        public string? NextActorName { get; set; }

        public int? LastWorkProcessId { get; set; }

        public string? LastWorkProcessName { get; set; }

        public int? LastWorkProcessRoleId { get; set; }

        public string? LastWorkProcessActorType { get; set; }

        public int? LastStatusId { get; set; }

        public string? LastStatusName { get; set; }

        public bool? IsFinish { get; set; }
    }
}
