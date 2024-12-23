using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// จัดสรรให้หน่วยงาน
/// </summary>
public partial class BudgetReceive
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
    /// หน่วยงาน อ้างอิง MasterOrganization.Id 
    /// </summary>
    public int? OrganizationId { get; set; }

    /// <summary>
    /// เงินงบประมาณแผ่นดินของหน่วยงาน อ้างอิง BudgetGovernment.Id
    /// </summary>
    public int? BudgetGovernmentId { get; set; }

    /// <summary>
    /// การเบิกจ่ายเงิน งาน/โครงการกองทุนอนุรักษ์ อ้างอิง BudgetDisbursementPlanItem.Id
    /// </summary>
    public int? BudgetDisbursementPlanItemId { get; set; }

    /// <summary>
    /// งาน/โครงการ อ้างอิง Project.Id 
    /// </summary>
    public int? ProjectId { get; set; }

    /// <summary>
    /// รวมเงินงบประมาณที่ได้รับจัดสรร (บาท)
    /// </summary>
    public decimal? TotalAllocateAmount { get; set; }

    /// <summary>
    /// รวมเงินงบประมาณโอนเปลี่ยนแปลง (บาท)
    /// </summary>
    public decimal? TotalTransferAmount { get; set; }

    /// <summary>
    /// รวมเงินงบประมาณที่ได้รับทั้งหมด (บาท)
    /// </summary>
    public decimal? TotalReceiveAmount { get; set; }

    /// <summary>
    /// รวมเงินงบประมาณที่เบิกจ่าย (บาท)
    /// </summary>
    public decimal? TotalPaymentAmount { get; set; }

    /// <summary>
    /// รวมเงินงบประมาณที่ผูกพัน (บาท)
    /// </summary>
    public decimal? TotalObligationAmount { get; set; }

    /// <summary>
    /// รวมเงินงบประมาณคงเหลือ (บาท)
    /// </summary>
    public decimal? TotalBalanceAmount { get; set; }
}
