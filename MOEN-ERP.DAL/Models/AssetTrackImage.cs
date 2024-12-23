using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// รูปจากการตรวจสอบครุภัณฑ์ประจำปี
/// </summary>
public partial class AssetTrackImage
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
    /// การตรวจสอบครุภัณฑ์ประจำปี อ้างอิง AssetTrack.Id
    /// </summary>
    public int AssetTrackId { get; set; }

    /// <summary>
    /// ครุภัณฑ์ อ้างอิง Asset.Id
    /// </summary>
    public int AssetId { get; set; }

    /// <summary>
    /// รายการในการตรวจสอบครุภัณฑ์ประจำปี อ้างอิง AssetTrackItem.Id
    /// </summary>
    public int? AssetTrackItemId { get; set; }

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
}
