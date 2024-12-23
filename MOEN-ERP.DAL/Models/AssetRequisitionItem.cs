using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ครุภัณฑ์ที่เบิกจ่าย
/// </summary>
public partial class AssetRequisitionItem
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
    /// การเบิกจ่ายครุภัณฑ์ อ้างอิง AssetRequisition.Id
    /// </summary>
    public int? AssetRequisitionId { get; set; }

    /// <summary>
    /// สินทรัพย์ อ้างอิง Asset.Id
    /// </summary>
    public int? AssetId { get; set; }

    /// <summary>
    /// หมายเหตุ
    /// </summary>
    public string? Remark { get; set; }
}
