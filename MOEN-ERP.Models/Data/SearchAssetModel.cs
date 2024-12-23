using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Data
{
    public class SearchAssetModel
    {
        public string? Code { get; set; }
        public string? AssetNumberGFMIS { get; set; }
        public int? AssetTypeId { get; set; }
        public int? AssetClassId { get; set; }
        public int? OrganizationId { get; set; }
        public int? CostCenterId { get; set; }
        public DateTime? ReceiveDateFrom { get; set; }
        public DateTime? ReceiveDateTo { get; set; }
        public string? AssetName { get; set; }
        public int? StorePlaceId { get; set; }
        public string? AssetStatus { get; set; }
        public int? BudgetYear { get; set; }
        public string? IsExpire { get; set; }
        public string? IsBelow { get; set; }
        public string? IsAssetNumberGFMIS { get; set; }
        public string? AssetCategory { get; set; }
    }
}
