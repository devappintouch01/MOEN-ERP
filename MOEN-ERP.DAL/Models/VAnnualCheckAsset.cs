using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAnnualCheckAsset
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? AnnualCheckOrganizationId { get; set; }

    public int? AssetId { get; set; }

    public int? OldOrganizationId { get; set; }

    public int? OldStorePlaceId { get; set; }

    public string? OldStorePlaceDetail { get; set; }

    public bool? IsCheck { get; set; }

    public string? CheckStatus { get; set; }

    public bool? IsUsable { get; set; }

    public string? UnusableDetail { get; set; }

    public bool? IsChangeStorePlace { get; set; }

    public int? NewOrganizationId { get; set; }

    public int? NewStorePlaceId { get; set; }

    public string? NewStorePlaceDetail { get; set; }

    public string? NewOrganizationName { get; set; }

    public string? NewStorePlaceName { get; set; }

    public string? OldOrganizationName { get; set; }

    public string? OldStorePlaceName { get; set; }

    public string? AssetCode { get; set; }

    public string? AssetNumberGfmis { get; set; }

    public string? AssetName { get; set; }

    public int? OrganizationId { get; set; }

    public int? StorePlaceId { get; set; }
}
