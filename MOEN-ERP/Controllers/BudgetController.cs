using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.ViewModel;
using MOEN_ERP.Services;
using MOEN_ERP.Services.Repository;

namespace MOEN_ERP.Controllers
{
    public class BudgetController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly SettingsModel _settingsModels;
        private readonly IBudgetService _budgetService;
        private readonly IDropdowns _dropdowns;

        public BudgetController(HttpClient httpClient, IOptions<SettingsModel> option, IBudgetService budgetService, IDropdowns dropdowns)
        {
            _httpClient = httpClient;
            _settingsModels = option.Value;
            _budgetService = budgetService;
            _dropdowns = dropdowns;
        }
        public async Task<IActionResult> BudgetRequestList()
        {
            ViewBag.DropdownOrganization = await _dropdowns.DropdownOrganization();
            ViewBag.DropdownStatus = new SelectList(new[]
                {
                    new { Value = "1", Text = "Active" },
                    new { Value = "2", Text = "Inactive" }
                }, "Value", "Text");


            return View();
        }

        public async Task<IActionResult> SearchBudgetRequestList(BudgetRequestFilter filter)
        {
            // call budget service to get data
            List<BudgetRequestViewModel> data = _budgetService.GetBudgetListAsync(filter).Result;

            return PartialView("_partialView/_tableBudgetRequest", data);
        }

        public async Task<IActionResult> DeleteBudgetRequest(int Id)
        {
            // call budget service to get data
            _budgetService.DeleteBudgetRequest(Id);

            return Ok();
        }

