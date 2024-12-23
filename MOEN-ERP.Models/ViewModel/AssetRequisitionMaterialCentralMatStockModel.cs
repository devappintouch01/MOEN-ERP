using MOEN_ERP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel
{
    public class AssetRequisitionMaterialCentralMatStockModel
    {
        public List<VMaterialStock>? lstVMaterialStock { get; set; }   

        public string[] arrayRequisitionMaterialItem { get; set; }

        public int RequisitionId { get; set; }

        public string? guidPage { get; set; }


    }
}
