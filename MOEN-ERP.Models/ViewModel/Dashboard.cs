using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel
{
    public class Dashboard
    {
    }


    public class CalendarEvent
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public string? color { get; set; }
        public string? EventLocation { get; set; }
        public string? BookerName { get; set; }
        public string? BookingPurpose { get; set; }
        public string? BookerPhone { get; set; }
        public string? DriverName { get; set; }
        public string? DriverPhone { get; set; }
        public string? Topic { get; set; }
        public string? BookingTypeName { get; set; }
        public string? BookerOrgName { get; set; }
        public string? TimeString { get; set; }
        public string? VehicleRegistration { get; set; }
        public string? MeetingRoomName { get; set; }
        public string? RealUserName { get; set; }
    }

    public class CalendarTimelineResources
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? eventColor { get; set; }
    }

    public class CalendarTimelineEvent
    {
        public int? groupId { get; set; }
        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public string? EventLocation { get; set; }
        public string? BookerName { get; set; }
        public string? BookingPurpose { get; set; }
        public string? BookerPhone { get; set; }
        public string? DriverName { get; set; }
        public string? DriverPhone { get; set; }
        public string? Topic { get; set; }
        public string? BookingTypeName { get; set; }
        public string? BookerOrgName { get; set; }
        public string? color { get; set; }
        public int? ResourceId { get; set; }
        public string? TimeString { get; set; }
        public string? MeetingRoomName { get; set; }
        public string? RealUserName { get; set; }

    }

    public class DateTimeModel
    {
        public DateTime DateTimeValue { get; set; }
    }
}
