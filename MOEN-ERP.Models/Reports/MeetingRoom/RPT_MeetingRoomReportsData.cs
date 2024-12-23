using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Reports.MeetingRoom
{
    public class RPT_MeetingRoomReportsData
    {
        public string UseDateFrom { get; set; }
        public string UseTime { get; set; }
        public string Topic { get; set; }
        public string RoomName { get; set; }
        public int Participants { get; set; }
        public string BookingTypeName { get; set; }
        public string BookerOrgName { get; set; }
    }
}
