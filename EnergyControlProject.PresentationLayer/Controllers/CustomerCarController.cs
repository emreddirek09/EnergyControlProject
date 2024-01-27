using EnergyControlProject.DataAccessLayer.Concrete;
using EnergyControlProject.DtoLayer.Dtos.AppUserDtos;
using EnergyControlProject.DtoLayer.Dtos.CustomerCarDtos;
using EnergyControlProject.EntityLayer.Concrete;
using EnergyControlProjectBusinessLayer.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EnergyControlProject.PresentationLayer.Controllers
{
    public class CustomerCarController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, Context context) : Controller
    {
        private readonly UserManager<AppUser> _userManager = userManager;
        private readonly SignInManager<AppUser> _signInManager = signInManager;
        private readonly Context _context = context;
        private readonly ICustomerCarService _customerCarService;

        [HttpGet]
        public IActionResult Index()
        {
            var car = _context.CarTypeses.ToList();
            var carNames = car.Select(s => new { Id = s.CarTypesID, Name = s.CarTypesName });

            var energy = _context.EnergyTypeses.ToList();
            var energyTypeses = energy.Select(s => new { Id = s.EnergyTypesID, Name = s.EnergyTypesName });

            ViewBag.CarList = new SelectList(carNames, "Id", "Name");
            ViewBag.EnergyList = new SelectList(energyTypeses, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CarDto carDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                CustomerCar customerCar = new CustomerCar()
                { 
                    AppUserID= user.Id,
                    CustomerCarDate = DateTime.Now, 
                    CustomerCarPlaka=carDto.CustomerCarPlaka,
                    CustomerCarType=carDto.CustomerCarType,
                    CustomerCarEnergyType=carDto.CustomerCarEnergyType, 
                    AppUser=user                
                    
                };

                _customerCarService.TInsert(customerCar);

                return RedirectToAction("Index","CustomerCar");

            }

            return View();
        }
    }
}
