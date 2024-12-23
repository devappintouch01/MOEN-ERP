using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// Log การใช้งาน Web Service
/// </summary>
public partial class SystemLogWebservice
{
    /// <summary>
    /// รหัสอ้างอิงที่ใช้ในระบบ
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// ชื่อ Service ที่เรียกใช้
    /// </summary>
    public string? ServiceName { get; set; }

    /// <summary>
    /// URL ของ Service ที่เรียกใช้
    /// </summary>
    public string? RequestUrl { get; set; }

    /// <summary>
    /// ค่าใน Request
    /// </summary>
    public string? RequestRawInput { get; set; }

    /// <summary>
    /// ผลการเรียกใช้ Service
    /// </summary>
    public string? Result { get; set; }

    /// <summary>
    /// วันที่เรียกใช้ Service
    /// </summary>
    public DateTime? RequestDate { get; set; }

    /// <summary>
    /// IP Address ที่เรียกใช้ Service
    /// </summary>
    public string? RequestIpaddress { get; set; }

    /// <summary>
    /// Agent ที่เรียกใช้ Service
    /// </summary>
    public string? RequestAgent { get; set; }

    /// <summary>
    /// หมายเหตุ
    /// </summary>
    public string? Remark { get; set; }
}
