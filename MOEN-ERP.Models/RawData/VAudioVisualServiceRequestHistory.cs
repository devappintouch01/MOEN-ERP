using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VAudioVisualServiceRequestHistory
    {
        public int? HistoryId { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public int? AudioVisualServiceRequestId { get; set; }

        public int? ActorId { get; set; }

        public int? ActorUserId { get; set; }

        public string? ActorName { get; set; }

        public int? ActorPosId { get; set; }

        public string? ActorPosName { get; set; }

        public int? ActorOrgId { get; set; }

        public string? ActorOrgName { get; set; }

        public int? ActionId { get; set; }

        public string? ActionName { get; set; }

        public int? StatusId { get; set; }

        public string? StatusName { get; set; }

        public int? NextActorId { get; set; }

        public int? NextActorUserId { get; set; }

        public string? NextActorName { get; set; }

        public int? NextActorPosId { get; set; }

        public string? NextActorPosName { get; set; }

        public int? NextActorOrgId { get; set; }

        public string? NextActorOrgName { get; set; }

        public int? NextWorkProcessId { get; set; }

        public string? NextWorkProcessName { get; set; }

        public int? NextWorkProcessRoleId { get; set; }

        public string? NextWorkProcessActorType { get; set; }

        public string? ActionRemark { get; set; }
    }
}
