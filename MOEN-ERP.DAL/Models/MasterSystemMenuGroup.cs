using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ระบบสำหรับการแสดงเมนู
/// </summary>
public partial class MasterSystemMenuGroup
{
    /// <summary>
    /// รหัสอ้างอิงระบบสำหรับการแสดงเมนูที่ใช้ในระบบ
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
    /// ชื่อระบบ
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// สถานะการใช้งาน (ใช้งาน = True, ไม่ใช้งาน = False)
    /// </summary>
    public bool? Active { get; set; }

    public bool? UserManage { get; set; }
}
