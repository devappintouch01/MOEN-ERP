using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAssetTransferItem
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? AssetTransferId { get; set; }

    public int? AssetId { get; set; }

    public string? Code { get; set; }

    public string? AssetNumberGfmis { get; set; }

    public string? AssetName { get; set; }

    public decimal? Cost { get; set; }

    public string? TransferDetail { get; set; }

    public string? OldAssetCode { get; set; }

    public string? OldAssetNumberGfmis { get; set; }

    public int? OldOrganizationId { get; set; }

    public int? OldCostCenterId { get; set; }

    public DateTime? OldReceiveDate { get; set; }

    public int? OldAssetAcquisitionTypeId { get; set; }

    public int? OldCurrentResponsibleOfficerId { get; set; }

    public int? OldCurrentBorrowerOfficerId { get; set; }

    public string? NewAssetCode { get; set; }

    public string? NewAssetNumberGfmis { get; set; }

    public int? NewOrganizationId { get; set; }

    public int? NewCostCenterId { get; set; }

    public DateTime? NewReceiveDate { get; set; }

    public int? NewAssetAcquisitionTypeId { get; set; }
}
