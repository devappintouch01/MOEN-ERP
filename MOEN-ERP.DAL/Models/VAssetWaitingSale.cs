using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAssetWaitingSale
{
    public string? AssetCode { get; set; }

    public string? AssetCodeOld { get; set; }

    public string? AssetNumberGfmis { get; set; }

    public int? CostCenterId { get; set; }

    public string? CostCenterName { get; set; }

    public int? OrganizationId { get; set; }

    public string? OrganizationName { get; set; }

    public int? AssetTypeId { get; set; }

    public string? AssetTypeName { get; set; }

    public int? AssetClassId { get; set; }

    public string? AssetClassName { get; set; }

    public string? AssetStatus { get; set; }

    public string AssetStatusName { get; set; } = null!;

    public string? AssetName { get; set; }

    public int? Amount { get; set; }

    public int? LifeTimeDepreciation { get; set; }

    public decimal? Cost { get; set; }

    public decimal? CurrentCost { get; set; }

    public string? StorePlaceName { get; set; }

    public bool? IsUsable { get; set; }

    public string Usable { get; set; } = null!;

    public string? UnusableDetail { get; set; }

    public string AssetTypeGroup { get; set; } = null!;

    public string Cause { get; set; } = null!;

    public string CommentCommittee { get; set; } = null!;
}
