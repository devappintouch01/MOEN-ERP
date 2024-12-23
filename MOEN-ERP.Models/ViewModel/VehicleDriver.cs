using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.VehicleDriver
{
    //public class VehicleDriver
    //{
    //}

    public class DriverListViewModel
    {
        public List<VOfficer>? VOfficerList { get; set; }
        public List<AttachFile>? AttachFileList { get; set; }
        public PaginationModel? PaginationResultModel { get; set; }
    }

}
