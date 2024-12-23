using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// รายการเงินงบประมาณแผ่นดิน
/// </summary>
public partial class BudgetGovernmentItem
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
    /// เงินงบประมาณแผ่นดินของหน่วยงาน อ้างอิง BudgetGovernment.Id
    /// </summary>
    public int? BudgetGovernmentId { get; set; }

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
    /// รายละเอียดค่าใช้จ่าย
    /// </summary>
    public string? ItemDetail { get; set; }

    /// <summary>
    /// หน่วยนับ (จำนวนคน)
    /// </summary>
    public int? Quantity { get; set; }

    /// <summary>
    /// จำนวนหน่วย
    /// </summary>
    public int? QuantityUnit { get; set; }

    /// <summary>
    /// หน่วยนับ อ้างอิง MasterUnit.Id 
    /// </summary>
    public int? QuantityUnitId { get; set; }

    /// <summary>
    /// อัตราที่ตั้ง (ราคาต่อหน่วย)
    /// </summary>
    public decimal? ExpenseRate { get; set; }

    /// <summary>
    /// หน่วยนับ อ้างอิง MasterUnit.Id 
    /// </summary>
    public int? ExpenseRateUnitId { get; set; }

    /// <summary>
    /// รวมจำนวนเงิน (บาท)
    /// </summary>
    public decimal? TotalAmount { get; set; }
}
