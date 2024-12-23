using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VOfficer
{
    public int Id { get; set; }

    public string? NamePrefix { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string FullName { get; set; } = null!;

    public int? WorkPositionId { get; set; }

    public int? OrganizationId { get; set; }

    public string? Abbreviation { get; set; }

    public string? NameThai { get; set; }

    public string? OrganizationName { get; set; }

    public DateTime? StartWorkDate { get; set; }

    public DateTime? EndWorkDate { get; set; }

    public bool? Active { get; set; }

    public string? Phone { get; set; }

    public int? SystemUserId { get; set; }

    public int? ExecutivePositionId { get; set; }

    public string? Address { get; set; }

    public string? PersonalId { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? Remark { get; set; }

    public string? BankId { get; set; }

    public string? BankBranch { get; set; }

    public string? BankAccount { get; set; }

    public string? DistinguishedName { get; set; }

    public string? AdorganizeName { get; set; }

    public string? ObjectId { get; set; }

    public DateTime? LastSync { get; set; }

    public string? CreditCardNumber { get; set; }

    public int? CreditCardExpireMonth { get; set; }

    public int? CreditCardExpireYear { get; set; }

    public string? DriversLicense { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? DivisionId { get; set; }

    public string? PositionName { get; set; }

    public int? CostCenterId { get; set; }

    public string? AreaCode { get; set; }
}
