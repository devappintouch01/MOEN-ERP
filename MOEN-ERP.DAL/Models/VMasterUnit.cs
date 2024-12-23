using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VMasterUnit
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public bool? Active { get; set; }

    public string ActiveName { get; set; } = null!;

    public string? NameThai { get; set; }

    public bool? Egpactive { get; set; }

    public int? Egpid { get; set; }
}
