using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VBudgetAllocateList
{
    public int? BudgetYear { get; set; }

    public int? BudgetTypeId { get; set; }

    public decimal? TotalRequestAmount { get; set; }

    public decimal? TotalAllocateAmount { get; set; }

    public decimal? TotalTransferAmount { get; set; }

    public decimal? TotalReceiveAmount { get; set; }

    public decimal? TotalPaymentAmount { get; set; }

    public decimal? TotalObligationAmount { get; set; }

    public decimal? TotalBalanceAmount { get; set; }
}
