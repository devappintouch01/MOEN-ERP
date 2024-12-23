using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAssetTransferReport
{
    public int? Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? StatusId { get; set; }

    public string? Code { get; set; }

    public int? BudgetYear { get; set; }

    public int? Running { get; set; }

    public DateTime? DocumentDate { get; set; }

    public int? DestinationOrganizationId { get; set; }

    public string? Detail { get; set; }

    public int? TransferOfficerId { get; set; }

    public string? TransferOfficerName { get; set; }

    public DateTime? TransferDate { get; set; }

    public string? TransferPositionName { get; set; }

    public string? TransferOrganizationName { get; set; }

    public string? TransferOrganizationCode { get; set; }

    public string? TransferCostCenterCode { get; set; }

    public string? TransferAreaCode { get; set; }

    public int? ReceiveOfficerId { get; set; }

    public string? ReceiveOfficerName { get; set; }

    public DateTime? ReceiveDate { get; set; }

    public string? ReceivePositionName { get; set; }

    public string? ReceiveOrganizationName { get; set; }

    public string? ReceiveOrganizationCode { get; set; }

    public string? ReceiveCostCenterCode { get; set; }

    public string? ReceiveAreaCode { get; set; }

    public DateTime? OldReceiveDate { get; set; }

    public string? OldAssetNumberGfmis { get; set; }

    public string? AssetName { get; set; }

    public decimal? Cost { get; set; }

    public DateTime? NewReceiveDate { get; set; }

    public string? NewAssetNumberGfmis { get; set; }
}
