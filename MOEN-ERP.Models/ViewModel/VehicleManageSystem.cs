using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.VehicleManageSystem
{


    public class MasterVehicleModelViewModel
    {
        public MasterVehicleModel? MasterVehicleModel { get; set; }
        public EventsModel EventsModel { get; set; }
    }


    public class VehicleModelListViewModel
    {
        public List<VVehicleBrandModel>? VehicleBrandModel { get; set; }
    }

    #region MasterVehicleType
    public class MasterVehicleTypeViewModel
    {
        public MasterVehicleType? MasterVehicleType { get; set; }
        public EventsModel EventsModel { get; set; }
    }

    public class MasterVehicleTypeListViewModel
    {
        public List<MasterVehicleType>? MasterVehicleTypeList { get; set; }
       
    }
    #endregion

    #region MasterFuelType
    public class MasterFuelTypeViewModel
    {
        public MasterFuelType? MasterFuelType { get; set; }
        public EventsModel EventsModel { get; set; }
    }

    public class MasterFuelTypeListViewModel
    {
        public List<MasterFuelType>? MasterFuelTypeList { get; set; }

    }
    #endregion

    #region MasterGarage
    public class MasterGarageViewModel
    {
        public MasterGarage? MasterGarage { get; set; }
        public EventsModel EventsModel { get; set; }
    }

    public class MasterGarageListViewModel
    {
        public List<MasterGarage>? MasterGarageList { get; set; }

    }
    #endregion

    #region MasterVehicleMaintenanceType
    public class MasterVehicleMaintenanceTypeViewModel
    {
        public MasterVehicleMaintenanceType? MasterVehicleMaintenanceType { get; set; }
        public EventsModel EventsModel { get; set; }
    }

    public class MasterVehicleMaintenanceTypeListViewModel
    {
        public List<MasterVehicleMaintenanceType>? MasterVehicleMaintenanceTypeList { get; set; }

    }
    #endregion

    #region MasterVehicleBrand
    public class MasterVehicleBrandViewModel
    {
        public MasterVehicleBrand? MasterVehicleBrand { get; set; }
        public EventsModel EventsModel { get; set; }
    }

    public class MasterVehicleBrandListViewModel
    {
        public List<MasterVehicleBrand>? MasterVehicleBrandList { get; set; }

    }
    #endregion


    #region MasterFuelCode
    public class MasterFuelCodeViewModel
    {
        public MasterFuelCode? MasterFuelCode { get; set; }
        public EventsModel EventsModel { get; set; }
    }

    #endregion

}
