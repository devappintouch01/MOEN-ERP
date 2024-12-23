using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// กองทุน
/// </summary>
public partial class MasterFund
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
    /// รหัสกองทุน
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// ชื่อกองทุน ภาษาไทย
    /// </summary>
    public string? NameThai { get; set; }

    /// <summary>
    /// ชื่อกองทุน ภาษาอังกฤษ
    /// </summary>
    public string? NameEnglish { get; set; }

    /// <summary>
    /// ชื่อย่อกองทุน
    /// </summary>
    public string? Abbreviation { get; set; }
}
