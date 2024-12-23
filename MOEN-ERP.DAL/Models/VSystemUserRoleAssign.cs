using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VSystemUserRoleAssign
{
    public int Id { get; set; }

    public string? RoleName { get; set; }

    public string? Description { get; set; }

    public int? SystemRoleId { get; set; }

    public int? SystemUserId { get; set; }

    public bool? Active { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? ExpireDate { get; set; }

    public int? Priority { get; set; }

    public int SystemUserRoleId { get; set; }

    public bool? IsActing { get; set; }

    public int? SystemMenuGroupId { get; set; }
}
