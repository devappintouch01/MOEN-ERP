using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// Log การดำเนินการในระบบ
/// </summary>
public partial class SystemLogActivity
{
    /// <summary>
    /// รหัสอ้างอิงที่ใช้ในระบบ
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// ประเภทการดำเนินการในระบบ อ้างอิง MasterActivityLogType.Id
    /// </summary>
    public int? ActivityLogTypeId { get; set; }

    /// <summary>
    /// ผู้ดำเนินการ อ้างอิง SystemUser.Id
    /// </summary>
    public int? SystemUserId { get; set; }

    /// <summary>
    /// วันที่บันทึก
    /// </summary>
    public DateTime? LogDate { get; set; }

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
