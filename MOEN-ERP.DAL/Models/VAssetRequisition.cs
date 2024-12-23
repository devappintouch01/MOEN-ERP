using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAssetRequisition
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

    public string? Detail { get; set; }

    public string? StorePlaceDetail { get; set; }

    public int? RequestOrganizationId { get; set; }

    public int? RequestOfficerId { get; set; }

    public string? RequestOfficerName { get; set; }

    public DateTime? RequestDate { get; set; }

    public DateTime? ExpectDate { get; set; }

    public int? DeliverApproveOfficerId { get; set; }

    public string? DeliverApproveOfficerName { get; set; }

    public DateTime? DeliverApproveDate { get; set; }

    public int? DeliverOfficerId { get; set; }

    public string? DeliverOfficerName { get; set; }

    public DateTime? DeliverDate { get; set; }

    public int? ReceiveOfficerId { get; set; }

    public string? ReceiveOfficerName { get; set; }

    public DateTime? ReceiveDate { get; set; }

    public string? StatusName { get; set; }

    public string? RequestOrganizationName { get; set; }
}
