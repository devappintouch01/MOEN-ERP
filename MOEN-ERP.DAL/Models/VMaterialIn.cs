using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VMaterialIn
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public string? Code { get; set; }

    public DateTime? ReceiveDate { get; set; }

    public int? Running { get; set; }

    public string? ProcurementNumber { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public int? SupplierId { get; set; }

    public string? SupplierName { get; set; }

    public string? Status { get; set; }

    public string StatusName { get; set; } = null!;

    public DateTime? ApproveDate { get; set; }

    public int? MaterialInType { get; set; }

    public int? WarehouseId { get; set; }

    public bool? IsPurchasingOrder { get; set; }

    public int? PurchasingWareHouseId { get; set; }

    public string? WarehouseLevel { get; set; }

    public int? OrganizationId { get; set; }

    public decimal? TotalValue { get; set; }
}
