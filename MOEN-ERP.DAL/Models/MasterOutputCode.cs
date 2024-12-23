using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ผลผลิต/โครงการ
/// </summary>
public partial class MasterOutputCode
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
    /// วันที่เริ่มต้นใช้งาน
    /// </summary>
    public DateTime? EffectiveFromDate { get; set; }

    /// <summary>
    /// วันที่สิ้นสุดการใช้งาน
    /// </summary>
    public DateTime? EffectiveToDate { get; set; }

    /// <summary>
    /// รหัสผลผลิต/โครงการ
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// ชื่อผลผลิต/โครงการ
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// ชื่อย่อผลผลิต/โครงการ
    /// </summary>
    public string? Abbreviation { get; set; }

    /// <summary>
    /// ปีงบประมาณ
    /// </summary>
    public int? BudgetYear { get; set; }

    /// <summary>
    /// แผนงาน อ้างอิง MasterStrategicPlanCode.Id
    /// </summary>
    public int? StrategicPlanCodeId { get; set; }

    /// <summary>
    /// ประเภทผลผลิต/โครงการ (O=ผลผลิต, P=โครงการ)
    /// </summary>
    public string? OutputType { get; set; }

    /// <summary>
    /// เป้าหมาย
    /// </summary>
    public string? Target { get; set; }

    /// <summary>
    /// ตัวชี้วัด
    /// </summary>
    public string? Kpi { get; set; }
}
