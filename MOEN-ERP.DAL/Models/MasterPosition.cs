using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ตำแหน่ง
/// </summary>
public partial class MasterPosition
{
    /// <summary>
    /// รหัสอ้างอิงตำแหน่ง
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
    /// ชื่อตำแหน่ง
    /// </summary>
    public string? PositionName { get; set; }

    /// <summary>
    /// ประเภทตำแหน่ง W=ตำแหน่งทางสายงาน, E=ตำแหน่งบริหาร
    /// </summary>
    public string? PositionType { get; set; }

    /// <summary>
    /// การเรียงลำดับ
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)
    /// </summary>
    public bool? Active { get; set; }
}
