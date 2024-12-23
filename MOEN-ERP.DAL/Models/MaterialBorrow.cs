using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ใบยืมวัสดุ
/// </summary>
public partial class MaterialBorrow
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
    /// เลขที่เอกสาร
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// สถานะ อ้างอิง MasterStatus
    /// </summary>
    public int? StatusId { get; set; }

    /// <summary>
    /// ผู้ยืม อ้างอิง Officer.Id
    /// </summary>
    public int? BorrowerBy { get; set; }

    /// <summary>
    /// หน่วยงานที่ยืม อ้างอิง Organization.Id 
    /// </summary>
    public int? SourceOrganizationId { get; set; }

    /// <summary>
    /// หน่วยงานที่ให้ยืม อ้างอิง Organization.Id 
    /// </summary>
    public int? TargetOrganizationId { get; set; }

    /// <summary>
    /// เหตุผลที่ส่งกลับ
    /// </summary>
    public string? ReturnRemark { get; set; }

    /// <summary>
    /// ผู้อนุมัติยืม อ้างอิง Officer.Id
    /// </summary>
    public int? ApproveBy { get; set; }

    /// <summary>
    /// สถานะการพิจารณา : Y = อนุมัติ, N = ไม่อนุมัติ 
    /// </summary>
    public string? StatusApprove { get; set; }

    /// <summary>
    /// วันที่อนุมัติ
    /// </summary>
    public DateTime? ApproveDate { get; set; }

    /// <summary>
    /// วันที่ส่งกลับ
    /// </summary>
    public DateTime? ReturnDate { get; set; }

    /// <summary>
    /// เลข Running สำหรับเรียงลำดับ
    /// </summary>
    public int? Running { get; set; }

    /// <summary>
    /// วันที่ส่งเรื่อง
    /// </summary>
    public DateTime? SubmitDate { get; set; }

    /// <summary>
    /// วันที่ยืม
    /// </summary>
    public DateTime? BorrowDate { get; set; }

    /// <summary>
    /// ปีงบประมาณ
    /// </summary>
    public int? BudgetYear { get; set; }
}
