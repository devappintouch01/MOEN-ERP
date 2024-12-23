using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// เจ้าหน้าที่
/// </summary>
public partial class Officer
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
    /// รหัสอ้างอิงคำนำหน้าชื่อ อ้างอิง MasterNamePrefix.Id
    /// </summary>
    public int? NamePrefixId { get; set; }

    /// <summary>
    /// ชื่อ
    /// </summary>
    public string? FirstName { get; set; }

    /// <summary>
    /// นามสกุล
    /// </summary>
    public string? LastName { get; set; }

    /// <summary>
    /// ชื่อภาษาไทย
    /// </summary>
    public string? FirstNameThai { get; set; }

    /// <summary>
    /// นามสกุลภาษาไทย
    /// </summary>
    public string? LastNameThai { get; set; }

    /// <summary>
    /// รหัสอ้างอิงหน่วยงานที่ใช้ในระบบ อ้างอิง MasterOrganization.Id
    /// </summary>
    public int? OrganizationId { get; set; }

    /// <summary>
    /// รหัสอ้างอิงตำแหน่งทางสายงาน อ้างอิง MasterPosition.Id
    /// </summary>
    public int? WorkPositionId { get; set; }

    /// <summary>
    /// วันที่เริ่มต้นการทำงาน
    /// </summary>
    public DateTime? StartWorkDate { get; set; }

    /// <summary>
    /// วันที่สิ้นสุดการทำงาน
    /// </summary>
    public DateTime? EndWorkDate { get; set; }

    /// <summary>
    /// รหัสอ้างอิงตำแหน่งบริหาร อ้างอิง MasterPosition.Id
    /// </summary>
    public int? ExecutivePositionId { get; set; }

    /// <summary>
    /// หมายเลขโทรศัพท์
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// ที่อยู่
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// หมายเลขบัตรประชาชน
    /// </summary>
    public string? PersonalId { get; set; }

    /// <summary>
    /// วันเกิด
    /// </summary>
    public DateTime? BirthDate { get; set; }

    /// <summary>
    /// รหัสอ้างอิงผู้ใช้งานในระบบ อ้างอิง SystemUser.Id
    /// </summary>
    public int? SystemUserId { get; set; }

    /// <summary>
    /// คำอธิบาย
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// ธนาคารเจ้าของบัญชี อ้างอิง MasterBank.Id
    /// </summary>
    public string? BankId { get; set; }

    /// <summary>
    /// สาขาของบัญชีธนาคาร
    /// </summary>
    public string? BankBranch { get; set; }

    /// <summary>
    /// เลขที่บัญชีธนาคาร
    /// </summary>
    public string? BankAccount { get; set; }

    /// <summary>
    /// Distinguished Name ใน Active Directory
    /// </summary>
    public string? DistinguishedName { get; set; }

    /// <summary>
    /// ชื่อหน่วยงาน ใน Active Directory
    /// </summary>
    public string? AdorganizeName { get; set; }

    /// <summary>
    /// objectid ของ Active Directory
    /// </summary>
    public string? ObjectId { get; set; }

    /// <summary>
    /// วันที่ sync จาก Active Directory ล่าสุด
    /// </summary>
    public DateTime? LastSync { get; set; }

    /// <summary>
    /// เลขที่บัตรเครดิตราชการ
    /// </summary>
    public string? CreditCardNumber { get; set; }

    /// <summary>
    /// เดือนที่บัตรเครดิตราชการหมดอายุ
    /// </summary>
    public int? CreditCardExpireMonth { get; set; }

    /// <summary>
    /// เดือนที่บัตรเครดิตราชการหมดอายุ
    /// </summary>
    public int? CreditCardExpireYear { get; set; }

    /// <summary>
    /// เลขที่ใบอนุญาตขับขี่
    /// </summary>
    public string? DriversLicense { get; set; }

    /// <summary>
    /// รหัสส่วนงาน อ้างอิง Organization.Id 
    /// </summary>
    public int? DivisionId { get; set; }
}
