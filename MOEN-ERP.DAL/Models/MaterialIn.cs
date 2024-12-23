using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ใบรับพัสดุ
/// </summary>
public partial class MaterialIn
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
    /// เลขที่ใบรับ
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// วันที่รับ
    /// </summary>
    public DateTime? ReceiveDate { get; set; }

    /// <summary>
    /// เลข Running สำหรับเรียงลำดับ
    /// </summary>
    public int? Running { get; set; }

    /// <summary>
    /// เลขที่สัญญา/ใบสั่งซื้อ/ใบสั่งจ้าง
    /// </summary>
    public string? ProcurementNumber { get; set; }

    /// <summary>
    /// วันที่สัญญา/ใบสั่งซื้อ/ใบสั่งจ้าง
    /// </summary>
    public DateTime? PurchaseDate { get; set; }

    /// <summary>
    /// รหัสผู้จำหน่าย อ้างอิง Supplier.Id
    /// </summary>
    public int? SupplierId { get; set; }

    /// <summary>
    /// ชื่อผู้ขาย/ผู้จำหน่าย/ผู้รับจ้าง
    /// </summary>
    public string? SupplierName { get; set; }

    /// <summary>
    /// สถานะ : N = New (สร้างใหม่), A = Approve (ยืนยันรับ)
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// วันที่กดยืนยันรับ
    /// </summary>
    public DateTime? ApproveDate { get; set; }

    /// <summary>
    /// ประเภทการรับ 1 = รับเข้าจากหน่วยจัดซื้อ, 2 = รับเข้าจากหน่วยงาน
    /// </summary>
    public int? MaterialInType { get; set; }

    /// <summary>
    /// รหัสคลังเก็บวัสดุ อ้างอิง MasterWarehouse.Id
    /// </summary>
    public int? WarehouseId { get; set; }

    /// <summary>
    /// จัดซื้อตามคำสั่งซื้อของหน่วยงาน (ใช่ = True, ไม่ใช่ = False)
    /// </summary>
    public bool? IsPurchasingOrder { get; set; }

    /// <summary>
    /// คลังวัสดุที่สั่งซื้อ อ้างอิง MasterWarehouse.Id
    /// </summary>
    public int? PurchasingWareHouseId { get; set; }

    /// <summary>
    /// 1 = หน่วยงานจัดซื้อ 2 = หน่วยงานส่วนกลาง 3 = หน่วยงานจังหวัด
    /// </summary>
    public string? WarehouseLevel { get; set; }

    /// <summary>
    /// ปีงบประมาณ
    /// </summary>
    public int? BudgetYear { get; set; }
}
