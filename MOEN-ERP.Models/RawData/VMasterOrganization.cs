using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VMasterOrganization
    {
        public int? Id { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public string? OrganizationCode { get; set; }

        public string? NameThai { get; set; }

        public string? NameEnglish { get; set; }

        public string? OrganizationName { get; set; }

        public string? Abbreviation { get; set; }

        public string? CostCenter { get; set; }

        public string? OrganizationLevel { get; set; }

        public int? ParentOrganization { get; set; }

        public string? Active { get; set; }

        public int? DirectorId { get; set; }

        public int? BudgetSequence { get; set; }

        public string? DivisionType { get; set; }

        public string? CodeCostCenter { get; set; }
    }
}
