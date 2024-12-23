using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VBudgetDisbursementPlan
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? StatusId { get; set; }

    public string? Code { get; set; }

    public int? BudgetYear { get; set; }

    public int? Running { get; set; }

    public int? OrganizationId { get; set; }

    public int? BudgetRequestId { get; set; }

    public bool? IsChange { get; set; }

    public int? ChangeNumber { get; set; }

    public int? ParentBudgetDisbursementPlan { get; set; }

    public string? StatusName { get; set; }

    public string? OrganizationName { get; set; }
}
