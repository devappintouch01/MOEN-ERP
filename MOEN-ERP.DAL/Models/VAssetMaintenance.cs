using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAssetMaintenance
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? AssetId { get; set; }

    public string? Code { get; set; }

    public DateTime? RequestDate { get; set; }

    public DateTime? ReceiveDate { get; set; }

    public string? MaintenanceDetail { get; set; }

    public int? SupplierId { get; set; }

    public string? SupplierName { get; set; }

    public decimal? Cost { get; set; }

    public int? AssetMaintenanceFormId { get; set; }

    public string? Remark { get; set; }

    public decimal? TotalCost { get; set; }

    public int? Amount { get; set; }

    public DateTime? ApproveDate { get; set; }

    public DateTime? AccountingDate { get; set; }

    public long? RowNumber { get; set; }
}
