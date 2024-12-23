using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// สถานที่จัดเก็บ/ใช้งาน
/// </summary>
public partial class MasterStorePlace
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
    /// ชื่อสถานที่จัดเก็บใช้งาน
    /// </summary>
    public string? NameThai { get; set; }

    /// <summary>
    /// รหัสสถานที่จัดเก็บ
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// หน่วยงาน อ้างอิง MasterOrganization.Id
    /// </summary>
    public int? OrganizationId { get; set; }

    /// <summary>
    /// ชั้น
    /// </summary>
    public string? Floor { get; set; }
}
