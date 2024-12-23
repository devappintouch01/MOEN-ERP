using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// รายละเอียดค่าใช้จ่าย งาน/โครงการกองอนุรักษ์
/// </summary>
public partial class ProjectExpensesItem
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
    /// รายละเอียดค่าใช้จ่าย
    /// </summary>
    public string? ItemDetail { get; set; }

    /// <summary>
    /// รวมจำนวนเงิน (บาท)
    /// </summary>
    public decimal? TotalAmount { get; set; }

    /// <summary>
    /// หน่วยนับ (จำนวนคน)
    /// </summary>
    public int? Quantity { get; set; }

    /// <summary>
    /// จำนวนหน่วย
    /// </summary>
    public int? QuantityUnit { get; set; }

    /// <summary>
    /// หน่วยนับ อ้างอิง MasterUnit.Id 
    /// </summary>
    public int? QuantityUnitId { get; set; }

    /// <summary>
    /// อัตราที่ตั้ง (ราคาต่อหน่วย)
    /// </summary>
    public decimal? ExpenseRate { get; set; }

    /// <summary>
    /// หน่วยนับ อ้างอิง MasterUnit.Id 
    /// </summary>
    public int? ExpenseRateUnitId { get; set; }
}
