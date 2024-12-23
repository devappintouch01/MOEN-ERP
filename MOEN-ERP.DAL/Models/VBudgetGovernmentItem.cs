using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VBudgetGovernmentItem
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public string? BudgetStatus { get; set; }

    public string? Code { get; set; }

    public int? BudgetYear { get; set; }

    public int? Running { get; set; }

    public int? OrganizationId { get; set; }

    public int? BudgetGovernmentId { get; set; }

    public int? BudgetFormTypeId { get; set; }

    public int? BudgetExpenseTypeId { get; set; }

    public int? ActivityCodeId { get; set; }

    public decimal? ExpenseRate { get; set; }

    public int? Quantity { get; set; }

    public int? ExpenseRateUnitId { get; set; }

    public int? QuantityUnitId { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? OrganizationName { get; set; }

    public string? BudgetFormTypeName { get; set; }

    public string? BudgetExpenseTypeName { get; set; }

    public string? ActivityCodeName { get; set; }

    public string? ExpenseRateUnitName { get; set; }

    public string? QuantityUnitName { get; set; }
}
