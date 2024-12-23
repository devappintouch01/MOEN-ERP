using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// เมนูในระบบ
/// </summary>
public partial class SystemMenu
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
    /// ชื่อเมนู
    /// </summary>
    public string? MenuName { get; set; }

    /// <summary>
    /// คำอธิบายเมนู
    /// </summary>
    public string? MenuDescription { get; set; }

    /// <summary>
    /// URL ของหน้าจอที่ผูกกับเมนู
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// ชื่อ Action ของเมนู
    /// </summary>
    public string? ActionName { get; set; }

    /// <summary>
    /// ชื่อ Controller ของ Parent
    /// </summary>
    public string? ControllerMainName { get; set; }

    /// <summary>
    /// ชื่อ Controller ของเมนู
    /// </summary>
    public string? ControllerName { get; set; }

    /// <summary>
    /// การเรียงลำดับ
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// รูป Icon ที่แสดงในเมนู
    /// </summary>
    public string? IconCss { get; set; }

    /// <summary>
    /// มีเมนูในสังกัดหรือไม่ (True=ใช่, False=ไม่ใช่)
    /// </summary>
    public bool? IsParent { get; set; }

    /// <summary>
    /// รหัสอ้างอิงเมนูในระบบที่ไปสังกัด อ้างอิง SystemMenu.Id
    /// </summary>
    public int? ParentMenuId { get; set; }

    /// <summary>
    /// แสดงในเมนูฝั่งซ้าย (True=แสดง, False=ไม่แสดง)
    /// </summary>
    public bool? IsShowInSiteMenu { get; set; }

    /// <summary>
    /// ระบบสำหรับการแสดงเมนู อ้างอิง SystemMenuGroup.Id
    /// </summary>
    public int? SystemMenuGroupId { get; set; }

    /// <summary>
    /// ชื่อระบบ อ้างอิง SystemName.Id
    /// </summary>
    public int? SystemNameId { get; set; }
}
