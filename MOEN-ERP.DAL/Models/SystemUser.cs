using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ผู้ใช้งานระบบ
/// </summary>
public partial class SystemUser
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
    /// ชื่อใช้ในการเข้าใช้งานระบบ
    /// </summary>
    public string? Username { get; set; }

    /// <summary>
    /// รหัสผ่านใช้ในการเข้าใช้งานระบบ
    /// </summary>
    public string? Password { get; set; }

    /// <summary>
    /// ชื่อ
    /// </summary>
    public string? FirstName { get; set; }

    /// <summary>
    /// นามสกุล
    /// </summary>
    public string? LastName { get; set; }

    /// <summary>
    /// อีเมล
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// ประเภทผู้ใช้ (A=AD, S=System)
    /// </summary>
    public string? LoginType { get; set; }

    /// <summary>
    /// IP Address ล่าสุดที่ใช้
    /// </summary>
    public string? LastIpaddress { get; set; }

    /// <summary>
    /// วันที่ล่าสุดที่ Login
    /// </summary>
    public DateTime? LastLogin { get; set; }
}
