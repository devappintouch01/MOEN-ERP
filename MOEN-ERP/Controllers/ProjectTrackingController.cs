using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MOEN_ERP.Controllers
{
    public class ProjectTrackingController : Controller
    {
        //1. หน้าจอรายการโครงการ
        public IActionResult ProjectList()
        {
            return View();
        }
        //2. หน้าจอรายละเอียดโครงการ
        public IActionResult ProjectDetail(int tabSelected)
        {
            ViewBag.tabSelected = tabSelected;
            return View();
        }
        //3.หน้าจอรายการโครงการควบคุมภายใน
        public IActionResult ProjectInternalControlList()
        {
            return View();
        }
        //4.หน้าจอรายละเอียดแบบ ปค.1
        public IActionResult ProjectInternalControlDetail1()
        {
            return View();
        }
        //5.หน้าจอรายละเอียดแบบ ปค.4
        public IActionResult ProjectInternalControlDetail4()
        {
            return View();
        }
        //6.หน้าจอรายละเอียดแบบ ปค.5
        public IActionResult ProjectInternalControlDetail5()
        {
            return View();
        }
        //7.หน้าจอรายละเอียดแบบติดตาม ปค.5
        public IActionResult ProjectInternalControlTrackingDetail5()
        {
            return View();
        } 
        //8. หน้าจอรายงานความก้าวหน้าประจำเดือน
        public IActionResult ProjectMonthlyProgressList()
        {
            return View();
        }
        //9. หน้าจอรายงานความก้าวหน้าประจำเดือน (หน้ากลาง)
        public IActionResult ProjectMonthlyProgressCentralDetail()
        {
            return View();
        }
        //10. หน้าจอรายละเอียดความก้าวหน้าประจำเดือน
        public IActionResult ProjectMonthlyProgressDetail()
        {
            return View();
        }
        //11. หน้าจอการดำเนินงานตามนโยบายรัฐบาลและข้อสั่งการนายกรัฐมนตรีของสำนักเลขาธิการนายกรัฐมนตรี
        public IActionResult ProjectGovernmentList()
        {
            return View();
        }
        //12. หน้าจอรายละเอียดนโยบายของรัฐบาล
        public IActionResult ProjectGovernmentPolicyDetail()
        {
            return View();
        }
        //13. หน้าจอรายละเอียดข้อสั่งการนายกรัฐมนตรีของสำนักเลขาธิการนายกรัฐมนตรี
        public IActionResult ProjectGovernmentCommandDetail()
        {
            return View();
        }
        //14. หน้าจอติดตามสถานะการดำเนินงานโครงการ
        public IActionResult ProjectTrackingStatusList()
        {
            return View();
        }
        //15. หน้าจอรายละเอียดการติดตามสถานะการดำเนินงานโครงการ (หน้ากลาง)
        public IActionResult ProjectTrackingStatusCentralDetail()
        {
            return View();
        }
        //16. หน้าจอรายละเอียดการติดตามสถานะการดำเนินงานโครงการ
        public IActionResult ProjectTrackingStatusDetail()
        {
            return View();
        }
    }
}
