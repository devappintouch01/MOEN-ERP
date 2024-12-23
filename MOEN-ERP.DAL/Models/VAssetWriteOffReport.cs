using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAssetWriteOffReport
{
    public int? Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public string? Code { get; set; }

    public int? BudgetYear { get; set; }

    public int? Running { get; set; }

    public int? DestinationOrganizationId { get; set; }

    public DateTime? WriteOffDate { get; set; }

    public string? OrganizationName { get; set; }

    public string? OrganizationCode { get; set; }

    public string? CostCenterCode { get; set; }

    public DateTime? ReceiveDate { get; set; }

    public string? AssetNumberGfmis { get; set; }

    public string? AssetName { get; set; }

    public decimal? Cost { get; set; }

    public string? DestinationOrganizationName { get; set; }

    public string? DestinationOrganizationCode { get; set; }

    public string? DestinationCostCenterCode { get; set; }
}
