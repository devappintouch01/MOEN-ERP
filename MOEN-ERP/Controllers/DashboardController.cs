using Microsoft.AspNetCore.Mvc;

namespace MOEN_ERP.Controllers
{
    public class DashboardController : Controller
    {
        //1. รายงานและสถิติระบบงบประมาณ
        public IActionResult DashboardBudget()
        {
            return View();
        }
        //2. รายงานและสถิติระบติดตามและประเมินโครงการ
        public IActionResult DashboardProjectTracking()
        {
            return View();
        }
        //3. รายงานและสถิติระบบพัสดุ
        public IActionResult DashboardAsset()
        {
            return View();
        }
    }
}
