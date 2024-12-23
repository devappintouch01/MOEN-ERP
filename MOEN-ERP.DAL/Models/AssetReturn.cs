using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// การส่งคืนครุภัณฑ์
/// </summary>
public partial class AssetReturn
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
    /// เลขที่ใบส่งคืน
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
    /// ประเภทการส่งคืน (R=ส่งคืนพัสดุ, C=เปลี่ยนผู้เบิก)
    /// </summary>
    public string? AssetReturnType { get; set; }

    /// <summary>
    /// หน่วยงานที่ส่งคืนพัสดุ อ้างอิง MasterOrganization.Id 
    /// </summary>
    public int? ReturnOrganizationId { get; set; }

    /// <summary>
    /// ผู้ส่งคืนพัสดุ อ้างอิง Officer.Id 
    /// </summary>
    public int? ReturnOfficerId { get; set; }

    /// <summary>
    /// ชื่อผู้ส่งคืนพัสดุ
    /// </summary>
    public string? ReturnOfficerName { get; set; }

    /// <summary>
    /// วันที่ส่งคืน
    /// </summary>
    public DateTime? ReturnDate { get; set; }

    /// <summary>
    /// ผู้เบิกต่อ อ้างอิง Officer.Id
    /// </summary>
    public int? NewResponsibleOfficerId { get; set; }

    /// <summary>
    /// หน่วยงานของผู้เบิกต่อ อ้างอิง MasterOrganization.Id 
    /// </summary>
    public int? NewResponsibleOrganizationId { get; set; }

    /// <summary>
    /// วันที่รับเป็นผู้เบิกต่อ
    /// </summary>
    public DateTime? AcceptDate { get; set; }

    /// <summary>
    /// ผู้ตรวจสอบสภาพการชำรุด อ้างอิง Officer.Id 
    /// </summary>
    public int? CheckOfficerId { get; set; }

    /// <summary>
    /// ชื่อผู้ตรวจสอบสภาพการชำรุด
    /// </summary>
    public string? CheckOfficerName { get; set; }

    /// <summary>
    /// วันที่ตรวจสอบสภาพการชำรุด
    /// </summary>
    public DateTime? CheckDate { get; set; }

    /// <summary>
    /// ผู้ตรวจสอบ อ้างอิง Officer.Id 
    /// </summary>
    public int? ApproveOfficerId { get; set; }

    /// <summary>
    /// ชื่อผู้ตรวจสอบ
    /// </summary>
    public string? ApproveOfficerName { get; set; }

    /// <summary>
    /// วันที่ตรวจสอบ
    /// </summary>
    public DateTime? ApproveDate { get; set; }

    /// <summary>
    /// ผู้รับคืน อ้างอิง Officer.Id 
    /// </summary>
    public int? ReceiveOfficerId { get; set; }

    /// <summary>
    /// ชื่อผู้รับคืน
    /// </summary>
    public string? ReceiveOfficerName { get; set; }

    /// <summary>
    /// วันที่รับคืน
    /// </summary>
    public DateTime? ReceiveDate { get; set; }
}
