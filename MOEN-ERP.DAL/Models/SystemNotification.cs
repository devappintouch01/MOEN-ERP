using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// การแจ้งเตือน
/// </summary>
public partial class SystemNotification
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
    /// ผู้ใช้งานที่ได้รับการแจ้งเตือน อ้างอิง SystemUser.Id
    /// </summary>
    public int? SystemUserId { get; set; }

    /// <summary>
    /// ประเภทการแจ้งเตือน (U=แจ้งถึงผู้ใช้คนเดียว, R=แจ้งถึงทุกคนใน role, O=แจ้งถึงทุกคนในหน่วยงานเดียวกัน)
    /// </summary>
    public string? NotificationType { get; set; }

    /// <summary>
    /// วันที่แจ้งเตือน
    /// </summary>
    public DateTime? NotificationDate { get; set; }

    /// <summary>
    /// วันที่เปิดดูการแจ้งเตือน
    /// </summary>
    public DateTime? OpenDate { get; set; }

    /// <summary>
    /// สถานะ (N=new, O=open, V=void)
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// หัวข้อ/เรื่อง
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// รายละเอียด
    /// </summary>
    public string? Detail { get; set; }

    /// <summary>
    /// ประเภทอ้างอิง
    /// </summary>
    public string? ReferenceType { get; set; }

    /// <summary>
    /// รหัสที่อ้างอิง
    /// </summary>
    public int? ReferenceId { get; set; }
}
