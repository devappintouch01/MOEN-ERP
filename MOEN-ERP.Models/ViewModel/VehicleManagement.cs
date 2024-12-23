using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.VehicleManagement
{
    #region ManageVehicleDetail
    public class ManageVehicleDetailViewModel
    {
        public VVehicle? VVehicle { get; set; }
        public List<MasterVehicleOwnership>? VehicleOwnership { get; set; }
        public EventsModel? EventsModel { get; set; }
        public string[]? FileGuidId { get; set; }
    }
    #endregion

    #region ManageVehicleList
    public class ManageVehicleListViewModel
    {
        public List<VVehicle>? VVehicleList { get; set; }
        //public EventsModel? EventsModel { get; set; }
    }
    #endregion

    #region VehicleTaxPaymentHistory
    public class VehicleTaxPaymentHistoryListViewModel
    {
        public List<VVehicleTaxPaymentHistory>? VehicleTaxPaymentHistoryList { get; set; }
    }
    public class VehicleTaxPaymentHistoryViewModel
    {
        public VVehicleTaxPaymentHistory? VehicleTaxPaymentHistory { get; set; }

    }
    #endregion
    #region VehicleTaxPaymentHistoryDetail
    public class VehicleTaxPaymentDetailListViewModel
    {
        public List<VVehicleTaxPaymentHistoryDetail>? VehicleTaxPaymentHistoryDetailList { get; set; }
        //public EventsModel? EventsModel { get; set; }
    }
    public class VehicleTaxPaymentDetailViewModel
    {
        public VVehicleTaxPaymentHistoryDetail? VehicleTaxPaymentHistoryDetail { get; set; }
        public EventsModel? EventsModel { get; set; }
        public string[]? FileGuidId { get; set; }
    }
    #endregion

    #region VehicleMaintenanceHistory
    public class VehicleMaintenanceHistoryListViewModel
    {
        public List<VVehicleMaintenanceHistory>? VehicleMaintenanceHistoryList { get; set; }
    }
    public class VehicleMaintenanceHistoryViewModel
    {
        public VVehicleMaintenanceHistory? VehicleMaintenanceHistory { get; set; }

    }
    #endregion

    #region VehicleMaintenanceHistoryDetail
    public class VehicleMaintenanceHistoryDetailListViewModel
    {
        public List<VVehicleMaintenanceHistoryDetail>? VehicleMaintenanceHistoryDetailList { get; set; }
        //public EventsModel? EventsModel { get; set; }
    }
    public class VehicleMaintenanceHistoryDetailViewModel
    {
        public VVehicleMaintenanceHistoryDetail? VehicleMaintenanceHistoryDetail { get; set; }
        public EventsModel? EventsModel { get; set; }
        public List<int>? VehicleMaintenanceTypeList { get; set; }
        public string[]? FileGuidId { get; set; }

    }
    #endregion


    #region
    public class ManageDriverListViewModel
    {
        public List<VOfficer>? VOfficerList { get; set; }
        public List<AttachFile>? AttachFile { get; set; }
    }
    #endregion

    #region ManageDriverDetail
    public class ManageDriverDetailViewModel
    {
        public Officer? Officer { get; set; }
        //public List<MasterVehicleOwnership>? VehicleOwnership { get; set; }
        //public EventsModel? EventsModel { get; set; }
        public string[]? FileGuidId { get; set; }
    }
    #endregion


}
