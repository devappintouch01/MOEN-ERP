using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VSystemUser
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public bool? Active { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? LoginType { get; set; }

    public string? LastIpaddress { get; set; }

    public DateTime? LastLogin { get; set; }
}
