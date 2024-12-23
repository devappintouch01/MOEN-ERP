using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAsset
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public string? Code { get; set; }

    public string? CodeOld { get; set; }

    public string? AssetNumberGfmis { get; set; }

    public int? OrganizationId { get; set; }

    public int? CostCenterId { get; set; }

    public string? AssetCategory { get; set; }

    public int? AssetClassId { get; set; }

    public int? AssetTypeId { get; set; }

    public string? AssetName { get; set; }

    public string? AssetStatus { get; set; }

    public int? LifeTimeUse { get; set; }

    public int? LifeTimeDepreciation { get; set; }

    public decimal? Depreciation { get; set; }

    public decimal? Cost { get; set; }

    public decimal? ScrapValue { get; set; }

    public DateTime? ApproveDate { get; set; }

    public DateTime? ReceiveDate { get; set; }

    public int? UnitId { get; set; }

    public string? Brand { get; set; }

    public string? Model { get; set; }

    public string? Spec { get; set; }

    public string? AssetDetail { get; set; }

    public string? SerialNumber { get; set; }

    public string? LicenseNumber { get; set; }

    public string? EngineNumber { get; set; }

    public string? ChassisNumber { get; set; }

    public int? CarSeats { get; set; }

    public int? FuelTypeId { get; set; }

    public int? LandTypeId { get; set; }

    public string? BuildingName { get; set; }

    public string? Ipaddress { get; set; }

    public string? ProviderName { get; set; }

    public bool? IsBelow { get; set; }

    public bool? IsSet { get; set; }

    public string? SetName { get; set; }

    public int? MainAssetId { get; set; }

    public int? Child { get; set; }

    public bool? IsChild { get; set; }

    public int? Running { get; set; }

    public int? AssetAcquisitionTypeId { get; set; }

    public int? AssetBudgetTypeId { get; set; }

    public int? BudgetYear { get; set; }

    public int? DocumentTypeId { get; set; }

    public string? DocumentNumber { get; set; }

    public DateTime? DocumentDate { get; set; }

    public int? SupplierId { get; set; }

    public string? SupplierName { get; set; }

    public string? SupplierFullAddress { get; set; }

    public string? SupplierPhone { get; set; }

    public DateTime? WarrantyStartDate { get; set; }

    public DateTime? WarrantyEndDate { get; set; }

    public int? WarrantyTime { get; set; }

    public string? WarrantyPeriod { get; set; }

    public string? Remark { get; set; }

    public int? StorePlaceId { get; set; }

    public string? StorePlaceDetail { get; set; }

    public int? RfidtagNumber { get; set; }

    public bool? IsUsable { get; set; }

    public bool? IsInMa { get; set; }

    public int? ProcurementId { get; set; }

    public int? ProcurementAssetItemId { get; set; }

    public string? ProcurementCode { get; set; }

    public DateTime? ProcurementStartDate { get; set; }

    public DateTime? ProcurementEndDate { get; set; }

    public int? CurrentResponsibleOfficerId { get; set; }

    public int? CurrentBorrowerOfficerId { get; set; }

    public string? AssetTypeName { get; set; }

    public string? AssetClassName { get; set; }

    public string AssetStatusName { get; set; } = null!;

    public string? CostCenterName { get; set; }

    public string? StorePlaceName { get; set; }

    public string? Qrcode { get; set; }

    public string? Barcode { get; set; }

    public string IsExpire { get; set; } = null!;

    public string IsAssetNumberGfmis { get; set; } = null!;

    public string? OrganizationName { get; set; }

    public string? UnitName { get; set; }

    public string? FuelTypeName { get; set; }

    public string? AssetAcquisitionTypeName { get; set; }

    public string? AssetBudgetTypeName { get; set; }

    public string? DocumentTypeName { get; set; }

    public string? ProcurementName { get; set; }

    public string? LandTypeName { get; set; }

    public string? AssetClassCode { get; set; }

    public string? AssetTypeCode { get; set; }

    public int? GroupRunning { get; set; }
}
