using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Data
{
    public class VehicleMaintenanceHistory
    {
        public int? Id { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? VehicleId { get; set; }
        public decimal? SendDistance { get; set; }
        public decimal? AfterDistance { get; set; }
        public DateTime? SendDate { get; set; }
        public decimal? CostAmount { get; set; }
        public int? GarageId { get; set; }
        public DateTime? InspectionDate { get; set; }
        public int? SenderId { get; set; }
        public decimal? NextSendDistance { get; set; }
    }
}
