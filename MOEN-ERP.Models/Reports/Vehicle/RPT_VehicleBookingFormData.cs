using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Reports.Vehicle
{
    public class RPT_VehicleBookingFormData
    {
        public int BookingId { get; set; }
        /// <summary>
        /// วันที่จองยานพาหนะ
        /// </summary>
        public DateTime BookingDate { get; set; }
        public int BookingDay { get; set; }
        public string BookingMonth { get; set; }
        public int BookingYear { get; set; }
        /// <summary>
        /// ชื่อ-นามสกุลผู้จอง
        /// </summary>
        public string BookerName { get; set; }
        /// <summary>
        /// ชื่อตำแหน่งผู้จอง
        /// </summary>
        public string BookerPosName { get; set; }
        /// <summary>
        /// ชื่อสำนักของผู้จอง
        /// </summary>
        public string BookerOrgName { get; set; }
        /// <summary>
        /// ส่วนของผู้จอง
        /// </summary>
        public string DivisionName { get; set; }
        /// <summary>
        /// เบอร์โทรศัพท์ผู้จอง
        /// </summary>
        public string BookerPhone { get; set; }
        /// <summary>
        /// จุดหมายการเดินทาง
        /// </summary>
        public string TravelToLocation { get; set; }
        /// <summary>
        /// วัตถุประสงค์การจอง
        /// </summary>
        public string BookingPurpose { get; set; }
        /// <summary>
        /// จำนวนผู้ร่วมเดินทาง
        /// </summary>
        public int Passengers { get; set; }
        public string TravelFromDate { get; set; }
        public string TravelFromTime { get; set; }
        public string TravelToDate { get; set; }
        public string TravelToTime { get; set; }
        /// <summary>
        /// ชื่อ-นามสกุลพนักงานขับรถ
        /// </summary>
        public string DriverName { get; set; }
        /// <summary>
        /// เลขทะเบียนยานพาหนะ
        /// </summary>
        public string VehicleRegistration { get; set; }

        public string DirectorActorName { get; set; }
        //public int DirectorActorCreateOnDay { get; set; }
        //public string DirectorActorCreateOnMonth { get; set; }
        //public int DirectorActorCreateOnYear { get; set; }

        public int DirectorCreateOnDay { get; set; }
        public string DirectorCreateOnMonth { get; set; }
        public int DirectorCreateOnYear { get; set; }

        public int ParcelCreateOnDay { get; set; }
        public string ParcelCreateOnMonth { get; set; }
        public int ParcelCreateOnYear { get; set; }
        public string ParcelActorName { get; set; }
        public string VehicleActorName { get; set; }

        public string RecordCreateOnDate { get; set; }
        public string RecordCreateOnTime { get; set; }
        public decimal StartCarMileage { get; set; }
        public decimal FinishCarMileage { get; set; }
        public decimal TravelDistance { get; set; }
        public int CarInspectionStatus { get; set; }
        public string RecordRemark { get; set; }
        public string RecordDriverName { get; set; }
        public int VehicleBookingRecordId { get; set; }
    }
}
