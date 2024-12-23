using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAnnualCheck
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public string? AnnualCheckStatus { get; set; }

    public string? Code { get; set; }

    public int? BudgetYear { get; set; }

    public int? Running { get; set; }

    public DateTime? AnnualCheckFromDate { get; set; }

    public DateTime? AnnualCheckToDate { get; set; }

    public string? Remark { get; set; }

    public bool? IsCreate { get; set; }

    public bool? IsApprove { get; set; }

    public DateTime? ApproveDate { get; set; }

    public string AnnualCheckStatusName { get; set; } = null!;
}
