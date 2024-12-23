﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VCateringServiceRequestDetail
    {
        public int? CateringServiceRequestDetailId { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }
        public int? CateringServiceRequestId { get; set; }

        public string? CateringServiceRequestCode { get; set; }

        public DateTime? CateringServiceRequestDate { get; set; }

        public string? BookerPhone { get; set; }

        public int? BookingTypeId { get; set; }

        public string? BookingTypeName { get; set; }

        public string? Topic { get; set; }

        public DateTime? UseDateFrom { get; set; }

        public DateTime? UseDateTo { get; set; }

        public string? Location { get; set; }

        public int? ChairmanId { get; set; }

        public string? ChairmanName { get; set; }

        public int? ChairmanPosId { get; set; }

        public string? ChairmanPosName { get; set; }

        public int? ChairmanOrgId { get; set; }

        public string? ChairmanOrgName { get; set; }

        public int? Participants { get; set; }

        public DateTime? SnackServeInsideTime { get; set; }

        public DateTime? SnackServeOutsideTime { get; set; }

        public bool? IsLunchRequest { get; set; }

        public DateTime? LunchServeTime { get; set; }

        public int? LunchNumber { get; set; }

        public int? LunchFoodCategoryId { get; set; }

        public int? LunchRestaurantId { get; set; }

        public string? LunchRestaurantName { get; set; }

        public bool? IsDinnerRequest { get; set; }

        public DateTime? DinnerServeTime { get; set; }

        public int? DinnerNumber { get; set; }

        public int? DinnerFoodCategoryId { get; set; }

        public int? DinnerRestaurantId { get; set; }

        public string? DinnerRestaurantName { get; set; }

        public bool? IsVegetarianFood { get; set; }

        public int? VegetarianFoodNumber { get; set; }

        public bool? IsHalalFood { get; set; }

        public int? HalalFoodNumber { get; set; }

        public bool? IsExpensesRequest { get; set; }

        public int? LastCateringServiceExpensesId { get; set; }

        public string? EditRemark { get; set; }

        public DateTime? ApproveDate { get; set; }

        public bool? IsApprove { get; set; }

        public string? ApproveStatusName { get; set; }
        public int? DirectorApproveId1 { get; set; }

        public int? DirectorApproveId2 { get; set; }
    }

}
