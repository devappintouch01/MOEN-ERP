using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ไฟล์แนบ
/// </summary>
public partial class AttachFile
{
    /// <summary>
    /// รหัสอ้างอิงที่ใช้ในระบบ
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// ผู้สร้าง อ้างอิง SystemUser.Id
    /// </summary>
    public int CreateBy { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime CreateOn { get; set; }

    /// <summary>
    /// ผู้แก้ไข อ้างอิง SystemUser.Id
    /// </summary>
    public int? UpdateBy { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? UpdateOn { get; set; }

    /// <summary>
    /// ตารางอ้างอิง
    /// </summary>
    public string? ReferenceTable { get; set; }

    /// <summary>
    /// รายการอ้างอิง
    /// </summary>
    public int? ReferenceId { get; set; }

    /// <summary>
    /// กลุ่มประเภทไฟล์
    /// </summary>
    public string? ReferenceGroup { get; set; }

    /// <summary>
    /// ลำดับ
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// RowGuid
    /// </summary>
    public Guid RowGuid { get; set; }

    /// <summary>
    /// ชื่อไฟล์
    /// </summary>
    public string? Filename { get; set; }

    /// <summary>
    /// นามสกุลไฟล์
    /// </summary>
    public string? Extension { get; set; }

    /// <summary>
    /// ข้อมูลไฟล์
    /// </summary>
    public byte[]? FileData { get; set; }

    /// <summary>
    /// ขนาดไฟล์
    /// </summary>
    public long? FileSize { get; set; }
}
