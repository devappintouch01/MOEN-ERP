using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel
{
    public class VVehicleReportsCarService
    {
        public int? BookingYear { get; set; }

        public int? BookingMonthId { get; set; }

        public string? TravelDate { get; set; }

        public string? TravelTime { get; set; }

        public string? BookingPurpose { get; set; }

        public string? TravelToLocation { get; set; }

        public int? VehicleId { get; set; }

        public string? VehicleType { get; set; }

        public int? Passengers { get; set; }

        public int? BookingFormatId { get; set; }

        public string? BookingFormat { get; set; }

        public string? OrganizationName { get; set; }

        public string? Abbreviation { get; set; }

        public int? DriverId { get; set; }

        public string? DriverName { get; set; }

        public int? LastStatusId { get; set; }

        public string? HeaderReport { get; set; }
        public int? BookerOrgId { get; set; }

        public string? BookerName { get; set; }
    }
}
