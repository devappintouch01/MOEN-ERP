using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VMeetingRoomDevice
    {
        public int? Id { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public string? Detail { get; set; }

        public int? MeetingRoomId { get; set; }

        public string? MeetingRoomName { get; set; }

        public string? Floor { get; set; }

        public string? RoomNumber { get; set; }

        public string? Location { get; set; }

        public int? DeviceId { get; set; }

        public string? DeviceName { get; set; }

        public int? TotalAll { get; set; }

        public int? TotalRemain { get; set; }

        public int? UsedPerRoom { get; set; }

        public int? TotalUsedAll { get; set; }

        public int? StatusId { get; set; }

        public string? StatusName { get; set; }

        public string? DeviceStatusGroup { get; set; }

        public int? NormalCount { get; set; }

        public int? AbnormalCount { get; set; }

        public int? RepairCount { get; set; }

        public string? DeviceStatusGroupName { get; set; }

    }
}
