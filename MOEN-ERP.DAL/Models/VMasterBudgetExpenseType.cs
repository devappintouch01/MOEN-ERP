using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VMasterBudgetExpenseType
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public bool? Active { get; set; }

    public string? Name { get; set; }

    public int? BudgetTypeId { get; set; }

    public int? ExpenseTypeId { get; set; }

    public int? StrategyCodeId { get; set; }

    public int? StrategicPlanCodeId { get; set; }

    public int? OutputCodeId { get; set; }

    public int? BudgetExpenseLevel { get; set; }

    public long? ParentId { get; set; }

    public bool? IsParent { get; set; }

    public int? MoneySourceId { get; set; }

    public string ActiveName { get; set; } = null!;

    public string? StrategicName { get; set; }

    public string? StrategicPlanName { get; set; }

    public string? OutputCodeName { get; set; }

    public string? ExpenseTypeName { get; set; }

    public string? MoneySourceName { get; set; }
}
