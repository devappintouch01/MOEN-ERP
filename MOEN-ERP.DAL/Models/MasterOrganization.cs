using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// หน่วยงาน
/// </summary>
public partial class MasterOrganization
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
    /// รหัสหน่วยงาน
    /// </summary>
    public string? OrganizationCode { get; set; }

    /// <summary>
    /// ชื่อหน่วยงานภาษาไทย
    /// </summary>
    public string? NameThai { get; set; }

    /// <summary>
    /// ชื่อหน่วยงานภาษาอังกฤษ
    /// </summary>
    public string? NameEnglish { get; set; }

    /// <summary>
    /// ชื่อย่อหน่วยงาน
    /// </summary>
    public string? Abbreviation { get; set; }

    /// <summary>
    /// รหัสพื้นที่
    /// </summary>
    public string? AreaCode { get; set; }

    /// <summary>
    /// ศูนย์ต้นทุน อ้างอิง MasterCostCenter.Id
    /// </summary>
    public int? CostCenterId { get; set; }

    /// <summary>
    /// ระดับชั้นหน่วยงาน (1=สำนักงาน/กรม, 2=สำนัก/กอง/ศูนย์, 3=ส่วน/กลุ่ม/ฝ่าย)
    /// </summary>
    public string? OrganizationLevel { get; set; }

    /// <summary>
    /// รหัสหน่วยงานต้นสังกัด อ้างอิง MasterOrganization.Id
    /// </summary>
    public int? ParentOrganization { get; set; }

    /// <summary>
    /// การเรียงลำดับในระบบงบประมาณ
    /// </summary>
    public int? BudgetSequence { get; set; }

    /// <summary>
    /// ผู้อำนวยการ อ้างอิง Officer.Id
    /// </summary>
    public int? DirectorId { get; set; }
}
