using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// รายละเอียดแผนการใช้จ่ายงบประมาณ
/// </summary>
public partial class BudgetDisbursementPlanItem
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
    /// แผนการใช้จ่ายงบประมาณ อ้างอิง BudgetDisbursementPlan.Id
    /// </summary>
    public int? BudgetDisbursementPlanId { get; set; }

    /// <summary>
    /// รายการเงินงบประมาณแผ่นดิน อ้างอิง BudgetGovernment.Id
    /// </summary>
    public int? BudgetGovernmentId { get; set; }

    /// <summary>
    /// งาน/โครงการ อ้างอิง Project.Id 
    /// </summary>
    public int? ProjectId { get; set; }

    /// <summary>
    /// เดือนที่ดำเนินการ (1=มกราคม, ..., 12=ธันวาคม)
    /// </summary>
    public int? Month { get; set; }

    /// <summary>
    /// ปีปฏิทินที่ดำเนินการ
    /// </summary>
    public int? Year { get; set; }

    /// <summary>
    /// ปีงบประมาณที่ดำเนินการ
    /// </summary>
    public int? BudgetYear { get; set; }

    /// <summary>
    /// จำนวนราย
    /// </summary>
    public int? Quantity { get; set; }

    /// <summary>
    /// จำนวนเงิน (บาท)
    /// </summary>
    public decimal? PlanAmount { get; set; }

    /// <summary>
    /// การแก้ไขค่า (True=แก้ไขได้, False=ห้ามแก้ไข)
    /// </summary>
    public bool? IsEditable { get; set; }

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
    /// จำนวนเงินงบประมาณที่ได้รับจัดสรรของกองทุนอนุรักษ์ (บาท)
    /// </summary>
    public decimal? AllocateAmount { get; set; }
}
