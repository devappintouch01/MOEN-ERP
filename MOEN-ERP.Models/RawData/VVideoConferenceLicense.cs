using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VVideoConferenceLicense
    {
        public int? ConferenceId { get; set; }

        public string? ConferenceName { get; set; }

        public bool? ConferenceActive { get; set; }

        public int? ConferenceCreateBy { get; set; }

        public DateTime? ConferenceCreateOn { get; set; }

        public int? ConferenceUpdateBy { get; set; }

        public DateTime? ConferenceUpdateOn { get; set; }

        public int? LicenseId { get; set; }

        public string? LicenseName { get; set; }

        public int? Participants { get; set; }

        public bool? LicenseActive { get; set; }       

        public int? LicenseCreateBy { get; set; }

        public DateTime? LicensCreateOn { get; set; }

        public int? LicensUpdateBy { get; set; }

        public DateTime? LicensUpdateOn { get; set; }
    }
}
