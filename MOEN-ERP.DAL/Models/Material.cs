using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class Material
{
    /// <summary>
    /// รหัสอ้างอิงวัสดุที่ใช้ในระบบ
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// ผู้สร้าง อ้างอิง SysUser.Id
    /// </summary>
    public int? CreateBy { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? CreateOn { get; set; }

    /// <summary>
    /// ผู้แก้ไข อ้างอิง SysUser.Id
    /// </summary>
    public int? UpdateBy { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? UpdateOn { get; set; }

    /// <summary>
    /// รหัสวัสดุของกรม
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// ชื่อวัสดุ
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// รหัสกลุ่มวัสดุ อ้างอิง MasterMaterialGroup.Id
    /// </summary>
    public int? MaterialGroupId { get; set; }

    /// <summary>
    /// เก็บ Stock ใช่หรือไม่ Y = ใช่, N = ไม่ใช่ 
    /// </summary>
    public string? IsStock { get; set; }

    /// <summary>
    /// หน่วยนับ อ้างอิง MasterUnit.Id
    /// </summary>
    public int? UnitId { get; set; }

    /// <summary>
    /// รายละเอียด
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// ใช้งานอยู่ Y=ใช้งาน, N=ไม่ใช้งาน
    /// </summary>
    public string? Active { get; set; }
}
