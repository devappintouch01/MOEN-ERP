using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Data
{
    public class VehicleTaxPaymentHistory
    {
        public int? Id { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? VehicleId { get; set; }
        public DateTime? TaxExpireDate { get; set; }
        public DateTime? NextTaxExpireDate { get; set; }
        public decimal? TaxValue { get; set; }
        public DateTime? TaxPaymentDate { get; set; }
    }
}
