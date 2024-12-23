using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAnnualCheckOrganizationReport
{
    public int Id { get; set; }

    public int? BudgetYear { get; set; }

    public DateTime? ApproveDate { get; set; }

    public int? AnnualCheckId { get; set; }

    public int? OrganizationId { get; set; }

    public int? TotalBuilding { get; set; }

    public int? TotalUnusableBuilding { get; set; }

    public int? TotalDurable { get; set; }

    public int? TotalUnusableDurable { get; set; }

    public int? TotalMaterial { get; set; }

    public int? TotalMaterialAvailable { get; set; }

    public int? TotalUnusableMaterial { get; set; }

    public int? TotalUnusableMaterialAvailable { get; set; }

    public int? TotalDurableIsBelow { get; set; }

    public int? TotalUnusableDurableIsBelow { get; set; }

    public string? OrganizationName { get; set; }
}
