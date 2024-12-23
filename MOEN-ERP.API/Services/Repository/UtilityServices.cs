using MOEN_ERP.DAL.Models;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using MOEN_ERP.Models.Common;
using System.Diagnostics.Eventing.Reader;
using MOEN_ERP.Models.Data;

namespace MOEN_ERP.API.Services.Repository
{
    public interface IUtilityServices
    {
       
    }
    public class UtilityServices : IUtilityServices
    {
        private readonly ILineNotifyService _lineNotifyService;
        private readonly IMobileNotificationService _mobileNotiService;
        public UtilityServices(ILineNotifyService lineNotifyService, IMobileNotificationService mobileNotiService)
        {
            _lineNotifyService = lineNotifyService;
            _mobileNotiService = mobileNotiService;
        }
       
    }
}
