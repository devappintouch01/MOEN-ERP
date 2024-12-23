using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ใบแจ้งซ่อม
/// </summary>
public partial class AssetMaintenanceForm
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
    /// เลขที่แจ้งซ่อม
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
    /// เรื่อง
    /// </summary>
    public string? Subject { get; set; }

    /// <summary>
    /// รายละเอียด
    /// </summary>
    public string? Detail { get; set; }

    /// <summary>
    /// หน่วยงานที่แจ้งซ่อม อ้างอิง MasterOrganization.Id 
    /// </summary>
    public int? RequestOrganizationId { get; set; }

    /// <summary>
    /// ผู้แจ้งซ่อม อ้างอิง Officer.Id 
    /// </summary>
    public int? RequestOfficerId { get; set; }

    /// <summary>
    /// ชื่อผู้แจ้งซ่อม
    /// </summary>
    public string? RequestOfficerName { get; set; }

    /// <summary>
    /// วันที่แจ้งซ่อม
    /// </summary>
    public DateTime? RequestDate { get; set; }

    /// <summary>
    /// หัวหน้าหน่วยงานที่แจ้งซ่อม อ้างอิง Officer.Id 
    /// </summary>
    public int? RequestDirectorId { get; set; }

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
    /// ผู้รับแจ้งซ่อม อ้างอิง Officer.Id 
    /// </summary>
    public int? ReceiveOfficerId { get; set; }

    /// <summary>
    /// ชื่อผู้รับแจ้งซ่อม
    /// </summary>
    public string? ReceiveOfficerName { get; set; }

    /// <summary>
    /// วันที่รับแจ้งซ่อม
    /// </summary>
    public DateTime? ReceiveDate { get; set; }

    /// <summary>
    /// หัวหน้าหน่วยงานพัสดุ อ้างอิง Officer.Id 
    /// </summary>
    public int? ReceiveDirectorId { get; set; }

    /// <summary>
    /// ผู้รับจ้างซ่อม อ้างอิง Supplier.Id
    /// </summary>
    public int? SupplierId { get; set; }

    /// <summary>
    /// ชื่อผู้รับจ้างซ่อม
    /// </summary>
    public string? SupplierName { get; set; }

    /// <summary>
    /// วันที่คาดว่าจะ:ซ่อมแล้วเสร็จ
    /// </summary>
    public DateTime? ExpectDate { get; set; }

    /// <summary>
    /// วันที่ส่งคืนสินทรัพย์
    /// </summary>
    public DateTime? ReturnDate { get; set; }

    /// <summary>
    /// วันที่รับคืนสินทรัพย์
    /// </summary>
    public DateTime? ReturnCompleteDate { get; set; }
}
