using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VVehicleTaxPaymentHistoryDetail
    {
        public int? Id { get; set; }

        public DateTime? TaxExpireDate { get; set; }

        public DateTime? NextTaxExpireDate { get; set; }

        public decimal? TaxValue { get; set; }

        public DateTime? TaxPaymentDate { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

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

        public int? VbrandId { get; set; }

        public string? VbrandName { get; set; }

        public bool? VbrandActive { get; set; }

        public int? VmodelId { get; set; }

        public string? VmodelName { get; set; }

        public bool? VmodelActive { get; set; }
    }
}
