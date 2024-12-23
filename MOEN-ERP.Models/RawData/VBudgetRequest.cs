using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VBudgetRequest
    {
        public int? Id { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public int? BudgetYear { get; set; }

        public string? Objective { get; set; }

        public string? Target { get; set; }

        public string? Benefit { get; set; }

        public string? TimeFrame { get; set; }

        public int? OrganizationId { get; set; }

        public string? OrganizationName { get; set; }

        public string? OrganizationFullName { get; set; }

        public string? CostCenter { get; set; }

        public int? BudgetFormTypeId { get; set; }

        public int? ExpenseTypeId { get; set; }

        public string? ExpenseTypeName { get; set; }

        public int? StrategyCodeId { get; set; }

        public string? StrategyCodeName { get; set; }

        public int? StrategicPlanCodeId { get; set; }

        public string? StrategicPlanCodeName { get; set; }

        public int? OutputCodeId { get; set; }

        public string? OutputCodeName { get; set; }

        public string? OutputAbb { get; set; }

        public int? ActivityCodeId { get; set; }

        public string? ActivityCodeName { get; set; }

        public string? ActivityAbb { get; set; }

        public string? Status { get; set; }

        public string? StatusName { get; set; }

        public int? BudgetRequestFormId { get; set; }

        public int? BudgetRequestLevel { get; set; }

        public int? ParentBudgetRequestId { get; set; }

        public string? ParentBudgetRequestName { get; set; }

        public decimal? TotalAmount { get; set; }

        public string? CountryType { get; set; }

        public string? PlanStatus { get; set; }

        public int? BudgetCodeId { get; set; }

        public string? BudgetCodeName { get; set; }

        public string? ConferenceType { get; set; }

        public string? ConferenceTypeName { get; set; }

        public string? HasObligation { get; set; }

        public int? CountryId { get; set; }

        public string? CountryName { get; set; }

        public string? CountryGroup { get; set; }

        public int? BudgetAllocateId { get; set; }

        public string? BudgetAllocateName { get; set; }

        public int? Quantity { get; set; }

        public int? QuantityUnit { get; set; }

        public string? QuantityUnitName { get; set; }

        public int? TotalParticipant { get; set; }

        public int? TotalTime { get; set; }

        public long? BudgetExpenseTypeId { get; set; }

        public string? BudgetExpenseTypeName { get; set; }

        public decimal? ExpectAmount { get; set; }

        public string? IsFinish { get; set; }

        public string? BudgetSourceType { get; set; }

        public int? MoneySourceId { get; set; }

        public string? MoneySourceName { get; set; }

        public decimal? ExpenseRate { get; set; }

        public int? ExpenseRateUnit { get; set; }

        public string? ExpenseRateUnitName { get; set; }

        public int? BudgetSequence { get; set; }

        public string? Abbreviation { get; set; }

        public string? TrainingPlace { get; set; }

        public decimal? UsedAmount { get; set; }

        public string? OccupationType { get; set; }

        public string? OccupationName { get; set; }

        public string? Erpcode { get; set; }

        public decimal? DocumentAmount { get; set; }

        public decimal? TransferAmount { get; set; }

        public decimal? NetAmount { get; set; }

        public string? ProjectName { get; set; }
    }
}
