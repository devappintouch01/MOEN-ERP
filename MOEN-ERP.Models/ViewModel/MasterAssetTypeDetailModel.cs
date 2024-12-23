using MOEN_ERP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel
{
    public class MasterAssetTypeDetailModel
    {
        public MasterAssetType MasterAssetType { get; set; }

        public List<MasterAssetTypeSub>? ListMasterAssetTypeSub { get; set; }

        public MasterAssetTypeSub MasterAssetTypeSub { get; set; }

        public string? listDelSubId { get; set; }

        public Boolean? HideAssetTypeModal { get; set; }

    }
}
