using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ประวัติการซ่อมบำรุงสินทรัพย์
/// </summary>
public partial class AssetMaintenance
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
    /// สินทรัพย์ อ้างอิง Asset.Id
    /// </summary>
    public int? AssetId { get; set; }

    /// <summary>
    /// เลขที่แจ้งซ่อม
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// วันที่แจ้งซ่อม
    /// </summary>
    public DateTime? RequestDate { get; set; }

    /// <summary>
    /// วันที่รับแจ้งซ่อม/วันที่ซ่อมบำรุง
    /// </summary>
    public DateTime? ReceiveDate { get; set; }

    /// <summary>
    /// ลักษณะการชำรุด/รายการซ่อมบำรุง
    /// </summary>
    public string? MaintenanceDetail { get; set; }

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
    /// จำนวน
    /// </summary>
    public int? Amount { get; set; }

    /// <summary>
    /// จำนวนเงินรวม
    /// </summary>
    public decimal? TotalCost { get; set; }

    /// <summary>
    /// วันที่ตรวจรับ
    /// </summary>
    public DateTime? ApproveDate { get; set; }

    /// <summary>
    /// วันที่ลงบัญชี
    /// </summary>
    public DateTime? AccountingDate { get; set; }

    /// <summary>
    /// ใบแจ้งซ่อม อ้างอิง AssetMaintenanceForm.Id
    /// </summary>
    public int? AssetMaintenanceFormId { get; set; }

    /// <summary>
    /// หมายเหตุ
    /// </summary>
    public string? Remark { get; set; }
}
