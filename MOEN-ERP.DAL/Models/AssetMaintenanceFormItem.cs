using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ครุภัณฑ์ที่แจ้งซ่อม
/// </summary>
public partial class AssetMaintenanceFormItem
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
    /// ใบแจ้งซ่อม อ้างอิง AssetMaintenanceForm.Id
    /// </summary>
    public int? AssetMaintenanceFormId { get; set; }

    /// <summary>
    /// สินทรัพย์ อ้างอิง Asset.Id
    /// </summary>
    public int? AssetId { get; set; }

    /// <summary>
    /// ลักษณะการชำรุด/รายการซ่อมบำรุง
    /// </summary>
    public string? MaintenanceDetail { get; set; }

    /// <summary>
    /// ตรวจสอบสภาพการชำรุด (True=ตรวจสอบแล้ว, False=ยังไม่ตรวจสอบ)
    /// </summary>
    public bool? Ischeck { get; set; }

    /// <summary>
    /// ผลการตรวจสอบสภาพการชำรุด
    /// </summary>
    public string? CheckDatail { get; set; }

    /// <summary>
    /// สภาพทรัพย์สิน (True=ปกติ, N=ชำรุด)
    /// </summary>
    public bool? IsUsable { get; set; }

    /// <summary>
    /// ลักษณะการชำรุด
    /// </summary>
    public string? CheckMaintenanceDatail { get; set; }

    /// <summary>
    /// ผู้รับจ้างซ่อม อ้างอิง Supplier.Id
    /// </summary>
    public int? SupplierId { get; set; }

    /// <summary>
    /// ชื่อผู้รับจ้างซ่อม
    /// </summary>
    public string? SupplierName { get; set; }

    /// <summary>
    /// ค่าใช้จ่ายในการซ่อมบำรุง (บาท)
    /// </summary>
    public decimal? Cost { get; set; }

    /// <summary>
    /// วันที่ตรวจรับ
    /// </summary>
    public DateTime? ApproveDate { get; set; }

    /// <summary>
    /// วันที่ลงบัญชี
    /// </summary>
    public DateTime? AccountingDate { get; set; }
}
