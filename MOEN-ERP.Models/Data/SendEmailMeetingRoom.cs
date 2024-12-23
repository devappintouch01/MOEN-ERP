using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Data
{
    public class SendEmailMeetingRoom
    {
        public int? Id { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
        public DateTime? SendDate { get; set; }
        public int? SenderUserId { get; set; }
        public int? ReceiverUserId { get; set; }
        public string? ReceiverEmail { get; set; }
        public int? MasterMeetingRoomEmailId { get; set; }
        public string? ReferenceTable { get; set; }
        public int? ReferenceId { get; set; }
    }
}
