using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// เบิกจ่ายวัสดุ
/// </summary>
public partial class MaterialRequisition
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
    /// เลขที่ใบเบิก
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// วันที่ขอเบิก
    /// </summary>
    public DateTime? RequestDate { get; set; }

    /// <summary>
    /// ประเภทการเบิก 1 = เบิกจากหน่วยจัดซื้อ, 2 = เบิกจากหน่วยงาน
    /// </summary>
    public int? RequestType { get; set; }

    /// <summary>
    /// ผู้ขอเบิก อ้างอิง Officer.Id
    /// </summary>
    public int? RequestBy { get; set; }

    /// <summary>
    /// ผู้อนุมัติเบิก อ้างอิง Officer.Id
    /// </summary>
    public int? ApproveRequestBy { get; set; }

    /// <summary>
    /// สถานะการพิจารณา : Y = อนุมัติ, N = ไม่อนุมัติ 
    /// </summary>
    public string? StatusApprove { get; set; }

    /// <summary>
    /// วันที่อนุมัติ
    /// </summary>
    public DateTime? ApproveDate { get; set; }

    /// <summary>
    /// เลข Running สำหรับเรียงลำดับ
    /// </summary>
    public int? Running { get; set; }

    /// <summary>
    /// วันที่ยกเลิก
    /// </summary>
    public DateTime? CancelDate { get; set; }

    /// <summary>
    /// หมายเหตุการยกเลิก
    /// </summary>
    public string? CancelRemark { get; set; }

    /// <summary>
    /// วันที่ส่งเรื่อง
    /// </summary>
    public DateTime? SubmitDate { get; set; }

    /// <summary>
    /// หมายเหตุการส่งกลับ
    /// </summary>
    public string? ReturnRemark { get; set; }

    /// <summary>
    /// เจ้าหน้าที่ผู้ส่งกลับ อ้างอิง Officer.Id
    /// </summary>
    public int? ReturnBy { get; set; }

    /// <summary>
    /// วันที่ส่งกลับ
    /// </summary>
    public DateTime? ReturnDate { get; set; }

    /// <summary>
    /// สถานะดำเนินการ อ้างอิง MasterStatus.Id
    /// </summary>
    public int? StatusId { get; set; }

    /// <summary>
    /// รหัสคลังเก็บวัสดุ อ้างอิง MasterWarehouse.Id
    /// </summary>
    public int? WarehouseId { get; set; }

    /// <summary>
    /// รหัสสำนัก อ้างอิง MasterOrganization.Id
    /// </summary>
    public int? OrganizationId { get; set; }

    /// <summary>
    /// ปีงบประมาณ
    /// </summary>
    public int? BudgetYear { get; set; }

    /// <summary>
    /// ผู้สั่งจ่าย อ้างอิง Officer.Id 
    /// </summary>
    public int? DeliverApproveOfficerId { get; set; }

    /// <summary>
    /// ชื่อผู้สั่งจ่าย
    /// </summary>
    public string? DeliverApproveOfficerName { get; set; }

    /// <summary>
    /// วันที่สั่งจ่าย
    /// </summary>
    public DateTime? DeliverApproveDate { get; set; }

    /// <summary>
    /// ผู้จ่ายพัสดุ อ้างอิง Officer.Id 
    /// </summary>
    public int? DeliverOfficerId { get; set; }

    /// <summary>
    /// ชื่อผู้จ่ายพัสดุ
    /// </summary>
    public string? DeliverOfficerName { get; set; }

    /// <summary>
    /// วันที่จ่ายพัสดุ
    /// </summary>
    public DateTime? DeliverDate { get; set; }

    /// <summary>
    /// ผู้รับพัสดุ อ้างอิง Officer.Id 
    /// </summary>
    public int? ReceiveOfficerId { get; set; }

    /// <summary>
    /// ชื่อผู้รับพัสดุ
    /// </summary>
    public string? ReceiveOfficerName { get; set; }

    /// <summary>
    /// วันที่รับพัสดุ
    /// </summary>
    public DateTime? ReceiveDate { get; set; }

    /// <summary>
    /// รายละเอียด
    /// </summary>
    public string? Detail { get; set; }

    /// <summary>
    /// รายละเอียดสถานที่จัดเก็บ/ใช้งาน
    /// </summary>
    public string? StorePlaceDetail { get; set; }

    /// <summary>
    /// ต้องการใช้ภายในวันที่
    /// </summary>
    public DateTime? ExpectDate { get; set; }
}
