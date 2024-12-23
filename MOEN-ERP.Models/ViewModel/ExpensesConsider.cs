using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.ExpensesConsider
{

    public class SearchConsiderExpensesRequest
    {

        public string? SearchCateringServiceRequestCode { get; set; }
        public string? SearchCateringServiceExpensesCode { get; set; }
        public int? SearchBookingStatusId { get; set; }
        public string? SearchERPBookingStatusId { get; set; }
        public DateTime? SearchCateringServiceRequestDateFrom { get; set; }
        public DateTime? SearchCateringServiceRequestDateTo { get; set; }
        public DateTime? SearchCateringServiceExpensesDateFrom { get; set; }
        public DateTime? SearchCateringServiceExpensesDateTo { get; set; }
        public bool? SearchIsConsider { get; set; }
        public int? SearchSystemUserId { get; set; }
        public int? SearchSystemUserRoleId { get; set; }
        public int? SearchSystemOrganizationId { get; set; }

    }


}
