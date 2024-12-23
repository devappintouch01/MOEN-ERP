using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// งาน/โครงการ
/// </summary>
public partial class Project
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
    /// เลขที่อ้างอิง
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
    /// ชื่องาน/โครงการ
    /// </summary>
    public string? ProjectName { get; set; }

    /// <summary>
    /// หน่วยงาน อ้างอิง MasterOrganization.Id 
    /// </summary>
    public int? OrganizationId { get; set; }

    /// <summary>
    /// ใช้งบประมาณ (True=ใช้งบประมาณ, False=ไม่ใช้งบประมาณ)
    /// </summary>
    public bool? IsUseBudget { get; set; }

    /// <summary>
    /// ประเภทงบ อ้างอิง MasterBudgetType.Id
    /// </summary>
    public int? BudgetTypeId { get; set; }

    /// <summary>
    /// รายการเงินงบประมาณแผ่นดิน อ้างอิง BudgetGovernment.Id
    /// </summary>
    public int? BudgetGovernmentId { get; set; }

    /// <summary>
    /// คำของบประมาณ อ้างอิง BudgetRequest.Id
    /// </summary>
    public int? BudgetRequestId { get; set; }

    /// <summary>
    /// กองทุน อ้างอิง MasterFund.Id
    /// </summary>
    public int? FundId { get; set; }

    /// <summary>
    /// สพจ.ดำเนินการเอง โดยผ่านส่วนกลางบริหารโครงการ (True=ใช่, False=ไม่ใช่)
    /// </summary>
    public bool? IsManageByHq { get; set; }

    /// <summary>
    /// หน่วยงานบริหารโครงการ อ้างอิง MasterOrganization.Id 
    /// </summary>
    public int? ManageOrganizationId { get; set; }

    /// <summary>
    /// หลักการและเหตุผล
    /// </summary>
    public string? Reason { get; set; }

    /// <summary>
    /// วัตถุประสงค์
    /// </summary>
    public string? Objective { get; set; }

    /// <summary>
    /// เป้าหมาย
    /// </summary>
    public string? ProjectTarget { get; set; }

    /// <summary>
    /// ตัวชี้วัด
    /// </summary>
    public string? ProjectKpi { get; set; }

    /// <summary>
    /// สถานที่ดำเนินงาน
    /// </summary>
    public string? ProjectPlace { get; set; }

    /// <summary>
    /// ระยะเวลาดำเนินการ (เดือน)
    /// </summary>
    public int? TimeFrame { get; set; }

    /// <summary>
    /// วันที่คาดว่าจะเริ่มต้น
    /// </summary>
    public DateTime? ExpectedStartDate { get; set; }

    /// <summary>
    /// ผลงานในปีที่ผ่านมา
    /// </summary>
    public string? Achievement { get; set; }

    /// <summary>
    /// ผลผลิตของโครงการ
    /// </summary>
    public string? ProjectOutput { get; set; }

    /// <summary>
    /// ผลลัพธ์ของโครงการ
    /// </summary>
    public string? ProjectOutcome { get; set; }

    /// <summary>
    /// รูปแบบโครงการ (S=ดำเนินการเอง, P=จ้างที่ปรึกษา)
    /// </summary>
    public string? OperationType { get; set; }

    /// <summary>
    /// วิธีจัดซื้อจัดจ้าง อ้างอิง MasterProcurementMethod.Id
    /// </summary>
    public int? ProcurementMethodId { get; set; }

    /// <summary>
    /// หมายเหตุแผนการจัดซื้อจัดจ้าง
    /// </summary>
    public string? ProcurementPlanRemark { get; set; }

    /// <summary>
    /// รวมเงินคำของบประมาณ (บาท)
    /// </summary>
    public decimal? TotalRequestAmount { get; set; }

    /// <summary>
    /// รวมเงินงบประมาณที่ได้รับจัดสรร (บาท)
    /// </summary>
    public decimal? TotalAllocateAmount { get; set; }
}
