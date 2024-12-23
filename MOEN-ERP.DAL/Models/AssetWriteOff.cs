using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// การตัดจำหน่ายครุภัณฑ์
/// </summary>
public partial class AssetWriteOff
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
    /// สถานะการตัดจำหน่าย (D=ร่าง, C=ยืนยันการตัดจำหน่าย)
    /// </summary>
    public string? WriteOffStatus { get; set; }

    /// <summary>
    /// เลขที่ตัดจำหน่าย
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
    /// วันที่ตัดจำหน่าย
    /// </summary>
    public DateTime? WriteOffDate { get; set; }

    /// <summary>
    /// ประเภทการตัดจำหน่าย (S=ขาย, D=บริจาค, T=โอนให้หน่วยงานนอกสป., E=แลกเปลี่ยน, L=สูญหาย)
    /// </summary>
    public string? WriteOffType { get; set; }

    /// <summary>
    /// ประเภทการตัดจำหน่าย อ้างอิง MasterWriteOffType.Id
    /// </summary>
    public int? WriteOffTypeId { get; set; }

    /// <summary>
    /// รายละเอียดเพิ่มเติม/หมายเหตุ
    /// </summary>
    public string? WriteOffDetail { get; set; }

    /// <summary>
    /// หน่วยงานที่รับโอน อ้างอิง MasterOrganization.Id 
    /// </summary>
    public int? DestinationOrganizationId { get; set; }

    /// <summary>
    /// เลขที่เอกสารอ้างอิง
    /// </summary>
    public string? ReferenceDocument { get; set; }

    /// <summary>
    /// วันที่ในเอกสารอ้างอิง
    /// </summary>
    public DateTime? ReferenceDate { get; set; }
}
