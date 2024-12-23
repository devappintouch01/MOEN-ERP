using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

/// <summary>
/// การกำหนดสิทธิการใช้เมนู
/// </summary>
public partial class SystemMenuRoleAssign
{
    /// <summary>
    /// ระดับการเข้าใช้งานในระบบ อ้างอิง SystemRole.Id
    /// </summary>
    public int SystemRoleId { get; set; }

    /// <summary>
    /// เมนูในระบบ อ้างอิง SystemMenu.Id
    /// </summary>
    public int SystemMenuId { get; set; }

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
}
