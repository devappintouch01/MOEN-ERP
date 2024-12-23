using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAssetTransfer
{
    public int Id { get; set; }

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

    public int? ReceiveOfficerId { get; set; }

    public string? ReceiveOfficerName { get; set; }

    public DateTime? ReceiveDate { get; set; }

    public int? TransferOrganizationId { get; set; }

    public string? TransferOrganizationName { get; set; }

    public string? DestinationOrganizationName { get; set; }

    public string? StatusName { get; set; }
}
