using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// การโอนครุภัณฑ์
/// </summary>
public partial class AssetTransfer
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
    /// วันที่เอกสาร
    /// </summary>
    public DateTime? DocumentDate { get; set; }

    /// <summary>
    /// หน่วยงานที่รับโอน อ้างอิง MasterOrganization.Id 
    /// </summary>
    public int? DestinationOrganizationId { get; set; }

    /// <summary>
    /// เนื่องจาก
    /// </summary>
    public string? Detail { get; set; }

    /// <summary>
    /// ผู้โอน อ้างอิง Officer.Id 
    /// </summary>
    public int? TransferOfficerId { get; set; }

    /// <summary>
    /// ชื่อผู้โอน
    /// </summary>
    public string? TransferOfficerName { get; set; }

    /// <summary>
    /// วันที่โอน
    /// </summary>
    public DateTime? TransferDate { get; set; }

    /// <summary>
    /// ผู้รับโอน อ้างอิง Officer.Id 
    /// </summary>
    public int? ReceiveOfficerId { get; set; }

    /// <summary>
    /// ชื่อผู้รับโอน
    /// </summary>
    public string? ReceiveOfficerName { get; set; }

    /// <summary>
    /// วันที่รับโอน
    /// </summary>
    public DateTime? ReceiveDate { get; set; }
}
