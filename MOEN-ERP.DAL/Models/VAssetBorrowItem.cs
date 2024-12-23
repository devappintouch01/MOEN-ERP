using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VAssetBorrowItem
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? AssetBorrowId { get; set; }

    public int? AssetId { get; set; }

    public string? AssetBorrowStatus { get; set; }

    public string? BorrowDetail { get; set; }

    public int? ReturnOfficerId { get; set; }

    public string? ReturnOfficerName { get; set; }

    public DateTime? ReturnDate { get; set; }

    public bool? IsUsable { get; set; }

    public string? ReturnDetail { get; set; }

    public int? ReceiveOfficerId { get; set; }

    public string? ReceiveOfficerName { get; set; }

    public DateTime? ReceiveDate { get; set; }

    public string? AssetName { get; set; }

    public string? SerialNumber { get; set; }

    public string? Code { get; set; }

    public string AssetBorrowStatusName { get; set; } = null!;
}
