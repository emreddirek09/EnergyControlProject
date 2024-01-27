using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EnergyControlProject.PresentationLayer.Controllers
{
    [Authorize]
    public class RegisterProfilController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
