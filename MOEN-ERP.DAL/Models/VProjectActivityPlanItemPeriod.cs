using System;
using System.Collections.Generic;

namespace MOEN_ERP.DAL.Models;

public partial class VProjectActivityPlanItemPeriod
{
    public int Id { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateOn { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? ProjectId { get; set; }

    public int? ProjectActivityPlanItemId { get; set; }

    public int? StartDate { get; set; }

    public int? EndDate { get; set; }
}
