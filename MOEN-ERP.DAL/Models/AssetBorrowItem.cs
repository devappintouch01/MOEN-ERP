using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ครุภัณฑ์ที่ยืม
/// </summary>
public partial class AssetBorrowItem
{
    /// <summary>
    /// รหัสอ้างอิงที่ใช้ในระบบ
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// ผู้สร้าง อ้างอิง SystemUser.Id
    /// </summary>
    public int? CreateBy { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? CreateOn { get; set; }

    /// <summary>
    /// ผู้แก้ไข อ้างอิง SystemUser.Id
    /// </summary>
    public int? UpdateBy { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? UpdateOn { get; set; }

    /// <summary>
    /// การยืม-คืนครุภัณฑ์ อ้างอิง AssetBorrow.Id
    /// </summary>
    public int? AssetBorrowId { get; set; }

    /// <summary>
    /// สินทรัพย์ อ้างอิง Asset.Id
    /// </summary>
    public int? AssetId { get; set; }

    /// <summary>
    /// สถานะการยืม (B=ยืม, R=ส่งคืน, C=รับคืน)
    /// </summary>
    public string? AssetBorrowStatus { get; set; }

    /// <summary>
    /// หมายเหตุการยืม
    /// </summary>
    public string? BorrowDetail { get; set; }

    /// <summary>
    /// ผู้ส่งคืน อ้างอิง Officer.Id 
    /// </summary>
    public int? ReturnOfficerId { get; set; }

    /// <summary>
    /// ชื่อผู้ส่งคืน
    /// </summary>
    public string? ReturnOfficerName { get; set; }

    /// <summary>
    /// วันที่ส่งคืน
    /// </summary>
    public DateTime? ReturnDate { get; set; }

    /// <summary>
    /// สภาพทรัพย์สิน (True=ปกติ, N=ชำรุด)
    /// </summary>
    public bool? IsUsable { get; set; }

    /// <summary>
    /// หมายเหตุการคืน
    /// </summary>
    public string? ReturnDetail { get; set; }

    /// <summary>
    /// ผู้รับคืน อ้างอิง Officer.Id 
    /// </summary>
    public int? ReceiveOfficerId { get; set; }

    /// <summary>
    /// ชื่อผู้รับคืน
    /// </summary>
    public string? ReceiveOfficerName { get; set; }

    /// <summary>
    /// วันที่รับคืน
    /// </summary>
    public DateTime? ReceiveDate { get; set; }
}
