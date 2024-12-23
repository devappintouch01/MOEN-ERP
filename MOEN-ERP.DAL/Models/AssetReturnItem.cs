using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ครุภัณฑ์ที่ส่งคืน
/// </summary>
public partial class AssetReturnItem
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
    /// การเบิกจ่ายครุภัณฑ์ อ้างอิง AssetRequisition.Id
    /// </summary>
    public int? AssetReturnId { get; set; }

    /// <summary>
    /// สินทรัพย์ อ้างอิง Asset.Id
    /// </summary>
    public int? AssetId { get; set; }

    /// <summary>
    /// หน่วยนับ อ้างอิง MasterUnit.Id 
    /// </summary>
    public int? UnitId { get; set; }

    /// <summary>
    /// จำนวน
    /// </summary>
    public int? Amount { get; set; }

    /// <summary>
    /// จำนวนเงิน (บาท)
    /// </summary>
    public decimal? Cost { get; set; }

    /// <summary>
    /// สภาพทรัพย์สิน (True=ใช้งานได้แต่หมดความจำเป็นใช้งาน, N=ใช้งานไม่ได้/ชำรุด)
    /// </summary>
    public bool? IsUsable { get; set; }

    /// <summary>
    /// ลักษณะการชำรุด
    /// </summary>
    public string? ReturnDetail { get; set; }

    /// <summary>
    /// ตรวจสอบสภาพการชำรุด (True=ตรวจสอบแล้ว, False=ยังไม่ตรวจสอบ)
    /// </summary>
    public bool? Ischeck { get; set; }

    /// <summary>
    /// ผลการตรวจสอบสภาพการชำรุด
    /// </summary>
    public string? CheckDatail { get; set; }
}
