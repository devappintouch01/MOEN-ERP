using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel
{
    public class VMeetingRoomReportsCeteringService
    {
        public int? UseYear { get; set; }

        public int? UseMonthId { get; set; }

        public string? Topic { get; set; }

        public string? UseTime { get; set; }

        public string? UseDateFrom { get; set; }
        public DateTime? UseDateFromDt { get; set; }

        public int? Participants { get; set; }

        public int? BookingTypeId { get; set; }

        public string? BookingTypeName { get; set; }

        public string? RoomName { get; set; }

        public int? MeetingRoomId { get; set; }

        public int? BookerOrgId { get; set; }

        public string? BookerOrgName { get; set; }

        public int? LastStatusId { get; set; }
    }
}
