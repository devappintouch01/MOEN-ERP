using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// รายการเบิกจ่ายวัสดุ
/// </summary>
public partial class MaterialRequisitionItem
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
    /// ใบเบิก อ้างอิง MaterialRequisition.Id
    /// </summary>
    public int? RequisitionId { get; set; }

    /// <summary>
    /// รายการวัสดุ อ้างอิง Material.Id
    /// </summary>
    public int? MaterialId { get; set; }

    /// <summary>
    /// รหัส GPSC
    /// </summary>
    public string? Gpsccode { get; set; }

    /// <summary>
    /// จำนวนที่ขอเบิก
    /// </summary>
    public int? RequestAmount { get; set; }

    /// <summary>
    /// จำนวนที่จ่ายจริง
    /// </summary>
    public int? ReceiveAmount { get; set; }

    /// <summary>
    /// หน่วยนับ อ้างอิง MasterUnit.Id
    /// </summary>
    public int? UnitId { get; set; }

    /// <summary>
    /// ราคาต่อหน่วย
    /// </summary>
    public decimal? UnitPrice { get; set; }

    /// <summary>
    /// ราคารวม
    /// </summary>
    public decimal? TotalPrice { get; set; }

    /// <summary>
    /// หมายเหตุ
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// วัสดุที่รับเข้า อ้างอิง MaterialInItem.Id
    /// </summary>
    public int? MaterialInItemId { get; set; }

    /// <summary>
    /// รหัสสต๊อก อ้างอิง MaterialStock.Id
    /// </summary>
    public int? MaterialStockId { get; set; }
}
