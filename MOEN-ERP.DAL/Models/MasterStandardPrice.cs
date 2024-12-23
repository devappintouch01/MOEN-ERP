using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ราคาครุภัณฑ์มาตรฐาน
/// </summary>
public partial class MasterStandardPrice
{
    /// <summary>
    /// รหัสอ้างอิงชื่อระบบ
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public int? CreateBy { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? CreateOn { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public int? UpdateBy { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? UpdateOn { get; set; }

    /// <summary>
    /// ชื่อรายการ
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// ราคาต่อหน่วย
    /// </summary>
    public decimal? UnitPrice { get; set; }

    /// <summary>
    /// หน่วยนับ อ้างอิง MasterUnit.Id
    /// </summary>
    public int? UnitId { get; set; }

    /// <summary>
    /// หมวดหมู่ย่อย อ้างอิง MasterAssetClass.Id
    /// </summary>
    public int? AssetClassId { get; set; }

    /// <summary>
    /// หมวดหมู่ครุภัณฑ์ อ้างอิง MasterAssetType.Id
    /// </summary>
    public int? AssetTypeId { get; set; }

    /// <summary>
    /// สถานะการใช้งาน (ใช้งาน = True, ไม่ใช้งาน = False)
    /// </summary>
    public bool? Active { get; set; }
}
