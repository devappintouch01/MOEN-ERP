using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Data
{
    public class MasterVehicleModel
    {
        public int? Id { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? VehicleBrandId { get; set; }
        public string? Name { get; set; }
        public bool? Active { get; set; }      
    }
}
