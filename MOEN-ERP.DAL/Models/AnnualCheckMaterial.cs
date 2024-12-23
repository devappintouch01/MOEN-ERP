using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// วัสดุที่ตรวจสอบประจำปี
/// </summary>
public partial class AnnualCheckMaterial
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
    /// การตรวจสอบประจำปีของหน่วยงาน อ้างอิง AnnualCheckOrganization.Id
    /// </summary>
    public int? AnnualCheckOrganizationId { get; set; }

    /// <summary>
    /// คลังที่เก็บวัสดุ อ้างอิง MasterWarehouse.Id
    /// </summary>
    public int? WarehouseId { get; set; }

    /// <summary>
    /// รหัสวัสดุ อ้างอิง Material.Id
    /// </summary>
    public int? MaterialId { get; set; }

    /// <summary>
    /// หน่วยนับ อ้างอิง MasterUnit.Id
    /// </summary>
    public int? UnitId { get; set; }

    /// <summary>
    /// จำนวนหน่วย
    /// </summary>
    public int? Available { get; set; }

    /// <summary>
    /// การตรวจสอบ (True=ตรวจสอบแล้ว, False=ยังไม่ตรวจสอบ)
    /// </summary>
    public bool? IsCheck { get; set; }

    /// <summary>
    /// สถานะการตรวจสอบ (Y=ครบ, N=ไม่ครบ)
    /// </summary>
    public string? CheckStatus { get; set; }

    /// <summary>
    /// คำชี้แจง
    /// </summary>
    public string? Remark { get; set; }
}
