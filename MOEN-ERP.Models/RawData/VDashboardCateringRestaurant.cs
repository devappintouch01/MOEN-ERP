using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public partial class VDashboardCateringRestaurant
    {
        public int RestaurantId { get; set; }

        public string? RestaurantName { get; set; }

        public string? CategoryGroupName { get; set; }

        public string? Location { get; set; }

        public string? Phone { get; set; }

        public bool? RestaurantActive { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }
    }

}
