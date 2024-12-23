using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// การยืม-คืนครุภัณฑ์
/// </summary>
public partial class AssetBorrow
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
    /// เลขที่เอกสาร
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
    /// วันที่ใบยืม
    /// </summary>
    public DateTime? DocumentDate { get; set; }

    /// <summary>
    /// ประเภทการยืม (I=เพื่อใช้ภายในส่วนราชการ, O=เพื่อนำออกไปใช้ภายนอกส่วนราชการ, D=ยืมระหว่างกรม)
    /// </summary>
    public string? AssetBorrowType { get; set; }

    /// <summary>
    /// ผู้ขอยืม อ้างอิง Officer.Id 
    /// </summary>
    public int? BorrowerOfficerId { get; set; }

    /// <summary>
    /// ชื่อผู้ขอยืม
    /// </summary>
    public string? BorrowerOfficerName { get; set; }

    /// <summary>
    /// ตำแหน่งผู้ขอยืม
    /// </summary>
    public string? BorrowerPositionName { get; set; }

    /// <summary>
    /// หน่วยงานผู้ขอยืม อ้างอิง MasterOrganization.Id 
    /// </summary>
    public int? BorrowerOrganizationId { get; set; }

    /// <summary>
    /// กลุ่ม/ฝ่าย/ส่วนของผู้ขอยืม
    /// </summary>
    public string? BorrowerDivisionName { get; set; }

    /// <summary>
    /// ประเภทเจ้าหน้าที่ของผู้ขอยืม (O=ข้าราชการ, E=พนักงานราชการ, P=ลูกจ้างประจำ)
    /// </summary>
    public string? BorrowerOfficerType { get; set; }

    /// <summary>
    /// เบอร์โทรศัพท์ภายในของผู้ขอยืม
    /// </summary>
    public string? BorrowerPhoneExtension { get; set; }

    /// <summary>
    /// เบอร์โทรศัพท์มือถือของผู้ขอยืม
    /// </summary>
    public string? BorrowerMobile { get; set; }

    /// <summary>
    /// อีเมลของผู้ขอยืม
    /// </summary>
    public string? BorrowerEmail { get; set; }

    /// <summary>
    /// เนื่องจาก
    /// </summary>
    public string? Detail { get; set; }

    /// <summary>
    /// ยืมตั้งแต่วันที่
    /// </summary>
    public DateTime? BorrowFromDate { get; set; }

    /// <summary>
    /// วันที่กำหนดส่งคืน
    /// </summary>
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// ประเภทผู้ยืม (S=ตนเอง, O=ผู้อื่น)
    /// </summary>
    public string? BorrowerType { get; set; }

    /// <summary>
    /// เอกสารการยืม
    /// </summary>
    public string? BorrowDocument { get; set; }

    /// <summary>
    /// ชื่อ - นามสกุลของผู้อื่น (กรณียืมให้ผู้อื่น)
    /// </summary>
    public string? OtherName { get; set; }

    /// <summary>
    /// ตำแหน่งของผู้อื่น (กรณียืมให้ผู้อื่น)
    /// </summary>
    public string? OtherPositionName { get; set; }

    /// <summary>
    /// เบอร์โทรศัพท์ภายในของผู้อื่น (กรณียืมให้ผู้อื่น)
    /// </summary>
    public string? OtherPhoneExtension { get; set; }

    /// <summary>
    /// เบอร์โทรศัพท์มือถือของผู้อื่น (กรณียืมให้ผู้อื่น)
    /// </summary>
    public string? OtherMobile { get; set; }

    /// <summary>
    /// อีเมลของผู้อื่น (กรณียืมให้ผู้อื่น)
    /// </summary>
    public string? OtherEmail { get; set; }

    /// <summary>
    /// ผู้บังคับบัญชาของผู้ยืม อ้างอิง Officer.Id 
    /// </summary>
    public int? BorrowApproveOfficerId { get; set; }

    /// <summary>
    /// ชื่อผู้บังคับบัญชาของผู้ยืม
    /// </summary>
    public string? BorrowApproveOfficerName { get; set; }

    /// <summary>
    /// วันที่ผู้บังคับบัญชาของผู้ยืมพิจารณา
    /// </summary>
    public DateTime? BorrowApproveDate { get; set; }

    /// <summary>
    /// ผู้ให้ยืม/ผู้เบิก อ้างอิง Officer.Id 
    /// </summary>
    public int? LenderOfficerId { get; set; }

    /// <summary>
    /// ชื่อผู้ให้ยืม/ผู้เบิก
    /// </summary>
    public string? LenderOfficerName { get; set; }

    /// <summary>
    /// วันที่ให้ยืม/เบิก
    /// </summary>
    public DateTime? LendDate { get; set; }

    /// <summary>
    /// หน่วยงานผู้ให้ยืม อ้างอิง MasterOrganization.Id 
    /// </summary>
    public int? LenderOrganizationId { get; set; }

    /// <summary>
    /// ผอ./หัวหน้าของผู้ให้ยืม อ้างอิง Officer.Id 
    /// </summary>
    public int? LendApproveOfficerId { get; set; }

    /// <summary>
    /// ชื่อผอ./หัวหน้าของผู้ให้ยืม
    /// </summary>
    public string? LendApproveOfficerName { get; set; }

    /// <summary>
    /// วันที่ผอ./หัวหน้าของผู้ให้ยืมพิจารณา
    /// </summary>
    public DateTime? LendApproveDate { get; set; }

    /// <summary>
    /// ผู้รับมอบ อ้างอิง Officer.Id 
    /// </summary>
    public int? ReceiveOfficerId { get; set; }

    /// <summary>
    /// ชื่อผู้รับมอบ
    /// </summary>
    public string? ReceiveOfficerName { get; set; }

    /// <summary>
    /// วันที่รับมอบ
    /// </summary>
    public DateTime? ReceiveDate { get; set; }

    /// <summary>
    /// หมายเหตุ
    /// </summary>
    public string? Remark { get; set; }
}
