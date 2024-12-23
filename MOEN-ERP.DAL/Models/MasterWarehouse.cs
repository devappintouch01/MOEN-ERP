using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// คลังเก็บวัสดุ
/// </summary>
public partial class MasterWarehouse
{
    /// <summary>
    /// รหัสอ้างอิงคลังที่ใช้ในระบบ
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
    /// ชื่อคลัง
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// รหัสหน่วยงาน อ้างอิง MasterOrganization.Id
    /// </summary>
    public int? OrganizationId { get; set; }

    /// <summary>
    /// สถานะการใช้งาน (ใช้งาน = True, ไม่ใช้งาน = False)
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// 1 = หน่วยงานจัดซื้อ 2 = หน่วยงานส่วนกลาง 3 = หน่วยงานจังหวัด
    /// </summary>
    public string? WarehouseLevel { get; set; }
}
