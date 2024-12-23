using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// กำหนดสิทธิสำหรับผู้ใช้งานระบบ
/// </summary>
public partial class SystemUserRoleAssign
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
    /// วันที่มีผล
    /// </summary>
    public DateTime? EffectiveDate { get; set; }

    /// <summary>
    /// วันที่สิ้นสุด
    /// </summary>
    public DateTime? ExpireDate { get; set; }

    /// <summary>
    /// เป็นการรักษาการแทน (True=ใช่, False=ไม่ใช่)
    /// </summary>
    public bool? IsActing { get; set; }

    /// <summary>
    /// ลำดับความสำคัญ
    /// </summary>
    public int? Priority { get; set; }

    /// <summary>
    /// ระบบ อ้างอิง SystemMenuGroup.Id
    /// </summary>
    public int? SystemMenuGroupId { get; set; }

    /// <summary>
    /// ระดับการเข้าใช้งานในระบบ อ้างอิง SystemRole.Id
    /// </summary>
    public int? SystemRoleId { get; set; }

    /// <summary>
    /// ผู้ใช้งานในระบบ อ้างอิง SystemUser.Id
    /// </summary>
    public int? SystemUserId { get; set; }
}
