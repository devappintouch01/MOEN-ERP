using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VMasterOutputCode
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public bool? Active { get; set; }

    public string ActiveName { get; set; } = null!;

    public DateTime? EffectiveFromDate { get; set; }

    public DateTime? EffectiveToDate { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Abbreviation { get; set; }

    public int? BudgetYear { get; set; }

    public int? StrategicPlanCodeId { get; set; }

    public string? OutputType { get; set; }

    public string? Target { get; set; }

    public string? Kpi { get; set; }

    public int? StrategyCodeId { get; set; }

    public string? StrategicPlanName { get; set; }

    public string? StrategicName { get; set; }

    public string OutputTypeName { get; set; } = null!;
}
