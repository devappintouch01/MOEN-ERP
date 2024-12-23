using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Data
{
    public class DashboardMeeting
    {
        public VDashboardMeetingRoom VDashboardMeetingRoom { get; set; }
        public List<VDashboardMeetingRoomBookingStatistic> VDashboardMeetingRoomBookingStatistic { get; set; }
        public List<VDashboardAudioVisualServiceRequestStatistic> VDashboardAudioVisualServiceRequestStatistic { get; set; }
        public List<VDashboardCateringServiceRequestStatistic> VDashboardCateringServiceRequestStatistic { get; set; }
        public List<VDashboardVideoConferenceBookingStatistic> VDashboardVideoConferenceBookingStatistic { get; set; }
    }

    public partial class VDashboardMeetingRoom
    {
        public int? MeetingRoomBookingPerMonth { get; set; }

        public int? AudioVisualServiceRequestPerMonth { get; set; }

        public int? CateringServiceRequestPerMonth { get; set; }

        public int? VideoConferenceBookingPerMonth { get; set; }

        public int? MeetingRoomCount { get; set; }

        public int? AudioVisualServiceCount { get; set; }

        public int? CateringRestaurantCount { get; set; }

        public int? VideoConferenceLicenseCount { get; set; }
    }
    public partial class VDashboardMeetingRoomBookingStatistic
    {
        public int? MeetingRoomId { get; set; }

        public string? MeetingRoomName { get; set; }

        public int? BookingPerMonth { get; set; }
    }
    public partial class VDashboardAudioVisualServiceRequestStatistic
    {
        public int? AudioVisualServiceId { get; set; }

        public string? AudioVisualServiceName { get; set; }

        public int? RequestPerMonth { get; set; }
    }
    public partial class VDashboardCateringServiceRequestStatistic
    {
        public int? MeetingRoomId { get; set; }

        public string MeetingRoomName { get; set; } = null!;

        public int? RequestPerMonth { get; set; }
    }
    public partial class VDashboardVideoConferenceBookingStatistic
    {
        public int? VideoConferenceId { get; set; }

        public string? VideoConferenceName { get; set; }

        public int? BookingPerMonth { get; set; }
    }

    public class DashboardVehicle
    {
        public VDashboardVehicle VDashboardVehicle { get; set; }
        public List<VDashboardVehicleBookingStatistic> VDashboardVehicleBookingStatistic { get; set; }
        public List<VDashboardDriverStatistic> VDashboardDriverStatistic { get; set; }
        public List<VDashboardVehicleMaintenanceStatistic> VDashboardVehicleMaintenanceStatistic { get; set; }
    }
    public partial class VDashboardVehicle
    {
        public int? VehicleBookingPerMonth { get; set; }

        public int? VehicleCount { get; set; }

        public int? DriverCount { get; set; }
    }
    public partial class VDashboardVehicleBookingStatistic
    {
        public int? VehicleId { get; set; }

        public string? VehicleRegistration { get; set; }

        public int? BookingPerMonth { get; set; }
    }
    public partial class VDashboardDriverStatistic
    {
        public int? DriverId { get; set; }

        public string? DriverName { get; set; }

        public int? WorkPerMonth { get; set; }
    }
    public partial class VDashboardVehicleMaintenanceStatistic
    {
        public int? VehicleId { get; set; }

        public string? VehicleRegistration { get; set; }

        public int? MaintenancePerMonth { get; set; }
    }
}
