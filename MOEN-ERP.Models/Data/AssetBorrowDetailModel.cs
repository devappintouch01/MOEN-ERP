using MOEN_ERP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Data
{
    public class AssetBorrowDetailModel
    {
        public AssetBorrow assetBorrow { get; set; }    
        public List<VAssetBorrowItem> vAssetBorrowItem { get; set; }
        public List<string>? FileGuidId { get; set; }
        public string guidPage { get; set; }
        public bool changeData { get; set; }
    }
}
