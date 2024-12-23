using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VSupplier
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public bool? Active { get; set; }

    public string ActiveName { get; set; } = null!;

    public string? NameThai { get; set; }

    public string? PersonType { get; set; }

    public string? SupplierCode { get; set; }

    public string? TaxId { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public int? TambonId { get; set; }

    public int? AmphurId { get; set; }

    public int? ProvinceId { get; set; }

    public string? ZipCode { get; set; }

    public string? FullAddress { get; set; }

    public string? Email { get; set; }
}
