using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// แผนการใช้จ่ายงบประมาณ
/// </summary>
public partial class BudgetDisbursementPlan
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
    /// สถานะดำเนินการ อ้างอิง MasterStatus.Id
    /// </summary>
    public int? StatusId { get; set; }

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
    /// เป็นการปรับแผน (True=ใช่, False=ไม่ใช่)
    /// </summary>
    public bool? IsChange { get; set; }

    /// <summary>
    /// การปรับแผนครั้งที่
    /// </summary>
    public int? ChangeNumber { get; set; }

    /// <summary>
    /// รหัสอ้างอิงในระบบที่ไปสังกัด อ้างอิง BudgetDisbursementPlan.Id
    /// </summary>
    public int? ParentBudgetDisbursementPlan { get; set; }
}
