using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// รูปครุภัณฑ์
/// </summary>
public partial class AssetImage
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
    /// ครุภัณฑ์ อ้างอิง Asset.Id
    /// </summary>
    public int AssetId { get; set; }

    /// <summary>
    /// รูปครุภัณฑ์จากการนับ อ้างอิง AssetTrackImage.Id
    /// </summary>
    public int? AssetTrackImageId { get; set; }

    /// <summary>
    /// กลุ่มประเภทรูป (A=รูปครุภัณฑ์, N=รูปหมายเลขครุภัณฑ์, S=รูปสถานที่จัดเก็บ)
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
    /// รูป
    /// </summary>
    public byte[]? ImageData { get; set; }

    /// <summary>
    /// ขนาดไฟล์
    /// </summary>
    public long? FileSize { get; set; }

    /// <summary>
    /// เป็นรูปหลักในการแสดงผล (True=ใช่, False=ไม่ใช่)
    /// </summary>
    public bool? IsMain { get; set; }
}
