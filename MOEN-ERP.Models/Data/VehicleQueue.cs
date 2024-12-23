using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Data
{
    public class VehicleQueue
    {
        public int? Id { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }

        public DateTime? QueueDate { get; set; }

        public int? VehicleId { get; set; }

        public int? DriverId { get; set; }

        public string? GoTime { get; set; }

        public string? TravelToLocation { get; set; }

        public string? BackTime { get; set; }

        public int? OrganizationId { get; set; }

        public int? BookerId { get; set; }
    }
}
