using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAssetReturn
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

    public string? AssetReturnType { get; set; }

    public int? ReturnOrganizationId { get; set; }

    public int? ReturnOfficerId { get; set; }

    public string? ReturnOfficerName { get; set; }

    public DateTime? ReturnDate { get; set; }

    public int? NewResponsibleOfficerId { get; set; }

    public int? NewResponsibleOrganizationId { get; set; }

    public DateTime? AcceptDate { get; set; }

    public int? CheckOfficerId { get; set; }

    public string? CheckOfficerName { get; set; }

    public DateTime? CheckDate { get; set; }

    public int? ApproveOfficerId { get; set; }

    public string? ApproveOfficerName { get; set; }

    public DateTime? ApproveDate { get; set; }

    public int? ReceiveOfficerId { get; set; }

    public string? ReceiveOfficerName { get; set; }

    public DateTime? ReceiveDate { get; set; }

    public string? StatusName { get; set; }
}
