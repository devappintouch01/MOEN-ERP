using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VMaterialBorrowItem
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? MaterialId { get; set; }

    public int? MaterialBorrowId { get; set; }

    public int? StatusId { get; set; }

    public DateTime? ReturnDate { get; set; }

    public int? ReturnBy { get; set; }

    public int? ReturneeBy { get; set; }

    public DateTime? ReturnReceiveDate { get; set; }

    public string? Remark { get; set; }

    public int? ReceiveAmount { get; set; }

    public int? UnitId { get; set; }

    public int? BorrowAmount { get; set; }

    public string StatusName { get; set; } = null!;

    public string? MaterialName { get; set; }

    public string? UnitName { get; set; }

    public string? ReturnByName { get; set; }

    public string? ReturneeByName { get; set; }
}
