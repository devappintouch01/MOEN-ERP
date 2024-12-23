using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VMasterAssetType
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

    public decimal? Depreciation { get; set; }

    public int? LifeTimeMax { get; set; }

    public int? LifeTimeMin { get; set; }

    public int? LifeTimeUse { get; set; }

    public int? SequenceNumber { get; set; }
}
