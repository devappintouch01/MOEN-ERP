using MOEN_ERP.Models.RawData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.VehicleRecord
{
    //internal class VehicleRecord
    //{
    //}

    public class SearchVehicleRecord
    {
        public string? SearchBookingCode { get; set; }
        public string? SearchBookerName { get; set; }
        //public int? SearchBookingFormatId { get; set; }
        public int? SearchVehicleId { get; set; }
        public int? SearchBookerOrganizationId { get; set; }
        public DateTime? SearchBookingDateFrom { get; set; }
        public DateTime? SearchBookingDateTo { get; set; }
        public DateTime? SearchTravelFromDateFrom { get; set; }
        public DateTime? SearchTravelFromDateTo { get; set; }
        public int? SearchSystemUserId { get; set; }
        public int? SearchSystemUserRoleId { get; set; }
    }

    public class VehicleRecordBooking
    {
        public List<VVehicleBookingAssign>? VehicleBookingList { get; set; }
    }


    public class VehicleRecordBookingFormEvent
    {
        public int? VehicleBookingId { get; set; }      
        public int? VehicleBookingRecordId { get; set; }
        public int? VehicleBookingAssignId { get; set; }
        public string? VehicleRegistration { get; set; }
        public string? VehicleBookingCode { get; set; }
        public DateTime? TravelFromDate { get; set; }
        public DateTime? TravelToDate { get; set; }
        public DateTime? TravelFromDateTime { get; set; }
        public DateTime? TravelToDateTime { get; set; }
        public decimal? StartCarMileage { get; set; }
        public decimal? FinishCarMileage { get; set; }
        public decimal? TravelDistance { get; set; }
        /// <summary>
        /// 1 = เรียบร้อย 2 = ไม่เรียบร้อย
        /// </summary>
        public int? CarInspectionStatus { get; set; }
        public string? Remark { get; set; }
        public int? VehicleId { get; set; }
       // public decimal? PresentCarMileage { get; set; }

        public string? ActionType { get; set; }
        public int? CurrentSystemUserId { get; set; }
        public int? CurrentOfficerId { get; set; }
        
        public DateTime? BookingTravelFromDate { get; set; }
        public DateTime? BookingTravelToDate { get; set; }
        
    }


    public class SearchVehicleRecorded
    {
        public string? SearchBookingCode { get; set; }
        public string? SearchBookerName { get; set; }
        public int? SearchVehicleId { get; set; }
        //public int? SearchBookingFormatId { get; set; }
        //public int? SearchBookingRegistrationId { get; set; }
        public int? SearchBookerOrganizationId { get; set; }
        public DateTime? SearchBookingDateFrom { get; set; }
        public DateTime? SearchBookingDateTo { get; set; }
        public DateTime? SearchTravelFromDateFrom { get; set; }
        public DateTime? SearchTravelFromDateTo { get; set; }
        public int? SearchSystemUserId { get; set; }
        public int? SearchSystemUserRoleId { get; set; }
    }

    public class VehicleRecordedBooking
    {
        public List<VVehicleBookingAssign>? VehicleBookingList { get; set; }
    }



}
