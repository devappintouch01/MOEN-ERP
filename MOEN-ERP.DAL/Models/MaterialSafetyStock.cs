using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// คลังเก็บวัสดุ
/// </summary>
public partial class MaterialSafetyStock
{
    /// <summary>
    /// รหัสอ้างอิงที่ใช้ในระบบ
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// ผู้สร้าง อ้างอิง SysUser.Id
    /// </summary>
    public int? CreateBy { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? CreateOn { get; set; }

    /// <summary>
    /// ผู้แก้ไข อ้างอิง SysUser.Id
    /// </summary>
    public int? UpdateBy { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? UpdateOn { get; set; }

    /// <summary>
    /// รหัสคลัง อ้างอิง MasterWarehouse
    /// </summary>
    public int? WarehouseId { get; set; }

    /// <summary>
    /// รหัสวัสดุ อ้างอิง Material.Id
    /// </summary>
    public int? MaterialId { get; set; }

    /// <summary>
    /// จำนวนต่ำสุด
    /// </summary>
    public int? MinStock { get; set; }

    /// <summary>
    /// จำนวนสูงสุด
    /// </summary>
    public int? MaxStock { get; set; }

    /// <summary>
    /// จำนวนที่เบิกได้ ไม่เกินต่อครั้ง
    /// </summary>
    public int? DrawableAmount { get; set; }
}
