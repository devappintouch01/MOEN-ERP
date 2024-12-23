using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// สินทรัพย์
/// </summary>
public partial class Asset
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
    /// เลขครุภัณฑ์
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// เลขครุภัณฑ์ (เดิม)
    /// </summary>
    public string? CodeOld { get; set; }

    /// <summary>
    /// เลขสินทรัพย์
    /// </summary>
    public string? AssetNumberGfmis { get; set; }

    /// <summary>
    /// หน่วยงาน อ้างอิง MasterOrganization.Id
    /// </summary>
    public int? OrganizationId { get; set; }

    /// <summary>
    /// ศูนย์ต้นทุน อ้างอิง MasterCostCenter.Id
    /// </summary>
    public int? CostCenterId { get; set; }

    /// <summary>
    /// กลุ่มสินทรัพย์ (B=อาคารและสิ่งปลูกสร้าง, C=รถยนต์, D=ครุภัณฑ์, I=สินทรัพย์ไม่มีตัวตน)
    /// </summary>
    public string? AssetCategory { get; set; }

    /// <summary>
    /// หมวดหมู่ย่อย อ้างอิง MasterAssetClass.Id
    /// </summary>
    public int? AssetClassId { get; set; }

    /// <summary>
    /// หมวดหมู่ครุภัณฑ์ อ้างอิง MasterAssetType.Id
    /// </summary>
    public int? AssetTypeId { get; set; }

    /// <summary>
    /// ชื่อรายการ
    /// </summary>
    public string? AssetName { get; set; }

    /// <summary>
    /// สถานะการใช้งาน (A=ใช้งาน, C=ตัดจำหน่าย, W=รอจำหน่าย)
    /// </summary>
    public string? AssetStatus { get; set; }

    /// <summary>
    /// อายุการใช้งาน (ทดแทน) (ปี)
    /// </summary>
    public int? LifeTimeUse { get; set; }

    /// <summary>
    /// อายุการใช้งาน(ใช้ในการคำนวณค่าเสื่อม) (ปี)
    /// </summary>
    public int? LifeTimeDepreciation { get; set; }

    /// <summary>
    /// อัตราค่าเสื่อม (ร้อยละ)
    /// </summary>
    public decimal? Depreciation { get; set; }

    /// <summary>
    /// ราคาต่อหน่วย (บาท)
    /// </summary>
    public decimal? Cost { get; set; }

    /// <summary>
    /// ราคาซาก (บาท)
    /// </summary>
    public decimal? ScrapValue { get; set; }

    /// <summary>
    /// วันที่ตรวจรับ
    /// </summary>
    public DateTime? ApproveDate { get; set; }

    /// <summary>
    /// วันที่ได้รับทรัพย์สิน/วันที่ได้รับโอน
    /// </summary>
    public DateTime? ReceiveDate { get; set; }

    /// <summary>
    /// หน่วยนับ อ้างอิง MasterUnit.Id 
    /// </summary>
    public int? UnitId { get; set; }

    /// <summary>
    /// ยี่ห้อ
    /// </summary>
    public string? Brand { get; set; }

    /// <summary>
    /// รุ่น/แบบ
    /// </summary>
    public string? Model { get; set; }

    /// <summary>
    /// ลักษณะ/คุณสมบัติ
    /// </summary>
    public string? Spec { get; set; }

    /// <summary>
    /// รายละเอียด
    /// </summary>
    public string? AssetDetail { get; set; }

    /// <summary>
    /// หมายเลขเครื่อง
    /// </summary>
    public string? SerialNumber { get; set; }

    /// <summary>
    /// เลขทะเบียนรถ
    /// </summary>
    public string? LicenseNumber { get; set; }

    /// <summary>
    /// เลขเครื่องยนต์
    /// </summary>
    public string? EngineNumber { get; set; }

    /// <summary>
    /// เลขตัวรถ
    /// </summary>
    public string? ChassisNumber { get; set; }

    /// <summary>
    /// จำนวนที่นั่ง
    /// </summary>
    public int? CarSeats { get; set; }

    /// <summary>
    /// รหัสประเภทเชื้อเพลิง อ้างอิง MasterFuelType.Id
    /// </summary>
    public int? FuelTypeId { get; set; }

    /// <summary>
    /// ประเภทที่ดิน อ้างอิง MasterLandType.Id
    /// </summary>
    public int? LandTypeId { get; set; }

    /// <summary>
    /// ชื่ออาคาร
    /// </summary>
    public string? BuildingName { get; set; }

    /// <summary>
    /// IP Address
    /// </summary>
    public string? Ipaddress { get; set; }

    /// <summary>
    /// ผู้ให้บริการ (Provider)
    /// </summary>
    public string? ProviderName { get; set; }

    /// <summary>
    /// เป็นครุภัณฑ์ต่ำกว่าเกณฑ์ (True=ใช่, False=ไม่ใช่)
    /// </summary>
    public bool? IsBelow { get; set; }

    /// <summary>
    /// เป็นชุดครุภัณฑ์  (True=ชุด, False=เดี่ยว)
    /// </summary>
    public bool? IsSet { get; set; }

    /// <summary>
    /// ชื่อชุดครุภัณฑ์
    /// </summary>
    public string? SetName { get; set; }

    /// <summary>
    /// ครุภัณฑ์หลัก อ้างอิง Asset.Id
    /// </summary>
    public int? MainAssetId { get; set; }

    /// <summary>
    /// จำนวนครุภัณฑ์ย่อย
    /// </summary>
    public int? Child { get; set; }

    /// <summary>
    /// เป็นครุภัณฑ์ย่อย (True=ใช่, False=ไม่ใช่)
    /// </summary>
    public bool? IsChild { get; set; }

    /// <summary>
    /// เลข Running 
    /// </summary>
    public int? Running { get; set; }

    /// <summary>
    /// การได้มาของสินทรัพย์ อ้างอิง MasterAssetAcquisitionType.Id
    /// </summary>
    public int? AssetAcquisitionTypeId { get; set; }

    /// <summary>
    /// แหล่งเงิน อ้างอิง MasterAssetBudgetType.Id
    /// </summary>
    public int? AssetBudgetTypeId { get; set; }

    /// <summary>
    /// ปีงบประมาณ
    /// </summary>
    public int? BudgetYear { get; set; }

    /// <summary>
    /// ประเภทเอกสาร อ้างอิง MasterDocumentType.Id
    /// </summary>
    public int? DocumentTypeId { get; set; }

    /// <summary>
    /// เลขที่เอกสาร
    /// </summary>
    public string? DocumentNumber { get; set; }

    /// <summary>
    /// ลงวันที่เอกสาร
    /// </summary>
    public DateTime? DocumentDate { get; set; }

    /// <summary>
    /// ผู้ขาย/ผู้รับจ้าง/ผู้บริจาค อ้างอิง Supplier.Id
    /// </summary>
    public int? SupplierId { get; set; }

    /// <summary>
    /// ชื่อผู้ขาย/ผู้รับจ้าง/ผู้บริจาค
    /// </summary>
    public string? SupplierName { get; set; }

    /// <summary>
    /// ที่อยู่ผู้ขาย/ผู้รับจ้าง/ผู้บริจาค
    /// </summary>
    public string? SupplierFullAddress { get; set; }

    /// <summary>
    /// หมายเลขโทรศัพท์ผู้ขาย/ผู้รับจ้าง/ผู้บริจาค
    /// </summary>
    public string? SupplierPhone { get; set; }

    /// <summary>
    /// วันที่เริ่มรับประกัน
    /// </summary>
    public DateTime? WarrantyStartDate { get; set; }

    /// <summary>
    /// วันที่สิ้นสุดรับประกัน
    /// </summary>
    public DateTime? WarrantyEndDate { get; set; }

    /// <summary>
    /// ระยะเวลารับประกัน
    /// </summary>
    public int? WarrantyTime { get; set; }

    /// <summary>
    /// หน่วยเวลารับประกัน 
    /// (D=วัน, M=เดือน, Y=ปี)
    /// </summary>
    public string? WarrantyPeriod { get; set; }

    /// <summary>
    /// หมายเหตุ
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// สถานที่จัดเก็บ/ใช้งาน อ้างอิงตาราง MasterStorePlace.Id
    /// </summary>
    public int? StorePlaceId { get; set; }

    /// <summary>
    /// รายละเอียดสถานที่จัดเก็บ/ใช้งาน
    /// </summary>
    public string? StorePlaceDetail { get; set; }

    /// <summary>
    /// เลข RFIDTag
    /// </summary>
    public int? RfidtagNumber { get; set; }

    /// <summary>
    /// สภาพทรัพย์สิน (True=ใช้งานได้, N=ใช้งานไม่ได้/ชำรุด)
    /// </summary>
    public bool? IsUsable { get; set; }

    /// <summary>
    /// ลักษณะการชำรุด
    /// </summary>
    public string? UnusableDetail { get; set; }

    /// <summary>
    /// อยู่ในช่วง MA (True=ใช่, False=ไม่ใช่)
    /// </summary>
    public bool? IsInMa { get; set; }

    /// <summary>
    /// โครงการจัดซื้อ/จัดจ้าง อ้างอิง Procurement.Id
    /// </summary>
    public int? ProcurementId { get; set; }

    /// <summary>
    /// ครุภัณฑ์ที่จัดซื้อ/จัดจ้าง อ้างอิง ProcurementAssetItem.Id
    /// </summary>
    public int? ProcurementAssetItemId { get; set; }

    /// <summary>
    /// เลขที่สัญญา
    /// </summary>
    public string? ProcurementCode { get; set; }

    /// <summary>
    /// วันที่เริ่มต้นสัญญา
    /// </summary>
    public DateTime? ProcurementStartDate { get; set; }

    /// <summary>
    /// วันที่สิ้นสุดสัญญา
    /// </summary>
    public DateTime? ProcurementEndDate { get; set; }

    /// <summary>
    /// วิธีการได้มา อ้างอิง MasterProcurementMethod.Id
    /// </summary>
    public int? ProcurementMethodId { get; set; }

    /// <summary>
    /// ผู้เบิกคนปัจจุบัน อ้างอิง Officer.Id
    /// </summary>
    public int? CurrentResponsibleOfficerId { get; set; }

    /// <summary>
    /// ผู้ยืมคนปัจจุบัน อ้างอิง Officer.Id
    /// </summary>
    public int? CurrentBorrowerOfficerId { get; set; }
}
