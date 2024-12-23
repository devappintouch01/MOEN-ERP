using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VVehicleTaxPaymentHistory
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

        public int? TaxPaymentId { get; set; }

        public DateTime? TaxExpireDate { get; set; }

        public DateTime? NextTaxExpireDate { get; set; }

        public DateTime? TaxPaymentDate { get; set; }

        public int? TaxCreateBy { get; set; }

        public DateTime? TaxCreateOn { get; set; }

        public int? TaxUpdateBy { get; set; }

        public DateTime? TaxUpdateOn { get; set; }
    }
}
