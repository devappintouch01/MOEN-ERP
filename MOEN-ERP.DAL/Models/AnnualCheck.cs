using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// การตรวจสอบประจำปี
/// </summary>
public partial class AnnualCheck
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
    /// การสร้างรายการตรวจนับ (True=สร้างแล้ว, False=ยังไม่สร้าง)
    /// </summary>
    public bool? IsCreate { get; set; }

    /// <summary>
    /// การรับรองผล (True=รับรองผล, False=ยังไม่รับรองผล)
    /// </summary>
    public bool? IsApprove { get; set; }

    /// <summary>
    /// วันที่รับรองผล
    /// </summary>
    public DateTime? ApproveDate { get; set; }

    /// <summary>
    /// รหัสพื้นที่
    /// </summary>
    public string? AreaCode { get; set; }
}
