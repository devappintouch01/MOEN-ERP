using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAssetRequisitionItem
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? AssetRequisitionId { get; set; }

    public int? AssetId { get; set; }

    public string? Remark { get; set; }

    public string? AssetName { get; set; }

    public string? Code { get; set; }

    public string? AssetNumberGfmis { get; set; }

    public int? RequestAmount { get; set; }
}
