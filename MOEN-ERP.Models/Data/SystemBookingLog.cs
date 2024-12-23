using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Data
{
    public class SystemBookingLog
    {
        public int? Id { get; set; }
        public DateTime? Time { get; set; }
        public string? Action { get; set; }
        public int? UserId { get; set; }
        public string? SessionId { get; set; }
        public string? IpAddress { get; set; }
        public string? SystemInfo { get; set; }
    }
}
