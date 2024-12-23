using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Data
{
    public class Vehicle
    {
        public int? Id { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateOn { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? OwnershipId { get; set; }
        public int? AssetId { get; set; }
        public int? VehicleTypeId { get; set; }
        public int? VehicleBrandId { get; set; }
        public int? VehicleModelId { get; set; }
        public int? CarSeats { get; set; }
        public int? FuelTypeId { get; set; }
        public decimal? FirstCarMileage { get; set; }
        public decimal? PresentCarMileage { get; set; }
        public string? VehicleRegistration { get; set; }
        public decimal? VehiclePrice { get; set; }
        public int? RegularDriverId { get; set; }
        public int? CarKeeperId { get; set; }
        public string? CarKeeperPhone { get; set; }
        public int? OganizationId { get; set; }
        public string? OganizationPhone { get; set; }
        public string? Detail { get; set; }
        public string? Remark { get; set; }
        public string? Hexcode { get; set; }
        public bool? Active { get; set; }
    public DateTime? VehicleReceiveDate { get; set; }

    }
}
