using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VMasterStandardPrice
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public string? Name { get; set; }

    public decimal? UnitPrice { get; set; }

    public int? UnitId { get; set; }

    public int? AssetClassId { get; set; }

    public int? AssetTypeId { get; set; }

    public bool? Active { get; set; }

    public string? UnitName { get; set; }
}
