using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class ZLFlow
{
    public long Id { get; set; }

    public string Version { get; set; } = null!;

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Xml { get; set; }

    public DateTime? ExpireTime { get; set; }

    public string? Status { get; set; }

    public int? CreateBy { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public DateTime? CreateOn { get; set; }
}
