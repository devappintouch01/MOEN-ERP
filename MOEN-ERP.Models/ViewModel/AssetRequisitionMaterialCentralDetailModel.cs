using MOEN_ERP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel
{
    public class AssetRequisitionMaterialCentralDetailModel
    {
        public MaterialRequisition materialRequisition { get; set; }
        public List<VMaterialRequisitionItem>? lstVMaterialRequisitionItem { get; set; }
        public List<string>? FileGuidId { get; set; }
        public string? statusName { get; set; }
        public string? guidPage { get; set; }

    }

    public class AssetRequisitionMaterialCentralDetailApprove
    {      
        public List<MaterialStock>? lstMaterialStockUpdate { get; set; }
        public List<MaterialStock>? lstMaterialStockInsert { get; set; }
        public List<MaterialStockMovement>? lstMaterialStockMovement { get; set; }


    }
}
