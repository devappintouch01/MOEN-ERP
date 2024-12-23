using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VMaterialSafetyStock
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? WarehouseId { get; set; }

    public int? MaterialId { get; set; }

    public int? MinStock { get; set; }

    public int? MaxStock { get; set; }

    public int? DrawableAmount { get; set; }

    public string? MaterialName { get; set; }

    public int? MaterialGroupId { get; set; }
}
