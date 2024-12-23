using MOEN_ERP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel
{ 

    public class MasterWarehouseDetail
    {
        public MasterWarehouse MasterWarehouse { get; set; }

        public List<VMaterialSafetyStock>? listVMaterialSafetyStock { get; set; }

    }
}
