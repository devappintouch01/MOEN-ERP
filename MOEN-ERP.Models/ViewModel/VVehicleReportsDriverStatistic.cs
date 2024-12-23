using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel
{
    public class VVehicleReportsDriverStatistic
    {
        public int? BookingYear { get; set; }

        public int? DriverId { get; set; }

        public string DriverName { get; set; } = null!;

        public int? CountMonth01 { get; set; }

        public int? CountMonth02 { get; set; }

        public int? CountMonth03 { get; set; }

        public int? CountMonth04 { get; set; }

        public int? CountMonth05 { get; set; }

        public int? CountMonth06 { get; set; }

        public int? CountMonth07 { get; set; }

        public int? CountMonth08 { get; set; }

        public int? CountMonth09 { get; set; }

        public int? CountMonth10 { get; set; }

        public int? CountMonth11 { get; set; }

        public int? CountMonth12 { get; set; }

        public int? Total { get; set; }
    }
}
