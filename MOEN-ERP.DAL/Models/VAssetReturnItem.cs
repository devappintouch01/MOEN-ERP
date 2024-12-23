using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAssetReturnItem
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? AssetReturnId { get; set; }

    public int? AssetId { get; set; }

    public bool? IsUsable { get; set; }

    public string? ReturnDetail { get; set; }

    public bool? Ischeck { get; set; }

    public string? CheckDatail { get; set; }

    public int? Amount { get; set; }

    public decimal? Cost { get; set; }

    public string? AssetName { get; set; }

    public string? Code { get; set; }

    public string? AssetNumberGfmis { get; set; }

    public int? UnitId { get; set; }

    public string? UnitName { get; set; }

    public string Usable { get; set; } = null!;
}
