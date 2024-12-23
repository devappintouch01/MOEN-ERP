using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VProjectProcurementPlanItem
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? ProjectId { get; set; }

    public int? ProcurementMethodStepId { get; set; }

    public int? ProcurementMethodId { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    public int? BudgetYear { get; set; }

    public string? ProcurementMethodName { get; set; }

    public string? ProcurementMethodStepName { get; set; }

    public string? MonthName { get; set; }

    public string? ProcurementPlanRemark { get; set; }

    public string? ProjectName { get; set; }

    public decimal? TotalAllocateAmount { get; set; }
}
