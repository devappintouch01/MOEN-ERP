using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// ครุภัณฑ์ที่โอน
/// </summary>
public partial class AssetTransferItem
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
    /// การโอนครุภัณฑ์ อ้างอิง AssetTransfer.Id
    /// </summary>
    public int? AssetTransferId { get; set; }

    /// <summary>
    /// สินทรัพย์ อ้างอิง Asset.Id
    /// </summary>
    public int? AssetId { get; set; }

    /// <summary>
    /// หมายเหตุการโอน
    /// </summary>
    public string? TransferDetail { get; set; }

    /// <summary>
    /// เลขครุภัณฑ์เดิมก่อนโอน
    /// </summary>
    public string? OldAssetCode { get; set; }

    /// <summary>
    /// เลขสินทรัพย์เดิมก่อนโอน
    /// </summary>
    public string? OldAssetNumberGfmis { get; set; }

    /// <summary>
    /// หน่วยงานเดิมก่อนโอน อ้างอิง MasterOrganization.Id
    /// </summary>
    public int? OldOrganizationId { get; set; }

    /// <summary>
    /// ศูนย์ต้นทุนเดิมก่อนโอน อ้างอิง MasterCostCenter.Id
    /// </summary>
    public int? OldCostCenterId { get; set; }

    /// <summary>
    /// วันที่ได้รับทรัพย์สิน/วันที่ได้รับโอนเดิมก่อนโอน
    /// </summary>
    public DateTime? OldReceiveDate { get; set; }

    /// <summary>
    /// วิธีการได้มาเดิมก่อนโอน อ้างอิง MasterAssetAcquisitionType.Id
    /// </summary>
    public int? OldAssetAcquisitionTypeId { get; set; }

    /// <summary>
    /// ผู้เบิกก่อนโอน อ้างอิง Officer.Id
    /// </summary>
    public int? OldCurrentResponsibleOfficerId { get; set; }

    /// <summary>
    /// ผู้ยืมก่อนโอน อ้างอิง Officer.Id
    /// </summary>
    public int? OldCurrentBorrowerOfficerId { get; set; }

    /// <summary>
    /// เลขครุภัณฑ์ใหม่หลังโอน
    /// </summary>
    public string? NewAssetCode { get; set; }

    /// <summary>
    /// เลขสินทรัพย์ใหม่หลังโอน
    /// </summary>
    public string? NewAssetNumberGfmis { get; set; }

    /// <summary>
    /// หน่วยงานใหม่หลังโอน อ้างอิง MasterOrganization.Id
    /// </summary>
    public int? NewOrganizationId { get; set; }

    /// <summary>
    /// ศูนย์ต้นทุนใหม่หลังโอน อ้างอิง MasterCostCenter.Id
    /// </summary>
    public int? NewCostCenterId { get; set; }

    /// <summary>
    /// วันที่ได้รับทรัพย์สิน/วันที่ได้รับโอนใหม่หลังโอน
    /// </summary>
    public DateTime? NewReceiveDate { get; set; }

    /// <summary>
    /// วิธีการได้มาใหม่หลังโอน อ้างอิง MasterAssetAcquisitionType.Id
    /// </summary>
    public int? NewAssetAcquisitionTypeId { get; set; }
}
