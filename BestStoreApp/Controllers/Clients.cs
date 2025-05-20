using Microsoft.AspNetCore.Mvc;

namespace BestStoreApp.Controllers
{
    public class Clients : Controller
    {
        public IActionResult Index() // Renamed method to 'Index' to avoid conflict with class name
        {
            return View();
        }

    }
}
