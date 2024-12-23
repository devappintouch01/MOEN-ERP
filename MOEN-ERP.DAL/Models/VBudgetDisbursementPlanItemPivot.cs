using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VBudgetDisbursementPlanItemPivot
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? BudgetDisbursementPlanId { get; set; }

    public int? BudgetGovernmentId { get; set; }

    public int? ProjectId { get; set; }

    public int? Year { get; set; }

    public int? BudgetYear { get; set; }

    public int? Quantity { get; set; }

    public bool? IsEditable { get; set; }

    public bool? IsChange { get; set; }

    public int? ChangeNumber { get; set; }

    public int? ParentBudgetDisbursementPlan { get; set; }

    public int? StatusId { get; set; }

    public string TotalPlanAmount { get; set; } = null!;

    public string? OrganizationName { get; set; }

    public decimal? _1 { get; set; }

    public decimal? _2 { get; set; }

    public decimal? _3 { get; set; }

    public decimal? _4 { get; set; }

    public decimal? _5 { get; set; }

    public decimal? _6 { get; set; }

    public decimal? _7 { get; set; }

    public decimal? _8 { get; set; }

    public decimal? _9 { get; set; }

    public decimal? _10 { get; set; }

    public decimal? _11 { get; set; }

    public decimal? _12 { get; set; }
}
