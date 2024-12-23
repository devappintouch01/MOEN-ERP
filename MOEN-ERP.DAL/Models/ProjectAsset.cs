using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// หมวดหมู่ครุภัณฑ์ในงาน/โครงการ
/// </summary>
public partial class ProjectAsset
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
    /// หมวดหมู่ย่อย อ้างอิง MasterAssetClass.Id
    /// </summary>
    public int? AssetClassId { get; set; }

    /// <summary>
    /// หมวดหมู่ครุภัณฑ์ อ้างอิง MasterAssetType.Id
    /// </summary>
    public int? AssetTypeId { get; set; }
}
