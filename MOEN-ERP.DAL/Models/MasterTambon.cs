using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ตำบล
/// </summary>
public partial class MasterTambon
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
    /// วันที่เริ่มต้นใช้งาน
    /// </summary>
    public DateTime? EffectiveFromDate { get; set; }

    /// <summary>
    /// วันที่สิ้นสุดการใช้งาน
    /// </summary>
    public DateTime? EffectiveToDate { get; set; }

    /// <summary>
    /// ชื่อตำบล ภาษาไทย
    /// </summary>
    public string? NameThai { get; set; }

    /// <summary>
    /// ชื่อตำบล ภาษาอังกฤษ
    /// </summary>
    public string? NameEnglish { get; set; }

    /// <summary>
    /// รหัสตำบลที่ใช้ในกรมการปกครอง
    /// </summary>
    public string? TambonCode { get; set; }

    /// <summary>
    /// อำเภอ อ้างอิง MasterAmphur.Id
    /// </summary>
    public int? AmphurId { get; set; }

    /// <summary>
    /// รหัสไปรษณีย์
    /// </summary>
    public string? ZipCode { get; set; }
}
