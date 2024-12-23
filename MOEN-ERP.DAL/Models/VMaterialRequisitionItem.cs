using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VMaterialRequisitionItem
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? RequisitionId { get; set; }

    public int? MaterialId { get; set; }

    public string? Gpsccode { get; set; }

    public int? RequestAmount { get; set; }

    public int? ReceiveAmount { get; set; }

    public int? UnitId { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? TotalPrice { get; set; }

    public string? Remark { get; set; }

    public int? MaterialInItemId { get; set; }

    public int? MaterialStockId { get; set; }

    public string? MaterialName { get; set; }

    public string? UnitName { get; set; }

    public int? Available { get; set; }
}
