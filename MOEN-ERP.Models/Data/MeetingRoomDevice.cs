using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Data
{
    public class MeetingRoomDevice
    {
        public int? Id { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? MeetingRoomId { get; set; }
        public int? DeviceId { get; set; }
        public int? DeviceStatusId { get; set; }
        public string? Detail { get; set; }
    }

}
