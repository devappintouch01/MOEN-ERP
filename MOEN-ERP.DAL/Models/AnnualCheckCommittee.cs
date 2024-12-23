using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// คณะกรรมการตรวจสอบประจำปี
/// </summary>
public partial class AnnualCheckCommittee
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
    /// การตรวจสอบประจำปี อ้างอิง AnnualCheck.Id
    /// </summary>
    public int? AnnualCheckId { get; set; }

    /// <summary>
    /// หน่วยงานในการตรวจสอบประจำปี อ้างอิง MasterOrganization.Id 
    /// </summary>
    public int? OrganizationId { get; set; }

    /// <summary>
    /// เจ้าหน้าที่ อ้างอิง Officer.Id 
    /// </summary>
    public int? OfficerId { get; set; }

    /// <summary>
    /// ตำแหน่งในชุดคณะกรรมการ (C=คณะกรรมการตรวจสอบประจำปี, P=ประธานคณะกรรมการตรวจสอบประจำปี)
    /// </summary>
    public string? CommitteePosition { get; set; }

    /// <summary>
    /// การรับรองผล (True=รับรองผล, False=ยังไม่รับรองผล)
    /// </summary>
    public bool? IsApprove { get; set; }

    /// <summary>
    /// วันที่รับรองผล
    /// </summary>
    public DateTime? ApproveDate { get; set; }
}
