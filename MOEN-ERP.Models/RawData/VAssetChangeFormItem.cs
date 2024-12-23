using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VAssetChangeFormItem
    {
        public int? Id { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public int? AssetChangeFormId { get; set; }

        public int? AssetId { get; set; }

        public string? AssetCode { get; set; }

        public string? AssetNumberGfmis { get; set; }

        public string? AssetDetail { get; set; }

        public int? Amount { get; set; }

        public int? OwnerOfficerId { get; set; }

        public string? Remark { get; set; }

        public DateTime? ReturnDate { get; set; }

        public int? ReferenceBorrowItem { get; set; }

        public string? Code { get; set; }

        public DateTime? TransferDate { get; set; }

        public int? Running { get; set; }

        public string? TransferType { get; set; }

        public string? Subject { get; set; }

        public string? Receiver { get; set; }

        public int? SourceOfficerId { get; set; }

        public int? PositionId { get; set; }

        public string? Phone { get; set; }

        public string? SourceDivisionName { get; set; }

        public int? SourceOrganizationId { get; set; }
        public string? SourceOrganizationName { get; set; }

        public string? TargetDivisionName { get; set; }

        public int? TargetOrganizationId { get; set; }

        public string? Reason { get; set; }

        public string? Status { get; set; }

        public string? StatusApprove { get; set; }

        public DateTime? SubmitDate { get; set; }

        public DateTime? ApproveDate { get; set; }

        public int? DirectorId { get; set; }

        public int? AdminOfficerId { get; set; }

        public int? OfficerId { get; set; }

        public int? HeadOfficerId { get; set; }

        public int? ApproverId { get; set; }

        public DateTime? CancelDate { get; set; }

        public string? CancelRemark { get; set; }

        public int? ChangeType { get; set; }

        public DateTime? DueDate { get; set; }

        public string? IsReturn { get; set; }

        public string? ReturnAssetChangeFormCode { get; set; }
    }
}
