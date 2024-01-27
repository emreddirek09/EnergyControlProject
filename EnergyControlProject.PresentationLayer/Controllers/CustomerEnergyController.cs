using Microsoft.AspNetCore.Mvc;

namespace EnergyControlProject.PresentationLayer.Controllers
{
    public class CustomerEnergyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
