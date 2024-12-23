using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// โครงการจัดซื้อ/จัดจ้าง
/// </summary>
public partial class Procurement
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
    /// เลขที่สัญญา
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// ชื่องาน/โครงการที่จัดซื้อจัดจ้าง
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// ปีงบประมาณ
    /// </summary>
    public int? BudgetYear { get; set; }

    /// <summary>
    /// วันที่สัญญา/ใบสั่งซื้อ
    /// </summary>
    public DateTime? ContractDate { get; set; }

    /// <summary>
    /// วันที่เริ่มต้นสัญญา
    /// </summary>
    public DateTime? ProcurementStartDate { get; set; }

    /// <summary>
    /// วันที่สิ้นสุดสัญญา
    /// </summary>
    public DateTime? ProcurementEndDate { get; set; }

    /// <summary>
    /// วิธีจัดซื้อจัดจ้าง อ้างอิง MasterProcurementMethod.Id
    /// </summary>
    public int? ProcurementMethodId { get; set; }

    /// <summary>
    /// ผู้ขาย/ผู้รับจ้าง/ผู้บริจาค อ้างอิง Supplier.Id
    /// </summary>
    public int? SupplierId { get; set; }

    /// <summary>
    /// ชื่อผู้ขาย/ผู้รับจ้าง/ผู้บริจาค
    /// </summary>
    public string? SupplierName { get; set; }
}
