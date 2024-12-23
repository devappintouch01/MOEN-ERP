using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VRestaurant
    {
        public int? RestaurantId { get; set; }

        public string? RestaurantName { get; set; }

        public string? CategoryGroupName { get; set; }

        public string? Location { get; set; }

        public string? Phone { get; set; }

        public bool? RestaurantActive { get; set; }

        public int? RestaurantCreateBy { get; set; }

        public DateTime? RestaurantCreateOn { get; set; }

        public int? RestaurantUpdateBy { get; set; }

        public DateTime? RestaurantUpdateOn { get; set; }

        public int? FoodCategoryId { get; set; }

        public string? FoodCategoryName { get; set; }

        public bool? FoodCategoryActive { get; set; }

        public int? FoodCategoryCreateBy { get; set; }

        public DateTime? FoodCategoryCreateOn { get; set; }

        public int? FoodCategoryUpdateBy { get; set; }

        public DateTime? FoodCategoryUpdateOn { get; set; }

        public int? RfcategoryId { get; set; }

        public int? RfcategoryCreateBy { get; set; }

        public DateTime? RfcategoryCreateOn { get; set; }

        public int? RfcategoryUpdateBy { get; set; }

        public DateTime? RfcategoryUpdateOn { get; set; }
    }
}
