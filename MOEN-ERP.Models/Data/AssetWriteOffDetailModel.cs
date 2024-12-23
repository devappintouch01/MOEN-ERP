using MOEN_ERP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Data
{
    public class AssetWriteOffDetailModel
    {
        public AssetWriteOff  assetWriteOff { get; set; }
        public List<VAssetWriteOffItem> vAssetWriteOffItems { get; set; }
        public List<string>? FileGuidId { get; set; }
        public string guidPage { get; set; }
        public bool changeData { get; set; }
        public int? userId { get; set; }
    }
}
