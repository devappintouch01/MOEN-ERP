using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// หมวดหมู่ย่อยครุภัณฑ์
/// </summary>
public partial class MasterAssetClass
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
    /// สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// วันที่เริ่มต้นใช้งาน
    /// </summary>
    public DateTime? EffectiveFromDate { get; set; }

    /// <summary>
    /// วันที่สิ้นสุดการใช้งาน
    /// </summary>
    public DateTime? EffectiveToDate { get; set; }

    /// <summary>
    /// เลขหมวด
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// ชื่อหมวดหมู่ย่อย ภาษาไทย
    /// </summary>
    public string? NameThai { get; set; }

    /// <summary>
    /// หมวดหมู่ครุภัณฑ์ อ้างอิง MasterAssetType.Id
    /// </summary>
    public int? AssetTypeId { get; set; }

    /// <summary>
    /// หมวดหมู่ครุภัณฑ์รายการย่อย อ้างอิง MasterAssetTypeSub.Id
    /// </summary>
    public int? AssetTypeSubId { get; set; }

    /// <summary>
    /// การเรียงลำดับ
    /// </summary>
    public int? SequenceNumber { get; set; }

    /// <summary>
    /// อัตราค่าเสื่อม (ร้อยละ)
    /// </summary>
    public decimal? Depreciation { get; set; }

    /// <summary>
    /// อายุการใช้งาน (ทดแทน)
    /// </summary>
    public int? LifeTimeUse { get; set; }

    /// <summary>
    /// อายุการใช้งาน(ค่าเสื่อม)
    /// </summary>
    public int? LifeTimeDepreciation { get; set; }
}
