using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// การเบิกจ่ายเงิน งาน/โครงการกองทุนอนุรักษ์ 
/// </summary>
public partial class ProjectDisbursementPlanItem
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
    /// งวดที่
    /// </summary>
    public int? Period { get; set; }

    /// <summary>
    /// รายการที่เบิก - จ่าย
    /// </summary>
    public string? DisbursementDetail { get; set; }

    /// <summary>
    /// เงื่อนไข
    /// </summary>
    public string? Condition { get; set; }

    /// <summary>
    /// รวมเงินคำของบประมาณ (บาท)
    /// </summary>
    public decimal? TotalRequestAmount { get; set; }

    /// <summary>
    /// รวมเงินงบประมาณที่ได้รับจัดสรร (บาท)
    /// </summary>
    public decimal? TotalAllocateAmount { get; set; }
}
