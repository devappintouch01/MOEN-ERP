using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel
{
    public class SearchLicenseForVideoConferenceBooking
    {
        public DateTime? UseDateFrom { get; set; }
        public DateTime? UseDateTo { get; set; }
        public int? ConferenceId { get; set; }
    }
}
