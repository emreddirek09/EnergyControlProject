using EnergyControlProject.DtoLayer.Dtos.AppUserDtos;
using EnergyControlProject.EntityLayer.Concrete;
using EnergyControlProject.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EnergyControlProject.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel loginViewModel)
        {
            var result = await _signInManager.PasswordSignInAsync(loginViewModel.Username, loginViewModel.Password, true, true);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(loginViewModel.Username);
                if (user.StatusCode == 2 || user.StatusCode == 1)
                {
                    return RedirectToAction("Index", "CustomerAccount");
                }
                // Lütfen kayıt onay süreci için bekleyiniz.
            }
            //kullanıcı adı veya şifre hatalıı
            return View();
        }
    }
}
