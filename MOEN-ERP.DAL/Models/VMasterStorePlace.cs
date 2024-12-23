using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VMasterStorePlace
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public bool? Active { get; set; }

    public string? NameThai { get; set; }

    public string? Code { get; set; }

    public int? OrganizationId { get; set; }

    public string? Floor { get; set; }

    public string ActiveName { get; set; } = null!;

    public string? OrganizationName { get; set; }

    public string StorePlaceDetail { get; set; } = null!;
}
