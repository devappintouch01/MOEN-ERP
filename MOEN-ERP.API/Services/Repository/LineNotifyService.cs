using MOEN_ERP.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Net;
using System.Text;

namespace MOEN_ERP.API.Services.Repository
{
    public interface ILineNotifyService
    {
    }
    public class LineNotifyService : ILineNotifyService
    {
        private readonly MOENDBContext context;
        private readonly LineNotifyMeetingRoomGroup lineNotifyMeetingGroup;
        private readonly LineNotifyAudioVisualGroup lineNotifyAudioVisualGroup;
        private readonly LineNotifyCateringGroup lineNotifyCateringGroup;
        private readonly LineNotifyVehicleGroup lineNotifyVehicleGroup;
        private readonly LineNotifyConferenceGroup lineNotifyConferenceGroup;
        public LineNotifyService(MOENDBContext _context,
            IOptions<LineNotifyMeetingRoomGroup> _lineNotifyMeetingGroup,
            IOptions<LineNotifyAudioVisualGroup> _lineNotifyAudioVisualGroup,
            IOptions<LineNotifyCateringGroup> _lineNotifyCateringGroup,
            IOptions<LineNotifyVehicleGroup> _lineNotifyVehicleGroup,
            IOptions<LineNotifyConferenceGroup> _lineNotifyConferenceGroup
            )
        {
            context = _context;
            lineNotifyMeetingGroup = _lineNotifyMeetingGroup.Value;
            lineNotifyAudioVisualGroup = _lineNotifyAudioVisualGroup.Value;
            lineNotifyCateringGroup = _lineNotifyCateringGroup.Value;
            lineNotifyVehicleGroup = _lineNotifyVehicleGroup.Value;
            lineNotifyConferenceGroup = _lineNotifyConferenceGroup.Value;
        }


    }


    public class LineNotifyMeetingRoomGroup
    {
        public string Token { get; set; }
        public string RequestUrl { get; set; }
        public bool IsNotify { get; set; }
    }

    public class LineNotifyCateringGroup
    {
        public string Token { get; set; }
        public string RequestUrl { get; set; }
        public bool IsNotify { get; set; }
    }

    public class LineNotifyAudioVisualGroup
    {
        public string Token { get; set; }
        public string RequestUrl { get; set; }
        public bool IsNotify { get; set; }
    }
    public class LineNotifyConferenceGroup
    {
        public string Token { get; set; }
        public string RequestUrl { get; set; }
        public bool IsNotify { get; set; }
    }
    public class LineNotifyVehicleGroup
    {
        public string Token { get; set; }
        public string RequestUrl { get; set; }
        public bool IsNotify { get; set; }
    }

}
