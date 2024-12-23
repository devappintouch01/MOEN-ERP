using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VMeetingRoomFormat
    {
        public int? MeetingRoomId { get; set; }

        public string? MeetingRoomName { get; set; }

        public int? FormatId { get; set; }

        public string? FormatName { get; set; }
        public bool? Active { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }
    }
}
