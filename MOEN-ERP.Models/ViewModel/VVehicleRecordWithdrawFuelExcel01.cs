using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel
{
    public class VVehicleRecordWithdrawFuelExcel01
    {
        public int? Id { get; set; }

        public int? VehicleId { get; set; }

        public string? VbrandName { get; set; }

        public string? VmodelName { get; set; }

        public string? VehicleRegistration { get; set; }

        public double? CountFuelQuantity { get; set; }

        public decimal? CountPrice { get; set; }

        public string? FuelType { get; set; }

        public decimal? CountKilometer { get; set; }

        public decimal? StartCarMileage { get; set; }

        public decimal? FinishCarMileage { get; set; }

        public decimal? CountMileage { get; set; }

        public decimal? CountWastefulUse { get; set; }

        public int? FiscalYear { get; set; }

        public DateTime? VehicleReceiveDate { get; set; }
    }
}
