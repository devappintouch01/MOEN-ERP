using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// การเคลื่อนไหวของวัสดุ
/// </summary>
public partial class MaterialStockMovement
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
    /// รหัสวัสดุ อ้างอิง Material.Id
    /// </summary>
    public int? MaterialId { get; set; }

    /// <summary>
    /// ธุรกรรม I = In, O = Out
    /// </summary>
    public string? TransactionType { get; set; }

    /// <summary>
    /// ชื่อตารางที่อ้างอิง
    /// </summary>
    public string? ReferenceTable { get; set; }

    /// <summary>
    /// รหัสอ้างอิง Id ของตารางที่ระบุ
    /// </summary>
    public int? ReferenceId { get; set; }

    /// <summary>
    /// คลังต้นทาง อ้างอิง MasterWarehouse.Id
    /// </summary>
    public int? SourceWareHouseId { get; set; }

    /// <summary>
    /// คลังปลายทาง อ้างอิง MasterWarehouse.Id
    /// </summary>
    public int? TargetWareHouseId { get; set; }

    /// <summary>
    /// รายการวัสดุคงคลังต้นทาง อ้างอิง MaterialStock.Id
    /// </summary>
    public int? SourceMaterialStockId { get; set; }

    /// <summary>
    /// รายการวัสดุคงคลังปลายทาง อ้างอิง MaterialStock.Id
    /// </summary>
    public int? TargetMaterialStockId { get; set; }

    /// <summary>
    /// จำนวนก่อนปรับปรุงของคลังต้นทาง
    /// </summary>
    public int? BeforeSourceMaterial { get; set; }

    /// <summary>
    /// จำนวนหลังปรับปรุงของคลังต้นทาง
    /// </summary>
    public int? AfterSourceMaterial { get; set; }

    /// <summary>
    /// จำนวนก่อนปรับปรุงของคลังปลายทาง
    /// </summary>
    public int? BeforeTargetMaterial { get; set; }

    /// <summary>
    /// จำนวนหลังปรับปรุงของคลังปลายทาง
    /// </summary>
    public int? AfterTargetMaterial { get; set; }

    /// <summary>
    /// วันที่ดำเนินการ
    /// </summary>
    public DateTime? ProcessDate { get; set; }

    /// <summary>
    /// จำนวนที่รับ-จ่าย
    /// </summary>
    public int? Amount { get; set; }

    /// <summary>
    /// ราคาต่อหน่วย
    /// </summary>
    public decimal? Price { get; set; }
}
