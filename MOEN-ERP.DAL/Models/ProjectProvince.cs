using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// งาน/โครงการจังหวัด
/// </summary>
public partial class ProjectProvince
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
    /// ประเภท กลุ่มจังหวัด = G  จังหวัด = P
    /// </summary>
    public string? ProvinceGroup { get; set; }

    /// <summary>
    /// ชื่อแผนงาน
    /// </summary>
    public string? PlanName { get; set; }

    /// <summary>
    /// แนวทางการพัฒนา
    /// </summary>
    public string? Development { get; set; }

    /// <summary>
    /// ตัวชี้วัดเชิงปริมาณ
    /// </summary>
    public string? ProjectKpiquantity { get; set; }

    /// <summary>
    /// ตัวชี้วัดเชิงคุณภาพ
    /// </summary>
    public string? ProjectKpiquality { get; set; }

    /// <summary>
    /// พื้นที่เป้าหมาย
    /// </summary>
    public string? TargetArea { get; set; }

    /// <summary>
    /// กิจกรรมหลัก
    /// </summary>
    public string? MainActivity { get; set; }
}
