using Microsoft.AspNetCore.Mvc;

namespace MOEN_ERP.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode,string errorMassage, bool showButton = true, bool showTitle = true)
        {
            var userCur = new Appz(HttpContext)?.CurrentSignInUser;
            if (userCur?.User != null)
            {
                switch (statusCode)
                {
                    case 404:
                        ViewBag.StatusCode = statusCode.ToString();
                        ViewBag.ErrorMessage = "Sorry, the page you requested could not be found.";
                        ViewBag.ShowTitle = showTitle;
                        ViewBag.ShowButton = showButton;
                        break;
                    case 500:
                        ViewBag.ErrorMessage = "Sorry, something went wrong on the server.";
                        ViewBag.StatusCode = statusCode.ToString();
                        ViewBag.ShowTitle = showTitle;
                        ViewBag.ShowButton = showButton;
                        break;
                    default:
                        ViewBag.StatusCode = statusCode.ToString();
                        ViewBag.ErrorMessage = errorMassage;
                        ViewBag.ShowTitle = showTitle;
                        ViewBag.ShowButton = showButton;
                        break;
                }
                return View("Error");
            }
            else {
                return RedirectToAction("SignIn", "Authen");
            }
        }

        

    }
}
