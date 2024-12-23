using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VProjectActivityPlan
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? ProjectId { get; set; }
}
