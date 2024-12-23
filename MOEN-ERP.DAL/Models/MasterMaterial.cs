using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// วัสดุ
/// </summary>
public partial class MasterMaterial
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
    /// รหัสวัสดุ
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// ชื่อวัสดุ
    /// </summary>
    public string? NameThai { get; set; }

    /// <summary>
    /// รายละเอียด
    /// </summary>
    public string? MaterialDescription { get; set; }

    /// <summary>
    /// หมวดพัสดุ อ้างอิง MasterMaterialGroup.Id
    /// </summary>
    public int? MaterialGroupId { get; set; }

    /// <summary>
    /// หน่วยนับ อ้างอิง MasterUnit.Id
    /// </summary>
    public int? UnitId { get; set; }
}
