using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAnnualCheckAssetReport
{
    public int Id { get; set; }

    public int? AnnualCheckOrganizationId { get; set; }

    public int? AssetId { get; set; }

    public string? Code { get; set; }

    public string? AssetNumberGfmis { get; set; }

    public string? AssetName { get; set; }

    public int? OrganizationId { get; set; }

    public int? StorePlaceId { get; set; }

    public string? OrganizationName { get; set; }

    public string? StorePlaceName { get; set; }

    public DateTime? ApproveDate { get; set; }

    public string? AssetCategory { get; set; }

    public bool? IsBelow { get; set; }

    public string Available { get; set; } = null!;

    public decimal? Cost { get; set; }

    public bool? IsUsable { get; set; }

    public bool? IsReturn { get; set; }

    public string Usable { get; set; } = null!;

    public string? ReturnReasonDetail { get; set; }
}
