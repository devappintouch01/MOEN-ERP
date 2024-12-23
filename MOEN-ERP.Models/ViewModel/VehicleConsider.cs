using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.RawData;
using MOEN_ERP.Models.ViewModel.VehicleBooking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.VehicleConsider
{
    
    public class SearchVehicleConsider
    {
        public string? BookingCode { get; set; }
        public string? BookerName { get; set; }
        public int? BookingFormatId { get; set; }      
        public int? BookerOrganizationId { get; set; }
        public DateTime? BookingDateFrom { get; set; }
        public DateTime? BookingDateTo { get; set; }
        public DateTime? TravelFromDateFrom { get; set; }
        public DateTime? TravelFromDateTo { get; set; }
        public bool? IsFinish { get; set; }
        public int? SystemUserId { get; set; }
        public int? SystemUserRoleId { get; set; }
        public int? SystemOrganizationId { get; set; }
    }

    public class VehicleConsiderBooking
    {
        public List<VVehicleBooking>? VehicleBookingList { get; set; }
    }


    public class VehicleConsiderBookingApprove
    {
        public VVehicleBooking? VVehicleBooking { get; set; }
        public VVehicleBookingAssign? VVehicleBookingAssign { get; set; }
        public List<VVehicleBookingHistory>? VehicleBookingHistoryList { get; set; }
        public EventsModel? EventsModel { get; set; }
        
    }

    #region ตรวจสอบการจองยานพาหนะ
    public class SearchVehicleAssign
    {
        public string? SearchBookingCode { get; set; }
        public string? SearchBookerName { get; set; }
        public int? SearchBookingFormatId { get; set; }
        public int? SearchBookerOrganizationId { get; set; }
        public DateTime? SearchBookingDateFrom { get; set; }
        public DateTime? SearchBookingDateTo { get; set; }
        public DateTime? SearchTravelFromDateFrom { get; set; }
        public DateTime? SearchTravelFromDateTo { get; set; }
        //public bool? SearchIsFinish { get; set; }
        public int? SearchSystemUserId { get; set; }
        public int? SearchSystemUserRoleId { get; set; }
    }

    public class AssignVehicleBooking
    {
        public List<VVehicleBooking>? VehicleBookingList { get; set; }
    }


    public class ApproveAssignVehicleBookingFormEvent
    {
        public int? VehicleBookingId { get; set; }
        public int? LastStatusId { get; set; }
        public bool? IsLastStatusId12 { get; set; }
        public int? VehicleTypeId { get; set; }
        public int? VehicleId { get; set; }
        public string? VehicleDetail { get; set; }
        public int? Passengers { get; set; }
        public int? DriverId { get; set; }
        public string? ActionRemark { get; set; }
        public string? ActionType { get; set; }
        public int? CurrentSystemUserId { get; set; }
        public int? CurrentOfficerId { get; set; }
    }

    public class AssignVehicleBookingFormEvent
    {
        public int? VehicleBookingId { get; set; }
        public string? ActionRemark { get; set; }
        public int? CurrentSystemUserId { get; set; }
        public int? CurrentOfficerId { get; set; }

    }

    #endregion



    public class SearchVehicleAssigned
    {
        public string? SearchBookingCode { get; set; }
        public string? SearchBookerName { get; set; }
        public int? SearchBookingFormatId { get; set; }
        public int? SearchBookerOrganizationId { get; set; }
        public DateTime? SearchBookingDateFrom { get; set; }
        public DateTime? SearchBookingDateTo { get; set; }
        public DateTime? SearchTravelFromDateFrom { get; set; }
        public DateTime? SearchTravelFromDateTo { get; set; }
        public int? SearchSystemUserId { get; set; }
        public int? SearchSystemUserRoleId { get; set; }
    }

    public class AssignedVehicleBooking
    {
        public List<VVehicleBooking>? VehicleBookingList { get; set; }
    }


    public class SearchVehicleConsidered
    {
        public string? BookingCode { get; set; }
        public string? BookerName { get; set; }
        public int? BookingFormatId { get; set; }
        public int? BookerOrganizationId { get; set; }
        public DateTime? BookingDateFrom { get; set; }
        public DateTime? BookingDateTo { get; set; }
        public DateTime? TravelFromDateFrom { get; set; }
        public DateTime? TravelFromDateTo { get; set; }
        public bool? IsFinish { get; set; }
        public int? SystemUserId { get; set; }
        public int? SystemUserRoleId { get; set; }
    }


    public class VehicleConsideredBooking
    {
        public List<VVehicleBooking>? VehicleBookingList { get; set; }
    }


    public class VehicleArrangementList
    {
        public List<VVehicleBookingAssign>? VehicleBookingAssignList { get; set; }
    }




}
