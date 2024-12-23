using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel
{
    public class MeetingRoomAssetChangeFormItem
    {
        public int? Id { get; set; }
        //public int? MeetingRoomId { get; set; }
        public string? Code { get; set; }
        public int? OrganizationId { get; set; }
        public string? OrganizationName { get; set; }
        public string? AssetDetail { get; set; }
        public int? Amount { get; set; }
        public string? StatusId { get; set; }
        public string? StatusName { get; set;}
    }
}
