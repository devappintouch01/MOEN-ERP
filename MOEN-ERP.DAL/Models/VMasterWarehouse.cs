using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VMasterWarehouse
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public string? Name { get; set; }

    public int? OrganizationId { get; set; }

    public string WarehouseLevel { get; set; } = null!;

    public bool? Active { get; set; }

    public string? OrganizationName { get; set; }

    public string ActiveName { get; set; } = null!;

    public string WarehouseLevelName { get; set; } = null!;
}