        public async Task<IActionResult> BudgetRequestDetail(int? Id)
        {
            ViewBag.DropdownOrganization = await _dropdowns.DropdownOrganization();
            BudgetRequestDetailViewModel data = new BudgetRequestDetailViewModel();
            if (Id.HasValue)
            {
                data = _budgetService.GetBudgetRequestDetail(Id.Value).Result;
            }
            

            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> BudgetRequestDetail(BudgetRequestForm data)
        {
            ViewBag.DropdownOrganization = await _dropdowns.DropdownOrganization();
            
            BudgetRequestDetailViewModel result = _budgetService.SaveBudgetList(data).Result;


            return View(result);
        }

        public async Task<IActionResult> BudgetRequestExpensesDetail()
        {
            ViewBag.DropdownUnit = await _dropdowns.DropdownUnit();
            return View();
        }


        public IActionResult BudgetRequestSubsidyDetail()
        {
            return View();
        }
        public IActionResult BudgetRequestInvestmentDetail()
        {
            return View();
        }
        public IActionResult BudgetRequestOtherExpensesDetail()
        {
            return View();
        }

        /// <summary>
        /// จัดสรรงบเบิกจ่ายแทนกันกรมธุรกิจพลังงาน
        /// </summary>
        /// <returns></returns>
        public IActionResult BudgetAllocateDisbursementInsteadDetail()
        {
            return View();
        }
        /// <summary>
        /// รายการแผนการจัดซื้อจัดจ้าง
        /// </summary>
        /// <returns></returns>
        public IActionResult BudgetPlanProcurementList()
        {
            return View();
        }
        /// <summary>
        /// รายการเบิกจ่ายงบประมาณแผ่นดิน
        /// </summary>
        /// <returns></returns>
        public IActionResult BudgetRequisitionList()
        {
            return View();
        }
        /// <summary>
        /// รายละเอียดการเบิกจ่ายงบประมาณแผ่นดิน
        /// </summary>
        /// <returns></returns>
        public IActionResult BudgetRequisitionDetail()
        {
            return View();
        }
        /// <summary>
        /// รายการเบิกจ่ายงบประมาณเงินนอกงบประมาณ
        /// </summary>
        /// <returns></returns>
        public IActionResult BudgetRequisitionOutsideList()
        {
            return View();
        }
        /// <summary>
        /// รายละเอียดการเบิกจ่ายงบประมาณเงินนอกงบประมาณ
        /// </summary>
        /// <returns></returns>
        public IActionResult BudgetRequisitionOutsideDetail()
        {
            return View();
        }
        /// <summary>
        /// รายการจัดสรรเงินนอกงบประมาณ
        /// </summary>
        /// <returns></returns>
        public IActionResult BudgetAllocateOutsideList()
        {

            return View();
        }
        /// <summary>
        /// รายละเอียดการจัดสรรเงินนอกงบประมาณ
        /// </summary>
        /// <param name="BudgetType"></param>
        /// <returns></returns>
        public IActionResult BudgetAllocateOutsideDetail(int BudgetType)
        {
            ViewBag.BudgetType = BudgetType;
            return View();
        }

        /// รายการจัดสรรงบประมาณแผ่นดิน
        public IActionResult BudgetAllocateList()
        {
            return View();
        }
        /// รายละเอียดการจัดสรรงบประมาณแผ่นดิน
        public IActionResult BudgetAllocateDetail()
        {
            return View();
        }
        public IActionResult BudgetConsiderList()
        {
            return View();
        }
        public IActionResult BudgetConsiderDetail()
        {
            return View();
        }
        public IActionResult BudgetRequestOutsideList()
        {
            return View();
        }
        public IActionResult BudgetRequestOutsideDetail()
        {
            return View();
        }
        public IActionResult BudgetRequestProvinceList()
        {
            return View();
        }
        public IActionResult BudgetRequestProvinceDetail()
        {
            return View();
        }
        public IActionResult BudgetAllocateProvinceList()
        {
            return View();
        }
        public IActionResult BudgetAllocateProvinceDetail()
        {
            return View();
        }
        /// รายการจัดสรรงบเบิกจ่ายแทนกันกรมธุรกิจพลังงาน
        public IActionResult BudgetAllocateDisbursementInsteadList()
        {
            return View();
        }
        ///23. หน้าจอรายการแผนการใช้จ่ายงบประมาณ
        public IActionResult BudgetPlanExpenseList()
        {
            return View();
        }
        ///24. หน้าจอรายละเอียดแผนการใช้จ่ายงบประมาณ
        public IActionResult BudgetPlanExpenseDetail()
        {
            return View();
        }
        ///25.หน้าจอปรับแผนการใช้จ่ายงบประมาณ
        public IActionResult BudgetPlanExpenseAdjustList()
        {
            return View();
        }
        ///26.หน้าจอรายละเอียดปรับแผนการใช้จ่ายงบประมาณ
        public IActionResult BudgetPlanExpenseAdjustDetail()
        {
            return View();
        }
        ///27.หน้าจอรายการเงินเหลือจ่าย
        public IActionResult BudgetRemainList()
        {
            return View();
        }
        ///28.หน้าจอรายละเอียดเงินเหลือจ่าย
        public IActionResult BudgetRemainDetail()
        {
            return View();
        }
        ///29.หน้าจอรายการบริหารงบประมาณแผ่นดิน
        public IActionResult BudgetManagementList()
        {
            return View();
        }
        ///30.หน้าจอรายละเอียดการบริหารงบประมาณแผ่นดิน
        public IActionResult BudgetManagementDetail()
        {
            return View();
        }

        //31. หน้าจอรายการคำขอเงินงบประมาณเพิ่มเติม
        public IActionResult BudgetRequestMoreList()
        {
            return View();
        }
        //32. หน้าจอรายละเอียดคำขอเงินงบประมาณเพิ่มเติม
        public IActionResult BudgetRequestMoreDetail()
        {
            return View();
        }

        //33. หน้าจอรายการเบิกจ่ายงบจังหวัด/งบกลุ่มจังหวัด
        public IActionResult BudgetRequisitionProvinceList()
        {
            return View();
        }
        //34. หน้าจอรายละเอียดการเบิกจ่ายงบจังหวัด/งบกลุ่มจังหวัด
        public IActionResult BudgetRequisitionProvinceDetail()
        {
            return View();
        }

        //35. หน้าจอรายการเบิกจ่ายแทนกันกรมธุรกิจพลังงาน
        public IActionResult BudgetRequisitionDisbursementInsteadList()
        {
            return View();
        }
        //36. หน้าจอรายละเอียดการเบิกจ่ายแทนกันกรมธุรกิจพลังงาน
        public IActionResult BudgetRequisitionDisbursementInsteadDetail()
        {
            return View();
        }

        //37. หน้าจอรายการกันเหลื่อมปี
        public IActionResult BudgetOverlapYearList()
        {
            return View();
        }
        //38. หน้าจอรายละเอียดการกันเหลื่อมปี
        public IActionResult BudgetOverlapYearDetail()
        {
            return View();
        }

        //39. หน้าจอรายการทะเบียนคุมเงินนอกงบประมาณ
        public IActionResult BudgetManagementOutsideList()
        {
            return View();
        }
        //40. หน้าจอรายละเอียดทะเบียนคุมเงินนอกงบประมาณ
        public IActionResult BudgetManagementOutsideDetail()
        {
            return View();
        }
        //41. หน้าจอรายการทะเบียนคุมงบจังหวัด/งบกลุ่มจังหวัด
        public IActionResult BudgetManagementProvinceList()
        {
            return View();
        }
        //42. หน้าจอรายละเอียดทะเบียนคุมงบจังหวัด/งบกลุ่มจังหวัด
        public IActionResult BudgetManagementProvinceDetail()
        {
            return View();
        }
        //43. หน้าจอรายการทะเบียนคุมงบเบิกจ่ายแทนกันกรมธุรกิจพลังงาน
        public IActionResult BudgetManagementDisbursementInsteadList()
        {
            return View();
        }
        //44. หน้าจอรายละเอียดทะเบียนคุมงบเบิกจ่ายแทนกันกรมธุรกิจพลังงาน
        public IActionResult BudgetManagementDisbursementInsteadDetail()
        {
            return View();
        }
    }
}
