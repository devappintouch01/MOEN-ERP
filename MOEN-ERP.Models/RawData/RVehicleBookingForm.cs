﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class RVehicleBookingForm
    {
        public int? BookingId { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public string? BookingCode { get; set; }

        public int? SystemUserId { get; set; }

        public int? BookerId { get; set; }

        public string? BookerName { get; set; }

        public int? BookerPosId { get; set; }

        public string? BookerPosName { get; set; }

        public int? BookerOrgId { get; set; }

        public string? BookerOrgName { get; set; }

        public string? BookerOrgAbbName { get; set; }

        public int? DivisionId { get; set; }

        public string? DivisionName { get; set; }

        public string? DivisionAbbName { get; set; }

        public DateTime? BookingDate { get; set; }

        public int? BookingFormatId { get; set; }

        public string? BookingFormatName { get; set; }

        public int? FirstWorkProcessId { get; set; }

        public string? FirstWorkProcessName { get; set; }

        public DateTime? TravelFromDate { get; set; }

        public DateTime? TravelToDate { get; set; }

        public int? Passengers { get; set; }

        public string? TravelFromLocation { get; set; }

        public string? TravelToLocation { get; set; }

        public string? BookingPurpose { get; set; }

        public string? BookerPhone { get; set; }

        public int? BookingTypeId { get; set; }

        public string? BookingTypeName { get; set; }

        public bool? IsSpecialCase { get; set; }

        public string? SpecialCaseRemark { get; set; }

        public string? Remark { get; set; }

        public int? DirectorApproveId { get; set; }

        public string? DirectorName { get; set; }

        public int? DirectorPosId { get; set; }

        public string? DirectorPosName { get; set; }

        public int? DirectorOrgId { get; set; }

        public string? DirectorOrgName { get; set; }

        public int? LastHistoryId { get; set; }

        public int? ActionCreateBy { get; set; }

        public DateTime? ActionCreateOn { get; set; }

        public int? ActionUpdateBy { get; set; }

        public DateTime? ActionUpdateOn { get; set; }

        public int? LastWorkProcessId { get; set; }

        public string? LastWorkProcessName { get; set; }

        public int? LastWorkProcessRoleId { get; set; }

        public string? LastWorkProcessActorType { get; set; }

        public int? LastActorId { get; set; }

        public int? LastActorUserId { get; set; }

        public string? LastActorName { get; set; }

        public string? DirectorActorName { get; set; }

        public DateTime? DirectorCreateOn { get; set; }

        public string? ParcelActorName { get; set; }

        public DateTime? ParcelCreateOn { get; set; }

        public string? VehicleActorName { get; set; }

        public DateTime? VehicleCreateOn { get; set; }

        public int? NextActorId { get; set; }

        public int? NextActorUserId { get; set; }

        public string? NextActorName { get; set; }

        public int? LastActionId { get; set; }

        public string? LastActionName { get; set; }

        public string? ActionRemark { get; set; }

        public int? LastStatusId { get; set; }

        public string? LastStatusName { get; set; }

        public bool? IsFinish { get; set; }

        public int? VehicleBookingAssignId { get; set; }

        public DateTime? AssignTravelFromDate { get; set; }

        public DateTime? AssignTravelToDate { get; set; }

        public string? AssignTravelFromTime { get; set; }

        public string? AssignTravelToTime { get; set; }

        public int? DriverId { get; set; }

        public string? DriverName { get; set; }

        public int? VehicleId { get; set; }

        public string? VehicleRegistration { get; set; }

        public int? VehicleBookingRecordId { get; set; }

        public DateTime? RecordCreateOn { get; set; }

        public decimal? StartCarMileage { get; set; }

        public decimal? FinishCarMileage { get; set; }

        public decimal? TravelDistance { get; set; }

        public int? CarInspectionStatus { get; set; }

        public string? RecordRemark { get; set; }

        public int? RecordDriverId { get; set; }

        public string? RecordDriverName { get; set; }
    }
}