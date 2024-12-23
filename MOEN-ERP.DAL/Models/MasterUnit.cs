using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// หน่วยนับ
/// </summary>
public partial class MasterUnit
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
    /// ชื่อหน่วยนับ ภาษาไทย
    /// </summary>
    public string? NameThai { get; set; }

    /// <summary>
    /// การใช้งานในระบบ e-GP (True=ใช้งาน, False=ไม่ใช้งาน)
    /// </summary>
    public bool? Egpactive { get; set; }

    /// <summary>
    /// รหัสอ้างอิงที่ใช้ในระบบ e-GP
    /// </summary>
    public int? Egpid { get; set; }
}
