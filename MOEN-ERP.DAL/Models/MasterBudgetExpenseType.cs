using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// รายการค่าใช้จ่าย
/// </summary>
public partial class MasterBudgetExpenseType
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
    /// ชื่อรายการค่าใช้จ่าย
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// ประเภทงบ อ้างอิง MasterBudgetType.Id
    /// </summary>
    public int? BudgetTypeId { get; set; }

    /// <summary>
    /// ประเภทงบรายจ่าย อ้างอิง MasterExpenseType.Id
    /// </summary>
    public int? ExpenseTypeId { get; set; }

    /// <summary>
    /// ยุทธศาสตร์ อ้างอิง MasterStrategyCode.Id
    /// </summary>
    public int? StrategyCodeId { get; set; }

    /// <summary>
    /// แผนงาน อ้างอิง MasterStrategicPlanCode.Id
    /// </summary>
    public int? StrategicPlanCodeId { get; set; }

    /// <summary>
    /// ผลผลิต/โครงการ อ้างอิง MasterOutputCode.Id
    /// </summary>
    public int? OutputCodeId { get; set; }

    /// <summary>
    /// แหล่งเงิน อ้างอิง MasterMoneySource.Id
    /// </summary>
    public int? MoneySourceId { get; set; }

    /// <summary>
    /// ระดับชั้นของรายการค่าใช้จ่าย
    /// </summary>
    public int? BudgetExpenseLevel { get; set; }

    /// <summary>
    /// รายการค่าใช้จ่ายที่รายการนี้ไปสังกัด อ้างอิง MasterBudgetExpenseType.Id
    /// </summary>
    public long? ParentId { get; set; }

    /// <summary>
    /// มีรายการค่าใช้จ่ายในสังกัดหรือไม่ (True=มี, False=ไม่มี)
    /// </summary>
    public bool? IsParent { get; set; }

    /// <summary>
    /// แบบฟอร์มคำของบประมาณ อ้างอิง MasterBudgetFormType.Id
    /// </summary>
    public int? BudgetFormTypeId { get; set; }
}
