using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// รายการครุภัณฑ์ในงาน/โครงการ
/// </summary>
public partial class ProjectAssetItem
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
    /// งาน/โครงการ อ้างอิง Project.Id 
    /// </summary>
    public int? ProjectId { get; set; }

    /// <summary>
    /// หมวดหมู่ครุภัณฑ์ในโครงการ อ้างอิง ProjectAsset.Id
    /// </summary>
    public int? ProjectAssetId { get; set; }

    /// <summary>
    /// ชื่อรายการ
    /// </summary>
    public string? AssetName { get; set; }

    /// <summary>
    /// ใช้ราคากลาง (True=ใช้ราคากลาง, False=ไม่ใช้ราคากลาง)
    /// </summary>
    public bool? IsUseStandardPrice { get; set; }

    /// <summary>
    /// ราคากลาง อ้างอิง MasterStandardPrice.Id
    /// </summary>
    public int? StandardPriceId { get; set; }

    /// <summary>
    /// จำนวนหน่วย
    /// </summary>
    public int? QuantityUnit { get; set; }

    /// <summary>
    /// ราคาต่อหน่วย
    /// </summary>
    public decimal? UnitPrice { get; set; }

    /// <summary>
    /// หน่วยนับ อ้างอิง MasterUnit.Id
    /// </summary>
    public int? UnitId { get; set; }

    /// <summary>
    /// รวมเป็นเงินทั้งสิ้น (บาท)
    /// </summary>
    public decimal? TotalAmount { get; set; }

    /// <summary>
    /// ครุภัณฑ์ทดแทน (True=เป็น, False=ไม่เป็น)
    /// </summary>
    public bool? IsReplace { get; set; }
}
