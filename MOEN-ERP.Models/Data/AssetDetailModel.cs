using MOEN_ERP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Data
{
    public class AssetDetailModel
    {
        public Asset asset { get; set; }
        public List<string>? FileGuidId { get; set; }
        public List<VAssetRelation>? vAssetRelations { get; set; }
        public List<VAssetMaintenance>? vAssetMaintenances { get; set; }
        public List<VAssetChange>? vAssetChanges{ get; set; }
        public List<VAsset>? vAsset { get; set; }
        public List<FN_GetAssetDepreciation>? assetDepreciation { get; set; }
        public string guidPage { get; set; }
        public bool changeData { get; set; }
        public int copy { get; set; }
        public int userId { get; set; }
    }

    public class FN_GetAssetDepreciation
    {
        public int? AssetId { get; set; }
        public string? OrganizationName { get; set; }
        public string? AssetTypeName { get; set; }
        public string? Code { get; set; }
        public string? AssetNumberGFMIS { get; set; }
        public string? Spec { get; set; }
        public string? Model { get; set; }
        public string? StorePlaceName { get; set; }
        public string? SupplierName { get; set; }
        public string? SupplierFullAddress { get; set; }
        public string? SupplierPhone { get; set; }
        public string? AssetBudgetTypeName { get; set; }
        public string? AssetAcquisitionTypeName { get; set; }
        public DateTime? OnDate { get; set; }
        public string? DocumentCode { get; set; }
        public string? AssetName { get; set; }
        public string? Detail { get; set; }
        public int? Amount { get; set; }
        public decimal? Cost { get; set; }
        public decimal? TotalCost { get; set; }
        public int? LifeTimeDepreciation { get; set; }
        public decimal? Depreciation { get; set; }
        public decimal? YearDepreciation { get; set; }
        public decimal? AccumDepreciation { get; set; }
        public decimal? NetValue { get; set; }
        public string? Remark { get; set; }
    }

    public class FN_CreateAssetDepreciation
    {
        public int? AssetId { get; set; }
        public int? DayNumber { get; set; }
        public int? YearRunning { get; set; }
        public int? YearDepreciation { get; set; }
        public double? AccumDepreciation { get; set; }
        public double? NetValue { get; set; }
        public DateTime? DepreciationDate { get; set; }
    }
}
