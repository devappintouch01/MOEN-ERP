using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VVehicleMaintenanceHistory
    {
        public int? VehicleId { get; set; }

        public bool? VehicleActive { get; set; }  

        public string? VehicleRegistration { get; set; }

        public int? VehicleCreateBy { get; set; }

        public DateTime? VehicleCreateOn { get; set; }

        public int? VehicleUpdateBy { get; set; }

        public DateTime? VehicleUpdateOn { get; set; }

        public int? VtypeId { get; set; }

        public string? VtypeName { get; set; }

        public bool? VtypeActive { get; set; }

        public int? VtypeCreateBy { get; set; }

        public DateTime? VtypeCreateOn { get; set; }

        public int? VtypeUpdateBy { get; set; }

        public DateTime? VtypeUpdateOn { get; set; }

        public int? VbrandId { get; set; }

        public string? VbrandName { get; set; }

        public bool? VbrandActive { get; set; }

        public int? VbrandCreateBy { get; set; }

        public DateTime? VbrandCreateOn { get; set; }

        public int? VbrandUpdateBy { get; set; }

        public DateTime? VbrandUpdateOn { get; set; }

        public int? VmodelId { get; set; }

        public string? VmodelName { get; set; }

        public bool? VmodelActive { get; set; }

        public int? VmodelCreateBy { get; set; }

        public DateTime? VmodelCreateOn { get; set; }

        public int? VmodelUpdateBy { get; set; }

        public DateTime? VmodelUpdateOn { get; set; }

        public int? MaintenanceId { get; set; }

        public int? GarageId { get; set; }

        public string? GarageName { get; set; }

        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? SendDate { get; set; }

        public int? McreateBy { get; set; }

        public DateTime? McreateOn { get; set; }

        public int? MupdateBy { get; set; }

        public DateTime? MupdateOn { get; set; }
    }
}
