﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class RCateringServiceRequestForm
    {
        public int? BookingId { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public int? RoomBookingId { get; set; }

        public string? RoomBookingCode { get; set; }

        public DateTime? RoomBookingDate { get; set; }

        public string? BookingCode { get; set; }

        public int? BookerUserId { get; set; }

        public int? BookerId { get; set; }

        public string? BookerName { get; set; }

        public int? BookerPosId { get; set; }

        public string? BookerPosName { get; set; }

        public int? BookerOrgId { get; set; }

        public string? BookerOrgName { get; set; }

        public int? DivisionId { get; set; }

        public string? DivisionName { get; set; }

        public DateTime? BookingDate { get; set; }

        public string? BookerPhone { get; set; }

        public int? BookingTypeId { get; set; }

        public string? BookingTypeName { get; set; }

        public string? Topic { get; set; }

        public DateTime? UseDateFrom { get; set; }

        public DateTime? UseDateTo { get; set; }

        public int? MeetingRoomId { get; set; }

        public string? MeetingRoomName { get; set; }

        public string? Location { get; set; }

        public string? MeetingRoomDetail { get; set; }

        public int? ChairmanId { get; set; }

        public string? ChairmanName { get; set; }

        public int? ChairmanPosId { get; set; }

        public string? ChairmanPosName { get; set; }

        public int? ChairmanOrgId { get; set; }

        public string? ChairmanOrgName { get; set; }

        public int? Participants { get; set; }

        public bool? IsSnackRequest { get; set; }

        public bool? IsSnackMorning { get; set; }

        public bool? IsSnackAfternoon { get; set; }

        public DateTime? SnackServeInsideTime { get; set; }

        public DateTime? SnackServeOutsideTime { get; set; }

        public DateTime? SnackAfternoonServeInsideTime { get; set; }

        public DateTime? SnackAfternoonServeOutsideTime { get; set; }

        public bool? IsLunchRequest { get; set; }

        public int? LunchNumber { get; set; }

        public int? LunchRestaurantId { get; set; }

        public string? LunchRestaurantName { get; set; }

        public int? LunchFoodCategoryId { get; set; }

        public bool? IsLunchOneDish { get; set; }

        public DateTime? LunchServeTime { get; set; }

        public bool? IsDinnerRequest { get; set; }

        public int? DinnerNumber { get; set; }

        public int? DinnerRestaurantId { get; set; }

        public string? DinnerRestaurantName { get; set; }

        public int? DinnerFoodCategoryId { get; set; }

        public bool? IsDinnerOneDish { get; set; }

        public DateTime? DinnerServeTime { get; set; }

        public bool? IsVegetarianFood { get; set; }

        public int? VegetarianFoodNumber { get; set; }

        public bool? IsHalalFood { get; set; }

        public int? HalalFoodNumber { get; set; }

        public bool? IsExpensesRequest { get; set; }

        public string? ApproveName { get; set; }

        public int? LastHistoryId { get; set; }

        public int? LastWorkProcessId { get; set; }

        public string? LastWorkProcessName { get; set; }

        public int? LastActorId { get; set; }

        public string? ActorName { get; set; }

        public string? Director1ActorName { get; set; }

        public DateTime? Director1CreateOn { get; set; }

        public string? Director2ActorName { get; set; }

        public DateTime? Director2CreateOn { get; set; }

        public int? ActorPosId { get; set; }

        public string? ActorPosName { get; set; }

        public int? ActorOrgId { get; set; }

        public string? ActorOrgName { get; set; }

        public int? LastActionId { get; set; }

        public string? ActionName { get; set; }

        public int? LastStatusId { get; set; }

        public string? StatusName { get; set; }

        public bool? IsFinish { get; set; }
    }
}