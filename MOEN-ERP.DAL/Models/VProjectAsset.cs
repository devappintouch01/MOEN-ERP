using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VProjectAsset
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? ProjectId { get; set; }

    public int? AssetClassId { get; set; }

    public int? AssetTypeId { get; set; }

    public string? AssetClassName { get; set; }

    public string? AssetTypeName { get; set; }

    public string? ProjectName { get; set; }

    public int? BudgetGovernmentId { get; set; }

    public int? BudgetRequestId { get; set; }

    public int? BudgetTypeId { get; set; }

    public int? BudgetYear { get; set; }

    public string? Code { get; set; }

    public int? ProcurementMethodId { get; set; }

    public string? ProcurementPlanRemark { get; set; }

    public string? Reason { get; set; }

    public decimal? TotalAllocateAmount { get; set; }

    public decimal? TotalRequestAmount { get; set; }

    public decimal? TotalReceiveAmount { get; set; }
}
