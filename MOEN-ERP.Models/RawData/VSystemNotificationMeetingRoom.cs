using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VSystemNotificationMeetingRoom
    {
        public int? Id { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public string? NotificationType { get; set; }

        public DateTime? NotificationDate { get; set; }

        public DateTime? OpenDate { get; set; }

        public string? Status { get; set; }

        public int? NotificationDetailId { get; set; }

        public int? NotificationUserId { get; set; }

        public int? ReferenceId { get; set; }

        public string? ReferenceTable { get; set; }

        public string? Title { get; set; }

        public string? Detail { get; set; }

        public string? BookingCode { get; set; }
    }
}
