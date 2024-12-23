using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VMaterialBorrow
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public string? Code { get; set; }

    public int? StatusId { get; set; }

    public int? BorrowerBy { get; set; }

    public int? SourceOrganizationId { get; set; }

    public int? TargetOrganizationId { get; set; }

    public string? ReturnRemark { get; set; }

    public int? ApproveBy { get; set; }

    public string? StatusApprove { get; set; }

    public DateTime? ApproveDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public int? Running { get; set; }

    public DateTime? SubmitDate { get; set; }

    public DateTime? BorrowDate { get; set; }

    public string? BorrowerByName { get; set; }

    public string? ApproveByName { get; set; }

    public string? StatusName { get; set; }

    public string? SourceOrganizationName { get; set; }

    public string? TargetOrganizationName { get; set; }
}
