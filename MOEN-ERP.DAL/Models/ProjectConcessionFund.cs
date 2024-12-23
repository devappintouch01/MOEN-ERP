using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// งาน/โครงการกองทุนสัมปทาน
/// </summary>
public partial class ProjectConcessionFund
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
    /// ความสอดคล้องตามแผนหรือนโยบายของกระทรวงพลังงาน
    /// </summary>
    public string? PlanConsistency { get; set; }

    /// <summary>
    /// ความสอดคล้องกับวัตถุประสงค์ของกองทุน อ้างอิง MasterCompliance.Id
    /// </summary>
    public int? ConsistencyId { get; set; }

    /// <summary>
    /// วิธีดำเนินการ
    /// </summary>
    public string? Proceed { get; set; }

    /// <summary>
    /// ผลที่คาดว่าจะได้รับ
    /// </summary>
    public string? ExpectedResults { get; set; }

    /// <summary>
    /// หน่วยงานผู้รับผิดชอบหลัก อ้างอิง MasterOrganization.Id
    /// </summary>
    public int? MainOrganizationId { get; set; }

    /// <summary>
    /// ชื่อผู้รับผิดชอบโครงการหลัก อ้างอิง Officer.Id
    /// </summary>
    public int? MainOfficerId { get; set; }

    /// <summary>
    /// เบอร์โทรผู้รับผิดชอบหลัก
    /// </summary>
    public string? MainPhone { get; set; }

    /// <summary>
    /// อีเมลผู้รับผิดชอบหลัก
    /// </summary>
    public string? MainEmail { get; set; }

    /// <summary>
    /// หน่วยงานผู้รับผิดชอบสำรอง อ้างอิง MasterOrganization.Id
    /// </summary>
    public int? AlternateOrganizationId { get; set; }

    /// <summary>
    /// ชื่อผู้รับผิดชอบโครงการสำรอง อ้างอิง Officer.Id
    /// </summary>
    public int? AlternateOfficerId { get; set; }

    /// <summary>
    /// เบอร์โทรผู้รับผิดชอบสำรอง
    /// </summary>
    public string? AlternatePhone { get; set; }

    /// <summary>
    /// อีเมลผู้รับผิดชอบสำรอง
    /// </summary>
    public string? AlternateEmail { get; set; }
}
