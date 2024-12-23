using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.RawData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.ExpensesRequest
{

    public class SearchExpensesRequest
    {

        public string? SearchCateringServiceRequestCode { get; set; }
        public string? SearchCateringServiceExpensesCode { get; set; }
        public int? SearchBookingStatusId { get; set; }
        public string? SearchERPBookingStatusId { get; set; }
        public DateTime? SearchCateringServiceRequestDateFrom { get; set; }
        public DateTime? SearchCateringServiceRequestDateTo { get; set; }
        public DateTime? SearchCateringServiceExpensesDateFrom { get; set; }
        public DateTime? SearchCateringServiceExpensesDateTo { get; set; }
        //public bool? SearchIsConsider { get; set; }
        public int? SearchSystemUserId { get; set; }
        public int? SearchSystemUserRoleId { get; set; }

    }


    public class EventPreviewExpensesRequestParameter
    {
        public int? CateringServiceExpensesId { get; set; }
        public string? ActionType { get; set; }
    }

    public class EventPreviewExpensesRequest
    {
        public VCateringServiceExpense? CateringServiceExpense { get; set; }
        public List<VCateringServiceExpensesHistory>? CateringServiceExpensesHistoryList { get; set; }
        public EventsModel? EventsModel { get; set; }

    }


    public class ExpenseReimbursementDetails
    { 
        public int? MeetingRoomBookingId { get; set; }
        public int? CateringServiceRequestId { get; set; }
        public int? CateringServiceExpensesId { get; set; }
        public string? BookingCode { get; set; }
        public DateTime? BookingDate { get; set; }
        public int? LastStatusId { get; set; }
        public string? LastStatusName { get; set; }
        public int? BookerId { get; set; }
        public string? BookerName { get; set; }
        public string? RequestDetail { get; set; }
        public string? RequestPurpose { get; set; }
        public int? BudgetRequestId { get; set; }
        public string? BudgetRequestName { get; set; }
        public decimal? SnackCost { get; set; }
        public int? SnackNumber { get; set; }
        public int? SnackRepast { get; set; }
        public decimal? SnackCostAmount { get; set; }
        public decimal? LunchCost { get; set; }
        public int? LunchNumber { get; set; }
        public decimal? LunchCostAmount { get; set; }
        public decimal? DinnerCost { get; set; }

        public int? DinnerNumber { get; set; }

        public decimal? DinnerCostAmount { get; set; }
        public decimal? ExpensesCostAmount { get; set; }
        public int? SystemOperationType { get; set; }
        
        public string? ActionType { get; set; }
        public string? SubmitType { get; set; }
        public int? CurrentSystemUserId { get; set; }

        public int? CurrentOfficerId { get; set; }

    }


    public class SearchModalBudgetItems
    { 
        public int? SearchBudgetFiscalYear { get; set; }
        public int? SearchOrganizationId { get; set; }
        public int? SearchBudgetAllocateId { get; set; }
        public string? SearchBudgetName { get; set; }
    }

    public class ExpenseReimbursementDetailsFormEvent
    {
        public int? MeetingRoomBookingId { get; set; }
        public int? CateringServiceRequestId { get; set; }
        public int? CateringServiceExpensesId { get; set; }
        public string? ActionRemark { get; set; }
        public int? CurrentSystemUserId { get; set; }
        public int? CurrentOfficerId { get; set; }

    }

}
