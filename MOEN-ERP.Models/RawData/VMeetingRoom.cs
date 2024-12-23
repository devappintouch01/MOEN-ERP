using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VMeetingRoom
    {
        public int? RoomId { get; set; }

        public string? RoomName { get; set; }

        public string? Location { get; set; }

        public string? Floor { get; set; }

        public string? RoomNumber { get; set; }

        public int? Participants { get; set; }

        public int? OfficerId { get; set; }

        public string? OfficerName { get; set; }

        public string? OfficerPhone { get; set; }

        public int? OrganizationId { get; set; }

        public string? OrganizationName { get; set; }

        public bool? Active { get; set; }

        public string? Detail { get; set; }

        public string? Remark { get; set; }

        public bool? FormatChange { get; set; }

        public string? DisplayType { get; set; }

        public string? DisplayTypeName { get; set; }

        public string? Hexcode { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }
    }

}
