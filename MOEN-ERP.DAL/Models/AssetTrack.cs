using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// การตรวจนับทรัพย์สิน
/// </summary>
public partial class AssetTrack
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
    /// เลขที่การตรวจนับ
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// วันที่เริ่มตรวจนับ
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// วันที่จบงาน
    /// </summary>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// N = NEW, W = WORKING (LOAD DATA TO HHT), C = CLOSED
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// หมายเหตุ
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// รหัสสำนัก อ้างอิง Organization.Id
    /// </summary>
    public int? OrganizationId { get; set; }

    /// <summary>
    /// ปีงบประมาณ
    /// </summary>
    public int? BudgetYear { get; set; }

    /// <summary>
    /// ลำดับ เริ่มนับ 1 ใหม่ทุกปีงบประมาณ
    /// </summary>
    public int? Running { get; set; }

    /// <summary>
    /// ช่วงเวลาดำเนินการเริ่มต้น
    /// </summary>
    public DateTime? DurationFromDate { get; set; }

    /// <summary>
    /// ช่วงเวลาดำเนินการสิ้นสุด
    /// </summary>
    public DateTime? DurationToDate { get; set; }
}
