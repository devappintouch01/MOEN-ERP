using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAssetMaintenanceFormItem
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? AssetMaintenanceFormId { get; set; }

    public int? AssetId { get; set; }

    public string? MaintenanceDetail { get; set; }

    public bool? Ischeck { get; set; }

    public string? CheckDatail { get; set; }

    public string? Code { get; set; }

    public string? AssetNumberGfmis { get; set; }

    public string? AssetName { get; set; }
}
