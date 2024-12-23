using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAnnualCheckCommittee
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? AnnualCheckId { get; set; }

    public int? OrganizationId { get; set; }

    public int? OfficerId { get; set; }

    public string? CommitteePosition { get; set; }

    public bool? IsApprove { get; set; }

    public DateTime? ApproveDate { get; set; }

    public string? OfficerName { get; set; }

    public string? OrganizationName { get; set; }

    public string? Abbreviation { get; set; }

    public string CommitteePositionName { get; set; } = null!;
}
