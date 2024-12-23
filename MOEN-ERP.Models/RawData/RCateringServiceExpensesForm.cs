using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class RCateringServiceExpensesForm
    {
        public int? Id { get; set; }

        public int? MeetingRoomBookingId { get; set; }

        public int? CateringServiceRequestId { get; set; }

        public string? BookingCode { get; set; }

        public DateTime? BookingDate { get; set; }

        public int? BookerUserId { get; set; }

        public int? BookerId { get; set; }

        public string? BookerName { get; set; }

        public int? BookerPosId { get; set; }

        public string? BookerPosName { get; set; }

        public int? BookerOrgId { get; set; }

        public string? BookerOrgName { get; set; }

        public string? BookerPhone { get; set; }

        public int? DivisionId { get; set; }

        public string? DivisionName { get; set; }

        public string? Topic { get; set; }

        public string? RequestPurpose { get; set; }

        public DateTime? UseDateFrom { get; set; }

        public DateTime? UseDateTo { get; set; }

        public int? MeetingRoomId { get; set; }

        public string? Location { get; set; }

        public string? MeetingRoomDetail { get; set; }

        public string? ChairmanName { get; set; }

        public int? Participants { get; set; }

        public decimal? ExpensesCostAmount { get; set; }

        public bool? IsCabinetResolution { get; set; }

        public string? SnackRemark { get; set; }

        public decimal? SnackCost { get; set; }

        public int? SnackNumber { get; set; }

        public int? SnackRepast { get; set; }

        public decimal? SnackCostAmount { get; set; }

        public bool? IsLunchCabinetResolution { get; set; }

        public string? LunchRemark { get; set; }

        public decimal? LunchCost { get; set; }

        public int? LunchNumber { get; set; }

        public decimal? LunchCostAmount { get; set; }

        public bool? IsDinnerCabinetResolution { get; set; }

        public string? DinnerRemark { get; set; }

        public decimal? DinnerCost { get; set; }

        public int? DinnerNumber { get; set; }

        public decimal? DinnerCostAmount { get; set; }

        public string? Remark { get; set; }
    }
}
