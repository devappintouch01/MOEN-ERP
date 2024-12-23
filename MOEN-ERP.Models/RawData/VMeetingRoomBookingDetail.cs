using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VMeetingRoomBookingDetail
    {
        public int? MeetingRoomBookingDetailId { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public int? MeetingRoomBookingId { get; set; }

        public DateTime? UseDateFrom { get; set; }

        public DateTime? UseDateTo { get; set; }

        public bool? IsDailyBooking { get; set; }

        public int? Participants { get; set; }

        public int? BookingTypeId { get; set; }

        public string? BookingTypeName { get; set; }

        public string? Topic { get; set; }

        public int? RealUserId { get; set; }

        public string? RealUserName { get; set; }

        public int? RealUserPosId { get; set; }

        public string? RealUserPosName { get; set; }

        public int? RealUserOrgId { get; set; }

        public string? RealUserOrgName { get; set; }

        public string? BookerPhone { get; set; }

        public string? Remark { get; set; }

        public bool? IsEnableFormatChange { get; set; }

        public bool? IsFormatChange { get; set; }

        public int? RoomFormatId { get; set; }

        public string? RoomFormatName { get; set; }

        public string? RoomFormatRemark { get; set; }

        public bool? IsAudioVisualServiceRequest { get; set; }

        public int? LastAudioVisualServiceRequestId { get; set; }

        public int? LastVideoConferenceBookingId { get; set; }

        public bool? IsCateringServiceRequest { get; set; }

        public int? LastCateringServiceRequestId { get; set; }

        public int? LastCateringServiceExpensesId { get; set; }

        public string? EditRemark { get; set; }

        public DateTime? ApproveDate { get; set; }

        public bool? IsApprove { get; set; }

        public string? ApproveStatusName { get; set; }
    }
}
