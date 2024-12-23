using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel
{
    public class MasterBudgetExpenseTypeModel
    {
        public int Id { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public bool? Active { get; set; }

        public string? Name { get; set; }

        public int? BudgetTypeId { get; set; }

        public int? ExpenseTypeId { get; set; }

        public int? StrategyCodeId { get; set; }

        public int? StrategicPlanCodeId { get; set; }

        public int? OutputCodeId { get; set; }

        public int? BudgetExpenseLevel { get; set; }

        public long? ParentId { get; set; }

        public bool? IsParent { get; set; }

        public int? MoneySourceId { get; set; }

        public string ActiveName { get; set; } = null!;

        public string? StrategicName { get; set; }

        public string? StrategicPlanName { get; set; }

        public string? OutputCodeName { get; set; }

        public string? ExpenseTypeName { get; set; }

        public string? NodeId { get; set; }

        public string? NodePId { get; set; }
    }
}
