using MOEN_ERP.Models;
using MOEN_ERP.Models.ViewModel;
using MOEN_ERP.Services.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MOEN_ERP.Controllers
{
    
    public class HomeController : Controller
    {

        private readonly IRawDataService _rawData;
        public HomeController(IRawDataService rawData)
        {
            _rawData = rawData;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ComingSoon()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


       

    }
}