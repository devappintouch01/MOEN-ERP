using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VMeetingRoomBookingAssetChangeItem
    {
        public int? MeetingRoomBookingAssetChangeId { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public int? AssetChangeFormId { get; set; }

        public string? AssetChangeFormCode { get; set; }

        public DateTime? AssetChangeFormDate { get; set; }

        public int? AssetChangeType { get; set; }

        public string? AssetChangeTypeName { get; set; }

        public int? SourceOfficerId { get; set; }

        public string? SourceOfficerFullName { get; set; }

        public int? AssetId { get; set; }

        public string? AssetDetail { get; set; }

        public int? Amount { get; set; }

        public int? SourceOrganizationId { get; set; }

        public string? SourceOrganizationName { get; set; }

        public string? AssetChangeStatus { get; set; }

        public string? AssetChangeStatusName { get; set; }

        public string? IsReturnComplete { get; set; }

        public int? MeetingRoomBookingId { get; set; }

        public string? MeetingRoomBookingCode { get; set; }

        public DateTime? MeetingRoomBookingDate { get; set; }

        public int? BookerId { get; set; }

        public string? BookerName { get; set; }

        public int? BookerUserId { get; set; }

        public int? MeetingRoomId { get; set; }

        public string? MeetingRoomName { get; set; }
    }
}
