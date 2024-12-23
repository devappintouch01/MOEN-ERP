using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VMonthList
{
    public int Id { get; set; }

    public string MonthEn { get; set; } = null!;

    public string MonthTh { get; set; } = null!;
}
