using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VProjectExpensesItem
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? ProjectId { get; set; }

    public string? ItemDetail { get; set; }

    public decimal? TotalAmount { get; set; }

    public int? Quantity { get; set; }

    public int? QuantityUnit { get; set; }

    public int? QuantityUnitId { get; set; }

    public decimal? ExpenseRate { get; set; }

    public int? ExpenseRateUnitId { get; set; }

    public string? QuantityUnitName { get; set; }

    public string? ExpenseRateUnitName { get; set; }
}
