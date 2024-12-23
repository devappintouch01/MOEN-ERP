using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Data
{
    internal class BudgetModel
    {
    }

    public class BudgetRequestFilter
    {
        public string? BudgetYear { get; set; }
        public int? OrganizationId { get; set; }
        public int? StatusId { get; set; }
    }

    public class BudgetRequestForm
    {
        public string? Code { get; set; }
        public int? BudgetYear { get; set; }
        public int? OrganizationId { get; set; }
        public int? StatusId { get; set; }
    }

    public class BudgetRequestDetail
    {
        public string? Code { get; set; }
        public int? BudgetYear { get; set; }
        public int? OrganizationId { get; set; }
        public int? StatusId { get; set; }
        public decimal? TotalRequestAmount { get; set; }
    }

    public class BudgetGovernmentForm
    {
        public string? ItemDetail { get; set; }
        public int? ExpenseRate { get; set; }
        public int? ExpenseRateUnitId { get; set; }
        public int? QuantityUnit { get; set; }
        public int? QuantityUnitId { get; set; }
        public int? Quantity { get; set; }
        public int? TotalAmount { get; set; }
    }
}