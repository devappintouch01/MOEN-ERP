using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VProject
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public string? Code { get; set; }

    public int? BudgetYear { get; set; }

    public int? Running { get; set; }

    public string? ProjectName { get; set; }

    public int? OrganizationId { get; set; }

    public bool? IsUseBudget { get; set; }

    public int? BudgetTypeId { get; set; }

    public int? BudgetGovernmentId { get; set; }

    public int? FundId { get; set; }

    public bool? IsManageByHq { get; set; }

    public int? ManageOrganizationId { get; set; }

    public string? Reason { get; set; }

    public string? Objective { get; set; }

    public string? ProjectTarget { get; set; }

    public string? ProjectKpi { get; set; }

    public string? ProjectPlace { get; set; }

    public int? TimeFrame { get; set; }

    public string? Achievement { get; set; }

    public string? ProjectOutput { get; set; }

    public string? ProjectOutcome { get; set; }

    public string? OperationType { get; set; }

    public int? BudgetRequestId { get; set; }

    public string? ProcurementPlanRemark { get; set; }

    public string OperationTypeName { get; set; } = null!;

    public int? ProcurementMethodId { get; set; }

    public string? OrganizationName { get; set; }

    public string? ManageOrganizationName { get; set; }

    public string? BudgetTypeName { get; set; }

    public string? FundName { get; set; }

    public string? ProcurementMethodName { get; set; }

    public int? BudgetRequestTypeId { get; set; }

    public decimal? TotalRequestAmount { get; set; }

    public decimal? TotalAllocateAmount { get; set; }

    public decimal? TotalReceiveAmount { get; set; }

    public int? StatusId { get; set; }

    public string? StatusName { get; set; }
}
