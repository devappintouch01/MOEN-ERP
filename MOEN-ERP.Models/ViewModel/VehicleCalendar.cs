using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.VehicleCalendar
{
    //internal class VehicleCalendar
    //{
    //}

    public class VehicleCalendarSlideImage
    { 
        public int? VehicleId { get; set; }
        public string? VehicleDetail { get; set; }
        public string? VehicleColor { get; set; }
        public Guid? RowGuid { get; set; }
        //public string? ReferenceTable { get; set; }
    }


    public class VehicleCalendarCarDetail
    {
        public VVehicle? Vehicle { get; set; }
        public List<AttachFile>? AttachFileList { get; set; }
    }


    public class VehicleCalendarCarHistory
    { 
        public VVehicle? Vehicle { get; set; }
        public List<VVehicleDashboard>? VehicleBookingList { get; set; }
    }

    public class VehicleCalendarCarTaxPaymentHistory
    {
        public VVehicle? Vehicle { get; set; }
        public List<VVehicleTaxPaymentHistoryDetail>? VehicleTaxPaymentList { get; set; }
    }

    public class VehicleCalendarCarMaintenanceHistory
    {
        public VVehicle? Vehicle { get; set; }
        public List<VVehicleMaintenanceHistoryDetail>? VehicleMaintenanceList { get; set; }
    }

}
