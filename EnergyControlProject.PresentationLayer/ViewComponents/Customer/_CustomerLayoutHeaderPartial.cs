using Microsoft.AspNetCore.Mvc;

namespace EnergyControlProject.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutHeaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
