using Microsoft.AspNetCore.Mvc;

namespace EnergyControlProject.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutSidebarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
