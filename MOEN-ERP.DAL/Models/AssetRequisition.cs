using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// การเบิกจ่ายครุภัณฑ์
/// </summary>
public partial class AssetRequisition
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
    /// รายละเอียด
    /// </summary>
    public string? Detail { get; set; }

    /// <summary>
    /// รายละเอียดสถานที่จัดเก็บ/ใช้งาน
    /// </summary>
    public string? StorePlaceDetail { get; set; }

    /// <summary>
    /// หน่วยงานที่เบิกพัสดุ อ้างอิง MasterOrganization.Id 
    /// </summary>
    public int? RequestOrganizationId { get; set; }

    /// <summary>
    /// ผู้เบิกพัสดุ อ้างอิง Officer.Id 
    /// </summary>
    public int? RequestOfficerId { get; set; }

    /// <summary>
    /// ชื่อผู้เบิกพัสดุ
    /// </summary>
    public string? RequestOfficerName { get; set; }

    /// <summary>
    /// วันที่ขอเบิก/วันที่เอกสาร
    /// </summary>
    public DateTime? RequestDate { get; set; }

    /// <summary>
    /// ต้องการใช้ภายในวันที่
    /// </summary>
    public DateTime? ExpectDate { get; set; }

    /// <summary>
    /// ผู้สั่งจ่าย อ้างอิง Officer.Id 
    /// </summary>
    public int? DeliverApproveOfficerId { get; set; }

    /// <summary>
    /// ชื่อผู้สั่งจ่าย
    /// </summary>
    public string? DeliverApproveOfficerName { get; set; }

    /// <summary>
    /// วันที่สั่งจ่าย
    /// </summary>
    public DateTime? DeliverApproveDate { get; set; }

    /// <summary>
    /// ผู้จ่ายพัสดุ อ้างอิง Officer.Id 
    /// </summary>
    public int? DeliverOfficerId { get; set; }

    /// <summary>
    /// ชื่อผู้จ่ายพัสดุ
    /// </summary>
    public string? DeliverOfficerName { get; set; }

    /// <summary>
    /// วันที่จ่ายพัสดุ
    /// </summary>
    public DateTime? DeliverDate { get; set; }

    /// <summary>
    /// ผู้รับพัสดุ อ้างอิง Officer.Id 
    /// </summary>
    public int? ReceiveOfficerId { get; set; }

    /// <summary>
    /// ชื่อผู้รับพัสดุ
    /// </summary>
    public string? ReceiveOfficerName { get; set; }

    /// <summary>
    /// วันที่รับพัสดุ
    /// </summary>
    public DateTime? ReceiveDate { get; set; }
}
