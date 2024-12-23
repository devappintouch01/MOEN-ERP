using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ค่าเสื่อมราคาสินทรัพย์
/// </summary>
public partial class AssetDepreciation
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
    /// สินทรัพย์ อ้างอิง Asset.Id
    /// </summary>
    public int? AssetId { get; set; }

    /// <summary>
    /// จำนวนวัน
    /// </summary>
    public int? DayNumber { get; set; }

    /// <summary>
    /// ปีที่
    /// </summary>
    public int? YearRunning { get; set; }

    /// <summary>
    /// ค่าเสื่อมราคาประจำปี
    /// </summary>
    public double? YearDepreciation { get; set; }

    /// <summary>
    /// ค่าเสื่อมราคาสะสม
    /// </summary>
    public double? AccumDepreciation { get; set; }

    /// <summary>
    /// มูลค่าสุทธิ
    /// </summary>
    public double? NetValue { get; set; }

    /// <summary>
    /// วันเดือนปีที่คิดค่าเสื่อมราคา
    /// </summary>
    public DateTime? DepreciationDate { get; set; }
}
