using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// รายการยืมวัสดุ
/// </summary>
public partial class MaterialBorrowItem
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
    /// รหัสวัสดุ อ้างอิง MasterMaterial.Id
    /// </summary>
    public int? MaterialId { get; set; }

    /// <summary>
    /// รหัสใบยืมวัสดุ อ้างอิง MaterialBorrow.Id
    /// </summary>
    public int? MaterialBorrowId { get; set; }

    /// <summary>
    /// สถานะ 1 = ยืม, 2 = ส่งคืน, 3 = รับคืน
    /// </summary>
    public int? StatusId { get; set; }

    /// <summary>
    /// วันที่ส่งคืน
    /// </summary>
    public DateTime? ReturnDate { get; set; }

    /// <summary>
    /// ผู้ส่งคืน อ้างอิง SystemUser.Id
    /// </summary>
    public int? ReturnBy { get; set; }

    /// <summary>
    /// ผู้รับคืน อ้างอิง SystemUser.Id
    /// </summary>
    public int? ReturneeBy { get; set; }

    /// <summary>
    /// วันที่รับคืน
    /// </summary>
    public DateTime? ReturnReceiveDate { get; set; }

    /// <summary>
    /// หมายเหตุ
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// จำนวนที่จ่ายจริง
    /// </summary>
    public int? ReceiveAmount { get; set; }

    /// <summary>
    /// หน่วยนับ อ้างอิง MasterUnit.Id
    /// </summary>
    public int? UnitId { get; set; }

    /// <summary>
    /// จำนวนที่ขอยืม
    /// </summary>
    public int? BorrowAmount { get; set; }
}
