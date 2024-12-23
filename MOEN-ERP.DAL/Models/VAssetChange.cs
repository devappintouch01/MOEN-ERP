using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAssetChange
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? AssetId { get; set; }

    public string? Code { get; set; }

    public int? ChangeType { get; set; }

    public string ChangeTypeName { get; set; } = null!;

    public DateTime? ChangeDate { get; set; }

    public string? ChangeDetail { get; set; }

    public int? ResponsibleOfficerId { get; set; }

    public string? ResponsibleOfficerName { get; set; }

    public string? ReferenceTable { get; set; }

    public int? ReferenceId { get; set; }

    public string? Remark { get; set; }
}
