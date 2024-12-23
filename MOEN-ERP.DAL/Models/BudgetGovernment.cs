using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// รายการเงินงบประมาณแผ่นดิน
/// </summary>
public partial class BudgetGovernment
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
    /// สถานะดำเนินการ
    /// </summary>
    public string? BudgetStatus { get; set; }

    /// <summary>
    /// เลขที่คำขอ
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// ปีงบประมาณ
    /// </summary>
    public int? BudgetYear { get; set; }

    /// <summary>
    /// เลข Running สำหรับเรียงลำดับ
    /// </summary>
    public int? Running { get; set; }

    /// <summary>
    /// หน่วยงาน อ้างอิง MasterOrganization.Id 
    /// </summary>
    public int? OrganizationId { get; set; }

    /// <summary>
    /// คำของบประมาณ อ้างอิง BudgetRequest.Id
    /// </summary>
    public int? BudgetRequestId { get; set; }

    /// <summary>
    /// แบบฟอร์มคำของบประมาณ อ้างอิง MasterBudgetFormType.Id
    /// </summary>
    public int? BudgetFormTypeId { get; set; }

    /// <summary>
    /// งบประมาณจำแนกตามงบรายจ่าย อ้างอิง MasterBudgetExpenseType.Id
    /// </summary>
    public int? BudgetExpenseTypeId { get; set; }

    /// <summary>
    /// กิจกรรมหลัก อ้างอิง MasterActivityCode.Id
    /// </summary>
    public int? ActivityCodeId { get; set; }

    /// <summary>
    /// รายการ
    /// </summary>
    public string? BudgetDetail { get; set; }

    /// <summary>
    /// เหตุผลความจำเป็น
    /// </summary>
    public string? Reason { get; set; }

    /// <summary>
    /// งาน/โครงการ อ้างอิง Project.Id 
    /// </summary>
    public int? ProjectId { get; set; }

    /// <summary>
    /// รวมเงินคำของบประมาณ (บาท)
    /// </summary>
    public decimal? TotalRequestAmount { get; set; }

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

    /// <summary>
    /// คืนเงินเหลือจ่าย (บาท)
    /// </summary>
    public decimal? RefundAmount { get; set; }

    /// <summary>
    /// กันไว้ที่ส่วนกลาง
    /// </summary>
    public decimal? KeptCentral { get; set; }

    /// <summary>
    /// รวมเงินงบประมาณที่ได้รับจัดสรรจังหวัด (บาท) 
    /// </summary>
    public decimal? TotalAllocateAmountProvince { get; set; }

    /// <summary>
    /// รวมเงินงบประมาณที่ได้รับจัดสรรส่วนกลาง (บาท)
    /// </summary>
    public decimal? TotalAllocateAmountCentral { get; set; }

    /// <summary>
    /// ประเภทงบแผ่นดิน (1 = สป. 2 = งบเบิกแทน 3 = คำขอเพิ่มเติม)
    /// </summary>
    public string? BudgetGovernmentType { get; set; }
}
