using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VMasterMaterial
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public bool? Active { get; set; }

    public string ActiveName { get; set; } = null!;

    public string? Code { get; set; }

    public string? NameThai { get; set; }

    public string? MaterialDescription { get; set; }

    public int? MaterialGroupId { get; set; }

    public int? UnitId { get; set; }

    public string? UnitName { get; set; }

    public string? MaterialGroupName { get; set; }

    public string? Gpsccode { get; set; }
}
