using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ผู้ขาย/ผู้จำหน่าย/ผู้รับจ้าง/ผู้บริจาค
/// </summary>
public partial class Supplier
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
    /// สถานะการใช้งาน (True=ใช้งาน, False=ไม่ใช้งาน)
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// ชื่อผู้ขาย/ผู้จำหน่าย/ผู้รับจ้าง/ผู้บริจาค
    /// </summary>
    public string? NameThai { get; set; }

    /// <summary>
    /// ประเภทบุคคล (P=บุคคลธรรมดา, C=นิติบุคคล)
    /// </summary>
    public string? PersonType { get; set; }

    /// <summary>
    /// เลขหลักของผู้ขาย
    /// </summary>
    public string? SupplierCode { get; set; }

    /// <summary>
    /// เลขประจำตัวผู้เสียภาษี
    /// </summary>
    public string? TaxId { get; set; }

    /// <summary>
    /// หมายเลขโทรศัพท์
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// ที่อยู่
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// ตำบล อ้างอิง MasterTambon.Id
    /// </summary>
    public int? TambonId { get; set; }

    /// <summary>
    /// อำเภอ อ้างอิง MasterAmphur.Id
    /// </summary>
    public int? AmphurId { get; set; }

    /// <summary>
    /// จังหวัด อ้างอิง MasterProvice.Id
    /// </summary>
    public int? ProvinceId { get; set; }

    /// <summary>
    /// รหัสไปรษณีย์
    /// </summary>
    public string? ZipCode { get; set; }

    /// <summary>
    /// ที่อยู่ รูปแบบเต็ม
    /// </summary>
    public string? FullAddress { get; set; }

    /// <summary>
    /// อีเมล์
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// ธนาคาร อ้างอิง MasterBank.Id
    /// </summary>
    public string? BankId { get; set; }

    /// <summary>
    /// สาขาธนาคาร
    /// </summary>
    public string? BankBranch { get; set; }

    /// <summary>
    /// เลขบัญชีธนาคาร
    /// </summary>
    public string? BankAccount { get; set; }

    /// <summary>
    /// ชื่อบัญชีธนาคาร
    /// </summary>
    public string? AccountName { get; set; }
}
