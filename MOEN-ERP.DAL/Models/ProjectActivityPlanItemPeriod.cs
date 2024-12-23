﻿using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ระยะเวลาดำเนินโครงการ 
/// </summary>
public partial class ProjectActivityPlanItemPeriod
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
    /// รายละเอียดระยะเวลาดำเนินโครงการและแผนปฏิบัติ อ้างอิง ProjectActivityPlanItem.Id
    /// </summary>
    public int? ProjectActivityPlanItemId { get; set; }

    /// <summary>
    /// วันที่ที่เริ่มต้น
    /// </summary>
    public int? StartDate { get; set; }

    /// <summary>
    /// วันที่สิ้นสุด
    /// </summary>
    public int? EndDate { get; set; }
}