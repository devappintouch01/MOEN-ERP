using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAssetMaintenanceForm
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

    public string? Subject { get; set; }

    public string? Detail { get; set; }

    public int? RequestOrganizationId { get; set; }

    public int? RequestOfficerId { get; set; }

    public string? RequestOfficerName { get; set; }

    public int? RequestDirectorId { get; set; }

    public DateTime? RequestDate { get; set; }

    public int? CheckOfficerId { get; set; }

    public string? CheckOfficerName { get; set; }

    public int? ReceiveOfficerId { get; set; }

    public string? ReceiveOfficerName { get; set; }

    public int? ReceiveDirectorId { get; set; }

    public DateTime? ReceiveDate { get; set; }

    public int? SupplierId { get; set; }

    public string? SupplierName { get; set; }

    public DateTime? ExpectDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public DateTime? ReturnCompleteDate { get; set; }

    public string? StatusName { get; set; }
}
