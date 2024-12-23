using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VProjectAssetItem
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? ProjectId { get; set; }

    public int? ProjectAssetId { get; set; }

    public string? AssetName { get; set; }

    public bool? IsUseStandardPrice { get; set; }

    public int? StandardPriceId { get; set; }

    public int? QuantityUnit { get; set; }

    public decimal? UnitPrice { get; set; }

    public int? UnitId { get; set; }

    public decimal? TotalAmount { get; set; }

    public bool? IsReplace { get; set; }

    public string? UnitName { get; set; }
}
