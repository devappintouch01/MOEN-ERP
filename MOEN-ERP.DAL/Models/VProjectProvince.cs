using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VProjectProvince
{
    public int? Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public string? Code { get; set; }

    public int? BudgetYear { get; set; }

    public string? OrganizationName { get; set; }

    public decimal? TotalRequestAmount { get; set; }

    public string? ProjectName { get; set; }

    public string? StatusName { get; set; }

    public string? Reason { get; set; }

    public string? Objective { get; set; }

    public int? TimeFrame { get; set; }

    public string? ProjectOutput { get; set; }

    public string? ProjectOutcome { get; set; }

    public string? BudgetTypeName { get; set; }

    public string? ProvinceGroup { get; set; }

    public string ProvinceGroupName { get; set; } = null!;

    public string? PlanName { get; set; }

    public string? Development { get; set; }

    public string? ProjectKpiquantity { get; set; }

    public string? ProjectKpiquality { get; set; }

    public string? TargetArea { get; set; }

    public string? MainActivity { get; set; }
}
