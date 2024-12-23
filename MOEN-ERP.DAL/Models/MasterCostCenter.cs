﻿using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ศูนย์ต้นทุน
/// </summary>
public partial class MasterCostCenter
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
    /// รหัสศูนย์ต้นทุน
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// ชื่อศูนย์ต้นทุนภาษาไทย
    /// </summary>
    public string? NameThai { get; set; }

    /// <summary>
    /// ชื่อย่อศูนย์ต้นทุน
    /// </summary>
    public string? Abbreviation { get; set; }

    /// <summary>
    /// รหัสพื้นที่
    /// </summary>
    public string? AreaCode { get; set; }
}
