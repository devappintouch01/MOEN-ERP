using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAssetWriteOff
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public string? WriteOffStatus { get; set; }

    public string? Code { get; set; }

    public int? BudgetYear { get; set; }

    public int? Running { get; set; }

    public DateTime? WriteOffDate { get; set; }

    public string? WriteOffType { get; set; }

    public string? WriteOffDetail { get; set; }

    public string? ReferenceDocument { get; set; }

    public DateTime? ReferenceDate { get; set; }

    public string WriteOffStatusName { get; set; } = null!;

    public string WriteOffTypeName { get; set; } = null!;
}
