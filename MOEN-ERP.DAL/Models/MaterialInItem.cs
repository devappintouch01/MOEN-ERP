using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// รายการวัสดุที่รับเข้า
/// </summary>
public partial class MaterialInItem
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
    /// รายการวัสดุ อ้างอิง Material.Id
    /// </summary>
    public int? MaterialId { get; set; }

    /// <summary>
    /// รหัส GPSC
    /// </summary>
    public string? Gpsccode { get; set; }

    /// <summary>
    /// จำนวนที่รับ
    /// </summary>
    public int? ReceiveAmount { get; set; }

    /// <summary>
    /// หน่วยนับ อ้างอิง MasterUnit.Id
    /// </summary>
    public int? UnitId { get; set; }

    /// <summary>
    /// ราคาก่อน VAT
    /// </summary>
    public decimal? UnitPriceNoVat { get; set; }

    /// <summary>
    /// คิด VAT : Y = คิด, N = ไม่คิด
    /// </summary>
    public string? IncludeVat { get; set; }

    /// <summary>
    /// VAT (เปอร์เซ็นต์)
    /// </summary>
    public double? Vat { get; set; }

    /// <summary>
    /// ราคาต่อหน่วย
    /// </summary>
    public decimal? UnitPrice { get; set; }

    /// <summary>
    /// ราคารวม
    /// </summary>
    public decimal? TotalPrice { get; set; }

    /// <summary>
    /// ใบรับพัสดุ อ้างอิง MaterialIn.Id
    /// </summary>
    public int MaterialInId { get; set; }
}
