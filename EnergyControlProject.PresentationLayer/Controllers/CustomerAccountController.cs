using EnergyControlProject.DtoLayer.Dtos.AppUserDtos;
using EnergyControlProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace EnergyControlProject.PresentationLayer.Controllers
{
   // [Authorize]
    public class CustomerAccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public CustomerAccountController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUserEditDto appUserEditDto = new AppUserEditDto()
            {
                Name = values.Name,
                Surname = values.SurName,
                City = values.City,
                District = values.District,
                Email = values.Email,
                ImageUrl = values.ImageUrl,
                PhoneNumber = values.PhoneNumber

            };
            return View(appUserEditDto);
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserEditDto appUserEditDto)
        {
            if (ModelState.IsValid)
            {
                if (appUserEditDto.Password == appUserEditDto.ConfirmPassword)
                {
                    var user = await _userManager.FindByNameAsync(User.Identity.Name);
                    user.PhoneNumber = appUserEditDto.PhoneNumber;
                    user.SurName = appUserEditDto.Surname;
                    user.City = appUserEditDto.City;
                    user.District = appUserEditDto.District;
                    user.Name = appUserEditDto.Name;
                    user.ImageUrl = "xxx";
                    user.Email = appUserEditDto.Email;
                    user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, appUserEditDto.Password);
                    var res = await _userManager.UpdateAsync(user);
                    if (res.Succeeded)
                    {
                        return RedirectToAction("Index", "CustomerAccount");
                    }

                }
            }
            else
            {
                foreach (var item in ModelState.Root.Children)
                {
                    foreach (var item1 in item.Errors)
                    {
                        ModelState.AddModelError("", item1.ErrorMessage);
                    }
                        
                }
            }

            return View();
        }
    }
}
