using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// การรายงานความก้าวหน้า งาน/โครงการกองทุนนรักษ์
/// </summary>
public partial class ProjectProgressPlanItem
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
    /// งาน/โครงการ อ้างอิง Project.Id 
    /// </summary>
    public int? ProjectId { get; set; }

    /// <summary>
    /// การรายงาน
    /// </summary>
    public string? ReportDetail { get; set; }

    /// <summary>
    /// กำหนดเวลาส่ง
    /// </summary>
    public DateTime? Deadline { get; set; }

    /// <summary>
    /// งานที่ส่งมอบ
    /// </summary>
    public string? DeliveredWork { get; set; }
}
