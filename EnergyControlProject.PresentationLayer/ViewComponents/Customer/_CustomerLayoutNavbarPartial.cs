using Microsoft.AspNetCore.Mvc;

namespace EnergyControlProject.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutNavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}