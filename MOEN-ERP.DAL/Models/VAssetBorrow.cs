using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAssetBorrow
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

    public string? AssetBorrowType { get; set; }

    public int? BorrowerOfficerId { get; set; }

    public string? BorrowerOfficerName { get; set; }

    public string? BorrowerPositionName { get; set; }

    public int? BorrowerOrganizationId { get; set; }

    public string? BorrowerDivisionName { get; set; }

    public string? BorrowerOfficerType { get; set; }

    public string? BorrowerPhoneExtension { get; set; }

    public string? BorrowerMobile { get; set; }

    public string? BorrowerEmail { get; set; }

    public string? Detail { get; set; }

    public DateTime? BorrowFromDate { get; set; }

    public DateTime? DueDate { get; set; }

    public string? BorrowerType { get; set; }

    public string? BorrowDocument { get; set; }

    public string? OtherName { get; set; }

    public string? OtherPositionName { get; set; }

    public string? OtherPhoneExtension { get; set; }

    public string? OtherMobile { get; set; }

    public string? OtherEmail { get; set; }

    public int? BorrowApproveOfficerId { get; set; }

    public string? BorrowApproveOfficerName { get; set; }

    public DateTime? BorrowApproveDate { get; set; }

    public int? LenderOfficerId { get; set; }

    public string? LenderOfficerName { get; set; }

    public DateTime? LendDate { get; set; }

    public int? LenderOrganizationId { get; set; }

    public int? LendApproveOfficerId { get; set; }

    public string? LendApproveOfficerName { get; set; }

    public DateTime? LendApproveDate { get; set; }

    public int? ReceiveOfficerId { get; set; }

    public string? ReceiveOfficerName { get; set; }

    public DateTime? ReceiveDate { get; set; }

    public string AssetBorrowTypeName { get; set; } = null!;

    public string? StatusName { get; set; }

    public string IsReturn { get; set; } = null!;
}
