using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VCateringServiceExpensesBudgetApprove
    {
        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public int? CateringServiceRequestId { get; set; }

        public string? CateringServiceRequestCode { get; set; }

        public DateTime? CateringServiceRequestDate { get; set; }

        public int? CateringServiceExpensesId { get; set; }

        public string? CateringServiceExpensesCode { get; set; }

        public DateTime? CateringServiceExpensesDate { get; set; }

        public int? BookerId { get; set; }

        public int? BookerUserId { get; set; }

        public string? BookerName { get; set; }

        public int? BookerOrgId { get; set; }

        public string? BookerOrgName { get; set; }

        public int? BookerPosId { get; set; }

        public string? BookerPosName { get; set; }

        public int? SystemOperationType { get; set; }

        public string? SystemOperationTypeName { get; set; }

        public string? RequestDetail { get; set; }

        public decimal? ExpensesCostAmount { get; set; }

        public int? BudgetApproveId { get; set; }

        public int? BudgetYear { get; set; }

        public string? BudgetApproveNumber { get; set; }

        public DateTime? BudgetApproveDate { get; set; }

        public string? BudgetApproveName { get; set; }

        public string? BudgetApproveStatus { get; set; }

        public string? BudgetApproveStatusName { get; set; }

        public int? LastHistoryId { get; set; }

        public int? LastActorId { get; set; }

        public int? LastActorUserId { get; set; }

        public string? LastActorName { get; set; }

        public int? LastActionId { get; set; }

        public string? LastActionName { get; set; }

        public string? ActionRemark { get; set; }

        public int? NextActorId { get; set; }

        public int? NextActorUserId { get; set; }

        public string? NextActorName { get; set; }

        public int? LastWorkProcessId { get; set; }

        public string? LastWorkProcessName { get; set; }

        public int? LastWorkProcessRoleId { get; set; }

        public string? LastWorkProcessActorType { get; set; }

        public int? LastStatusId { get; set; }

        public string? LastStatusName { get; set; }

        public bool? IsFinish { get; set; }
    }
}
