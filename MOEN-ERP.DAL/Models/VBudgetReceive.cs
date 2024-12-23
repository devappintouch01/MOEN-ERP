using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VBudgetReceive
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? OrganizationId { get; set; }

    public int? BudgetGovernmentId { get; set; }

    public int? ProjectId { get; set; }

    public decimal? TotalAllocateAmount { get; set; }

    public decimal? TotalTransferAmount { get; set; }

    public decimal? TotalReceiveAmount { get; set; }

    public decimal? TotalPaymentAmount { get; set; }

    public decimal? TotalObligationAmount { get; set; }

    public decimal? TotalBalanceAmount { get; set; }

    public string? OrganizationName { get; set; }

    public string? AreaCode { get; set; }

    public int? BudgetYear { get; set; }

    public string? BudgetExpenseTypeName { get; set; }

    public int? BudgetFormTypeId { get; set; }

    public int? BudgetExpenseTypeId { get; set; }

    public int? ExpenseTypeId { get; set; }

    public string? ProjectName { get; set; }
}
