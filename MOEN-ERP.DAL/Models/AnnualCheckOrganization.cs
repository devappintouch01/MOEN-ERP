using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// การตรวจสอบประจำปีของหน่วยงาน
/// </summary>
public partial class AnnualCheckOrganization
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
    /// สถานะการตรวจสอบประจำปี (A=อยู่ระหว่างดำเนินการ, C=รับรองผล)
    /// </summary>
    public string? AnnualCheckStatus { get; set; }

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
    /// วันที่เริ่มต้น
    /// </summary>
    public DateTime? AnnualCheckFromDate { get; set; }

    /// <summary>
    /// วันที่สิ้นสุด
    /// </summary>
    public DateTime? AnnualCheckToDate { get; set; }

    /// <summary>
    /// หมายเหตุ
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// การรับรองผล (True=รับรองผล, False=ยังไม่รับรองผล)
    /// </summary>
    public bool? IsApprove { get; set; }

    /// <summary>
    /// วันที่รับรองผล
    /// </summary>
    public DateTime? ApproveDate { get; set; }

    /// <summary>
    /// การตรวจสอบประจำปี อ้างอิง AnnualCheck.Id
    /// </summary>
    public int? AnnualCheckId { get; set; }

    /// <summary>
    /// หน่วยงานในการตรวจสอบประจำปี อ้างอิง MasterOrganization.Id 
    /// </summary>
    public int? OrganizationId { get; set; }

    /// <summary>
    /// จำนวนสิ่งปลูกสร้างทั้งหมด
    /// </summary>
    public int? TotalBuilding { get; set; }

    /// <summary>
    /// จำนวนสิ่งปลูกสร้างที่ชำรุด
    /// </summary>
    public int? TotalUnusableBuilding { get; set; }

    /// <summary>
    /// จำนวนครุภัณฑ์ทั้งหมด
    /// </summary>
    public int? TotalDurable { get; set; }

    /// <summary>
    /// จำนวนครุภัณฑ์ที่ชำรุด
    /// </summary>
    public int? TotalUnusableDurable { get; set; }

    /// <summary>
    /// จำนวนครุภัณฑ์ที่ไม่พบ
    /// </summary>
    public int? TotalNotFoundDurable { get; set; }

    /// <summary>
    /// จำนวนครุภัณฑ์ที่ส่งคืน
    /// </summary>
    public int? TotalReturnDurable { get; set; }
}
