using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VProjectSupplierItem
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? ProjectId { get; set; }

    public int? ProjectSupplierId { get; set; }

    public int? ProjectAssetItemId { get; set; }

    public decimal? TotalAmount { get; set; }

    public int? SupplierId { get; set; }

    public string? SupplierName { get; set; }
}
