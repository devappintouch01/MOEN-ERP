using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VVehicle
    {
        public int VehicleId { get; set; }

        public int? OwnershipId { get; set; }

        public string? OwnershipName { get; set; }

        public int? AssetId { get; set; }

        public int? CarSeats { get; set; }

        public int? VehicleFuelTypeId { get; set; }

        public decimal? FirstCarMileage { get; set; }

        public decimal? PresentCarMileage { get; set; }

        public string? VehicleRegistration { get; set; }

        public decimal? VehiclePrice { get; set; }

        public string? VcarKeeperPhone { get; set; }

        public string? OganizationPhone { get; set; }

        public string? Detail { get; set; }

        public string? Remark { get; set; }

        public string? Hexcode { get; set; }

        public bool? VehicleActive { get; set; }

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

        public int? FuelTypeId { get; set; }

        public string? FuelTypeName { get; set; }

        public bool? FuelTypeActive { get; set; }

        public int? FuelTypeCreateBy { get; set; }

        public DateTime? FuelTypeCreateOn { get; set; }

        public int? FuelTypeUpdateBy { get; set; }

        public DateTime? FuelTypeUpdateOn { get; set; }

        public int? DriverId { get; set; }

        public string? DriverName { get; set; }

        public int? DriverPositionId { get; set; }

        public string? DriverActive { get; set; }

        public int? DriverOrgId { get; set; }

        public int? OfficerCarKeeperId { get; set; }

        public string? CarKeeperName { get; set; }

        public int? CarKeeperPositionId { get; set; }

        public string? CarKeeperActive { get; set; }

        public string? CarKeeperPhone { get; set; }

        public int? CarKeeperOrgId { get; set; }

        public int? OrganizationId { get; set; }

        public string? OrganizationName { get; set; }

        public string? VehicleType { get; set; }

        public DateTime? VehicleReceiveDate { get; set; }

    }
}
