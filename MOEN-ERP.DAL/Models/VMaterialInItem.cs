using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VMaterialInItem
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? MaterialId { get; set; }

    public string? Gpsccode { get; set; }

    public int? ReceiveAmount { get; set; }

    public int? UnitId { get; set; }

    public decimal? UnitPriceNoVat { get; set; }

    public string? IncludeVat { get; set; }

    public double? Vat { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? TotalPrice { get; set; }

    public int MaterialInId { get; set; }

    public string? MaterialName { get; set; }

    public decimal? TotalValue { get; set; }

    public int? OrganizationId { get; set; }

    public string? OrganizationName { get; set; }

    public string? WarehouseLevel { get; set; }

    public string? WarehouseLevelName { get; set; }

    public string? WarehouseName { get; set; }

    public string? UnitName { get; set; }

    public string? Status { get; set; }

    public string? Code { get; set; }

    public DateTime? ReceiveDate { get; set; }

    public int? Running { get; set; }

    public string? ProcurementNumber { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public int? SupplierId { get; set; }

    public string? SupplierName { get; set; }

    public DateTime? ApproveDate { get; set; }

    public int? MaterialInType { get; set; }

    public int? WarehouseId { get; set; }

    public bool? IsPurchasingOrder { get; set; }

    public int? PurchasingWareHouseId { get; set; }
}
