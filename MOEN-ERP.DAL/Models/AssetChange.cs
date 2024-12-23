using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ประวัติการเปลี่ยนแปลงสินทรัพย์ (เบิก/โอน/ยืม-คืน/ส่งคืน/ตัดจำหน่าย)
/// </summary>
public partial class AssetChange
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
    /// สินทรัพย์ อ้างอิง Asset.Id
    /// </summary>
    public int? AssetId { get; set; }

    /// <summary>
    /// เลขที่เอกสาร
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// ประเภทการเปลี่ยนแปลง 
    /// (1=เบิก, 2=ยืม, 3=คืน, 4=โอน, 5=ส่งคืน, 6=ตัดจำหน่าย)
    /// 
    /// </summary>
    public int? ChangeType { get; set; }

    /// <summary>
    /// วันที่เปลี่ยนแปลง
    /// </summary>
    public DateTime? ChangeDate { get; set; }

    /// <summary>
    /// รายละเอียดการเปลี่ยนแปลง
    /// </summary>
    public string? ChangeDetail { get; set; }

    /// <summary>
    /// ผู้รับผิดชอบ อ้างอิง Officer.Id
    /// </summary>
    public int? ResponsibleOfficerId { get; set; }

    /// <summary>
    /// ชื่อตารางที่อ้างอิง
    /// </summary>
    public string? ReferenceTable { get; set; }

    /// <summary>
    /// รหัสที่อ้างอิง
    /// </summary>
    public int? ReferenceId { get; set; }

    /// <summary>
    /// หมายเหตุ
    /// </summary>
    public string? Remark { get; set; }
}
