using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.RawData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.VehicleBooking
{

    public class SearchVehicleBooking
    {
        public string? BookingCode { get; set; }
        public int? BookingFormatId { get; set; }
        //public int? VehicleId { get; set; }
        public string? TravelToLocation { get; set; }
        public int? LastStatusId { get; set; }
        public DateTime? BookingDateFrom { get; set; }
        public DateTime? BookingDateTo { get; set; }
        public DateTime? TravelFromDateFrom { get; set; }
        public DateTime? TravelFromDateTo { get; set; }
        public bool? IsFinish { get; set; }
        public int? SystemUserId { get; set; }
        public int? SystemUserRoleId { get; set; }
    }

    public class VehicleBookingViewModel
    {
        public List<VVehicleBooking> VehicleBookingList { get; set; }
    }


    #region VehicleBookingDetail
    public class VehicleBookingForm
    {
        public int? BookingId { get; set; }
        public string? BookingCode { get; set; }
        public int? BookerId { get; set; }
        public string? BookerName { get; set; }
        public int? BookerPosId { get; set; }
        public string? BookerPosName { get; set; }
        public int? BookerOrgId { get; set; }
        public string? BookerOrgName { get; set; }
        public int? DivisionId { get; set; }
        public string? DivisionName { get; set; }
        public DateTime? BookingDate { get; set; }
        public int? BookingFormatId { get; set; }
        public string? BookingFormatName { get; set; }
        public DateTime? TravelFromDate { get; set; }
        public DateTime? TravelToDate { get; set; }
        public DateTime? TravelFromTime { get; set; }
        public DateTime? TravelToTime { get; set; }
        public bool? IsDailyBooking { get; set; }
        public int? Passengers { get; set; }
        /// <summary>
        /// จุดเริ่มต้นการเดินทาง
        /// </summary>
        public string? TravelFromLocation { get; set; }
        /// <summary>
        /// จุดหมายการเดินทาง
        /// </summary>
        public string? TravelToLocation { get; set; }
        /// <summary>
        /// วัตถุประสงค์การจอง
        /// </summary>
        public string? BookingPurpose { get; set; }
        /// <summary>
        /// เบอร์โทรผู้จอง
        /// </summary>
        public string? BookerPhone { get; set; }
        /// <summary>
        /// ประเภทการจอง
        /// </summary>
        public int? BookingTypeId { get; set; }
        /// <summary>
        /// ประเภทการจอง
        /// </summary>
        public string? BookingTypeName { get; set; }
        /// <summary>
        /// กรณีพิเศษ
        /// </summary>
        public bool? IsSpecialCase { get; set; }
        /// <summary>
        /// รายละเอียดของกรณีพิเศษ
        /// </summary>
        public string? SpecialCaseRemark { get; set; }
        /// <summary>
        /// หมายเหตุ
        /// </summary>

        public string? Remark { get; set; }
        public int? LastStatusId { get; set; }
        public int? DirectorApproveId { get; set; }
        public int? VehicleId { get; set; }
        public string? VehicleDetail { get; set; }
        public int? DriverId { get; set; }
        public string? DriverName { get; set; }
        public string? DriverPhone { get; set; }
        public int? CountVehicleAssign { get; set; }
        public int? Vehicles { get; set; }
        public string? RemarkCancel { get; set; }
        public string? RemarkRequestEdit { get; set; }

        public string[]? FileGuidId { get; set; }
        public string? SubmitType { get; set; }
        public int? CurrentSystemUserId { get; set; }
        public int? CurrentOfficerId { get; set; }
        public int? NextActorUserId { get; set; }
        //public int? NextActorId { get; set; }
        public int? LastWorkProcessRoleId { get; set; }
        public bool? IsFinish { get; set; }


        public string? ReturnUrl { get; set; }
        public string? LastWorkProcessActorType { get; set; }
    }

    public class VehicleBookingFormEvent
    {
        public VehicleBookingForm? VehicleBookingForm { get; set; }
        public string? ActionRemark { get; set; }
        public int? CurrentSystemUserId { get; set; }
        public int? CurrentOfficerId { get; set; }

    }



    #endregion



    


}
