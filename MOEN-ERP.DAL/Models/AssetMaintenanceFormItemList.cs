using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// รายการครุภัณฑ์แจ้งซ่อม
/// </summary>
public partial class AssetMaintenanceFormItemList
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
    /// ครุภัณฑ์ที่แจ้งซ่อม อ้างอิง AssetMaintenanceFormItem.Id
    /// </summary>
    public int? AssetMaintenanceFormItemId { get; set; }

    /// <summary>
    /// สินทรัพย์ อ้างอิง Asset.Id
    /// </summary>
    public int? AssetId { get; set; }

    /// <summary>
    /// ลักษณะการชำรุด/รายการซ่อมบำรุง
    /// </summary>
    public string? MaintenanceDetail { get; set; }

    /// <summary>
    /// ราคาต่อหน่วย
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
}
