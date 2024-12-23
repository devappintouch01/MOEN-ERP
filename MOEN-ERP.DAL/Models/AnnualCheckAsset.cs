using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ครุภัณฑ์ที่ตรวจสอบประจำปี
/// </summary>
public partial class AnnualCheckAsset
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
    /// การตรวจสอบประจำปีของแต่ละหน่วยงาน อ้างอิง AnnualCheckOrganization.Id
    /// </summary>
    public int? AnnualCheckOrganizationId { get; set; }

    /// <summary>
    /// สินทรัพย์ อ้างอิง Asset.Id
    /// </summary>
    public int? AssetId { get; set; }

    /// <summary>
    /// หน่วยงานเดิม อ้างอิง MasterOrganization.Id 
    /// </summary>
    public int? OldOrganizationId { get; set; }

    /// <summary>
    /// สถานที่จัดเก็บ/ใช้งานเดิม อ้างอิงตาราง MasterStorePlace.Id
    /// </summary>
    public int? OldStorePlaceId { get; set; }

    /// <summary>
    /// รายละเอียดสถานที่จัดเก็บ/ใช้งานเดิม
    /// </summary>
    public string? OldStorePlaceDetail { get; set; }

    /// <summary>
    /// การตรวจสอบ (True=ตรวจสอบแล้ว, False=ยังไม่ตรวจสอบ)
    /// </summary>
    public bool? IsCheck { get; set; }

    /// <summary>
    /// สถานะการตรวจสอบ (Y=พบ, N=ไม่พบ, W=พบผิดที่)
    /// </summary>
    public string? CheckStatus { get; set; }

    /// <summary>
    /// สภาพทรัพย์สิน (True=ปกติ, N=ชำรุด)
    /// </summary>
    public bool? IsUsable { get; set; }

    /// <summary>
    /// ลักษณะการชำรุด
    /// </summary>
    public string? UnusableDetail { get; set; }

    /// <summary>
    /// สถานะการส่งคืน (True=ส่งคืน, N=ไม่ส่งคืน)
    /// </summary>
    public bool? IsReturn { get; set; }

    /// <summary>
    /// เหตุผลที่ส่งคืน อ้างอิง MasterReturnReason.Id
    /// </summary>
    public int? ReturnReasonId { get; set; }

    /// <summary>
    /// เปลี่ยนสถานที่จัดเก็บ/ใช้งาน (True=เปลี่ยน, N=ไม่เปลี่ยน)
    /// </summary>
    public bool? IsChangeStorePlace { get; set; }

    /// <summary>
    /// หน่วยงานใหม่ อ้างอิง MasterOrganization.Id 
    /// </summary>
    public int? NewOrganizationId { get; set; }

    /// <summary>
    /// สถานที่จัดเก็บ/ใช้งานใหม่ อ้างอิงตาราง MasterStorePlace.Id
    /// </summary>
    public int? NewStorePlaceId { get; set; }

    /// <summary>
    /// รายละเอียดสถานที่จัดเก็บ/ใช้งานใหม่
    /// </summary>
    public string? NewStorePlaceDetail { get; set; }
}
