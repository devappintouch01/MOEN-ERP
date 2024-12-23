using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// Log การเข้าใช้งานหน้าจอ
/// </summary>
public partial class SystemLogAccessPage
{
    /// <summary>
    /// รหัสอ้างอิงที่ใช้ในระบบ
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// เมนูในระบบ อ้างอิง SystemMenu.Id
    /// </summary>
    public int? SystemMenuId { get; set; }

    /// <summary>
    /// ผู้เข้าใช้งาน อ้างอิง SystemUser.Id
    /// </summary>
    public int? SystemUserId { get; set; }

    /// <summary>
    /// ชื่อหน้าจอ
    /// </summary>
    public string? PageName { get; set; }

    /// <summary>
    /// วันและเวลาที่เข้าใช้งาน
    /// </summary>
    public DateTime? AccessDateTime { get; set; }

    /// <summary>
    /// ปีที่เข้าใช้งาน
    /// </summary>
    public int? AccessYear { get; set; }

    /// <summary>
    /// เดือนที่เข้าใช้งาน
    /// </summary>
    public int? AccessMonth { get; set; }

    /// <summary>
    /// วันที่เข้าใช้งาน
    /// </summary>
    public int? AccessDay { get; set; }

    /// <summary>
    /// ชั่วโมงที่เข้าใช้งาน
    /// </summary>
    public int? AccessHour { get; set; }

    /// <summary>
    /// นาทีที่เข้าใช้งาน
    /// </summary>
    public int? AccessMinute { get; set; }

    /// <summary>
    /// IP Address
    /// </summary>
    public string? Ipaddress { get; set; }

    /// <summary>
    /// User Agent
    /// </summary>
    public string? UserAgent { get; set; }

    /// <summary>
    /// หมายเหตุ
    /// </summary>
    public string? Remark { get; set; }
}
