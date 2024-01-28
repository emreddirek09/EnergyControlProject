using EnergyControlProject.DataAccessLayer.Concrete;
using EnergyControlProject.DtoLayer.Dtos.CustomerCarDtos;
using EnergyControlProject.DtoLayer.Dtos.CustomerWalletDtos;
using EnergyControlProject.EntityLayer.Concrete;
using EnergyControlProjectBusinessLayer.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EnergyControlProject.PresentationLayer.Controllers
{
    public class CustomerEnergyController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly Context _context;
        private readonly ICustomerCarService _customerCarService;
        private readonly ICustomerWaalletService _customerWaalletService;
        private readonly IWalletTypesService _walletTypesService;

        public CustomerEnergyController(UserManager<AppUser> userManager, Context context, ICustomerCarService customerCarService, ICustomerWaalletService customerWaalletService, IWalletTypesService walletTypesService)
        {
            _userManager = userManager;
            _context = context;
            _customerCarService = customerCarService;
            _customerWaalletService = customerWaalletService;
            _walletTypesService = walletTypesService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var customerCarList = _customerCarService.TMyCustomerCarById(user.Id).ToList();

            var MyCarList = customerCarList.Select(s => new { Id = s.CustomerCarID, Name = s.CustomerCarPlaka });
            ViewBag.CcustomerCarList = new SelectList(MyCarList, "Id", "Name");

            var WalletList = _walletTypesService.TGetList();
            var MyWalletList = WalletList.Select(s => new { Id = s.WalletTypesID, Name = s.WalletName });
            ViewBag.MyWalletLists = new SelectList(MyWalletList, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CustomerWalletDto _customerWalletDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                CustomerWallet customerWallet = new CustomerWallet()
                {
                    AppUserID = user.Id,
                    CustomerWalletAmount= _customerWalletDto.WalletAmount,
                    CustomerWalletID=_customerWalletDto.WalletID,
                    CustomerWalletName= _customerWalletDto.WalletName

                };

                _customerWaalletService.TInsert(customerWallet);

                return RedirectToAction("Index", "CustomerEnergy");

            }
            else
            {
                return RedirectToAction("Index", "CustomerEnergy");
            }

            return View();
        }
    }
}
