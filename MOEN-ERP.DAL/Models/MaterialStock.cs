using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// สต๊อกวัสดุ
/// </summary>
public partial class MaterialStock
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
    /// วันที่รับ
    /// </summary>
    public DateTime? ReceiveDate { get; set; }

    /// <summary>
    /// จำนวนรับเข้าทั้งหมดในล็อตนั้น
    /// </summary>
    public int? StockIn { get; set; }

    /// <summary>
    /// จำนวนเบิกออกทั้งหมดในล็อตนั้น
    /// </summary>
    public int? StockOut { get; set; }

    /// <summary>
    /// จำนวนคงเหลือในล็อตนั้น
    /// </summary>
    public int? Available { get; set; }

    /// <summary>
    /// หน่วยนับ อ้างอิง MasterUnit.Id
    /// </summary>
    public int? UnitId { get; set; }

    /// <summary>
    /// คลังที่เก็บวัสดุ อ้างอิง MasterWarehouse.Id
    /// </summary>
    public int? WarehouseId { get; set; }

    /// <summary>
    /// ใบเบิก อ้างอิง MaterialRequisition.Id
    /// </summary>
    public int? RequisitionId { get; set; }

    /// <summary>
    /// รายการจากใบรับเข้าคลัง อ้างอิง MaterialInItem.Id
    /// </summary>
    public int? MaterialInItemId { get; set; }

    /// <summary>
    /// รายการจากใบเบิก อ้างอิง MaterialRequisitionItem.Id ดูว่ารับเข้าจากใบเบิกรายการใด
    /// </summary>
    public int? RequisitionItemId { get; set; }

    /// <summary>
    /// 1 = หน่วยงานจัดซื้อ 2 = หน่วยงานส่วนกลาง 3 = หน่วยงานจังหวัด
    /// </summary>
    public string? WarehouseLevel { get; set; }

    /// <summary>
    /// ราคาก่อน VAT
    /// </summary>
    public decimal? UnitPriceNoVat { get; set; }

    /// <summary>
    /// ราคาต่อหน่วย
    /// </summary>
    public decimal? UnitPrice { get; set; }

    /// <summary>
    /// ราคารวม
    /// </summary>
    public decimal? TotalPrice { get; set; }
}
