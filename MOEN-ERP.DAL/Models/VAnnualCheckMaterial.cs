using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAnnualCheckMaterial
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? AnnualCheckOrganizationId { get; set; }

    public int? WarehouseId { get; set; }

    public int? MaterialId { get; set; }

    public int? UnitId { get; set; }

    public int? Available { get; set; }

    public bool? IsCheck { get; set; }

    public string? CheckStatus { get; set; }

    public string? Remark { get; set; }

    public string? MaterialName { get; set; }

    public string? UnitName { get; set; }
}
