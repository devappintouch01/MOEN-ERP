using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VBudgetDisbursementPlanItem
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? BudgetDisbursementPlanId { get; set; }

    public int? BudgetGovernmentId { get; set; }

    public int? ProjectId { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    public int? BudgetYear { get; set; }

    public int? Quantity { get; set; }

    public decimal? PlanAmount { get; set; }

    public bool? IsEditable { get; set; }

    public string? MonthName { get; set; }

    public int? Period { get; set; }

    public string? DisbursementDetail { get; set; }

    public string? Condition { get; set; }

    public decimal? AllocateAmount { get; set; }
}
