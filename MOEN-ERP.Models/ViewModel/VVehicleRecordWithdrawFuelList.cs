using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel
{
    public class VVehicleRecordWithdrawFuelList
    {
        public int Id { get; set; }

        public int? ActorId { get; set; }

        public int? VehicleId { get; set; }

        public int? FuelTypeId { get; set; }

        public DateTime? WithdrawDate { get; set; }

        public DateTime? ReturnedDate { get; set; }

        public decimal? Kilometer { get; set; }

        public double? FuelQuantity { get; set; }

        public decimal? Price { get; set; }

        public string? FuelType { get; set; }

        public string? VehicleType { get; set; }

        public string? ActorName { get; set; }

        public int? FuelCodeId { get; set; }

        public string? ReceiptNo { get; set; }

        public double? FuelQuantityBalance { get; set; }

        public string? Remark { get; set; }

        public string? Code { get; set; }

        public string? VehicleRegistration { get; set; }
    }
}
