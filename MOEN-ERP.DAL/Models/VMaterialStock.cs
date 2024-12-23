using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VMaterialStock
{
    public int? Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? MaterialId { get; set; }

    public DateTime? ReceiveDate { get; set; }

    public int? StockIn { get; set; }

    public int? StockOut { get; set; }

    public int? Available { get; set; }

    public int? UnitId { get; set; }

    public int? WarehouseId { get; set; }

    public int? RequisitionId { get; set; }

    public int? MaterialInItemId { get; set; }

    public int? RequisitionItemId { get; set; }

    public int? OrganizationId { get; set; }

    public string? UnitName { get; set; }

    public string? MaterialName { get; set; }

    public decimal? UnitPriceNoVat { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? TotalPrice { get; set; }

    public string? Gpsccode { get; set; }

    public int? MaterialGroupId { get; set; }

    public string? WarehouseLevel { get; set; }
}
