using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// รายละเอียดแผนการจัดซื้อจัดจ้าง
/// </summary>
public partial class ProjectProcurementPlanItem
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
    /// วิธีจัดซื้อจัดจ้าง อ้างอิง MasterProcurementMethod.Id
    /// </summary>
    public int? ProcurementMethodId { get; set; }

    /// <summary>
    /// ขั้นตอนการจัดซื้อจัดจ้าง อ้างอิง MasterProcurementMethodStep.Id
    /// </summary>
    public int? ProcurementMethodStepId { get; set; }

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
}
