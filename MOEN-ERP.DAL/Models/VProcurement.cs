using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VProcurement
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public int? BudgetYear { get; set; }

    public DateTime? ContractDate { get; set; }

    public DateTime? ProcurementStartDate { get; set; }

    public DateTime? ProcurementEndDate { get; set; }

    public int? SupplierId { get; set; }

    public string? SupplierName { get; set; }
}
