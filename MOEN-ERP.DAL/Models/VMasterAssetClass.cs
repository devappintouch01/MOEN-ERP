using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VMasterAssetClass
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

    public string? NameThai { get; set; }

    public int? AssetTypeId { get; set; }

    public int? SequenceNumber { get; set; }

    public string? AssetTypeName { get; set; }
}
