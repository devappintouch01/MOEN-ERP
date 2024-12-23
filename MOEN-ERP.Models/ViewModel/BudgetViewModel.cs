using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel
{
    internal class BudgetViewModel
    {
    }

    public class BudgetRequestViewModel
    {
        public int Id { get; set; }
        public string? BudgetYear { get; set; }
        public string? OrganizationName { get; set; }
        public string? StatusName { get; set; }
    }

    public class BudgetRequestDetailViewModel
    {
        public string? Code { get; set; }
        public int? BudgetYear { get; set; }
        public int? OrganizationId { get; set; }
        public string? OrganizationName { get; set; }
        public int? StatusId { get; set; }
        public decimal? TotalRequestAmount { get; set; }
    }
}
