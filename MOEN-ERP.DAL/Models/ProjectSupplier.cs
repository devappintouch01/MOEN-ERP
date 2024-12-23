using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ผู้เสนอราคาในงาน/โครงการ
/// </summary>
public partial class ProjectSupplier
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
    /// งาน/โครงการ อ้างอิง Project.Id 
    /// </summary>
    public int? ProjectId { get; set; }

    /// <summary>
    /// ผู้เสนอราคา อ้างอิง Supplier.Id
    /// </summary>
    public int? SupplierId { get; set; }

    /// <summary>
    /// ชื่อผู้เสนอราคา
    /// </summary>
    public string? SupplierName { get; set; }

    /// <summary>
    /// จำนวนเงิน (บาท)
    /// </summary>
    public decimal? TotalAmount { get; set; }
}
