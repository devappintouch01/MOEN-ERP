using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VMaterialRequisition
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public string? Code { get; set; }

    public DateTime? RequestDate { get; set; }

    public int? RequestType { get; set; }

    public int? RequestBy { get; set; }

    public int? ApproveRequestBy { get; set; }

    public string? StatusApprove { get; set; }

    public DateTime? ApproveDate { get; set; }

    public int? Running { get; set; }

    public DateTime? CancelDate { get; set; }

    public string? CancelRemark { get; set; }

    public DateTime? SubmitDate { get; set; }

    public string? ReturnRemark { get; set; }

    public int? ReturnBy { get; set; }

    public DateTime? ReturnDate { get; set; }

    public int? StatusId { get; set; }

    public int? WarehouseId { get; set; }

    public int? OrganizationId { get; set; }

    public int? DeliverApproveOfficerId { get; set; }

    public string? DeliverApproveOfficerName { get; set; }

    public DateTime? DeliverApproveDate { get; set; }

    public int? DeliverOfficerId { get; set; }

    public string? DeliverOfficerName { get; set; }

    public DateTime? DeliverDate { get; set; }

    public int? ReceiveOfficerId { get; set; }

    public string? ReceiveOfficerName { get; set; }

    public DateTime? ReceiveDate { get; set; }

    public string? OrganizationName { get; set; }

    public string? RequestByName { get; set; }

    public string? RequestByPositionName { get; set; }

    public string? DeliverApproveOfficerPositionName { get; set; }

    public string? DeliverOfficerPositionName { get; set; }

    public string? ReceiveOfficerPositionName { get; set; }

    public string? StatusName { get; set; }

    public string? WarehouseName { get; set; }
}
