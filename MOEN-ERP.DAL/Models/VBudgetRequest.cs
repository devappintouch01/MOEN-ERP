using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VBudgetRequest
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

    public int? BudgetTypeId { get; set; }

    public int? OrganizationId { get; set; }

    public decimal? TotalRequestAmount { get; set; }

    public decimal? TotalAllocateAmount { get; set; }

    public decimal? TotalTransferAmount { get; set; }

    public decimal? TotalReceiveAmount { get; set; }

    public decimal? TotalPaymentAmount { get; set; }

    public decimal? TotalObligationAmount { get; set; }

    public decimal? TotalBalanceAmount { get; set; }

    public string? StatusName { get; set; }

    public string? OrganizationName { get; set; }

    public string? BudgetTypeName { get; set; }
}
