using Microsoft.AspNetCore.Mvc;

namespace mentorient.Controllers
{
    public class AccountingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}