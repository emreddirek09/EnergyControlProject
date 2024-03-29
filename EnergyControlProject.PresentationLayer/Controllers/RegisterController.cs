﻿using EnergyControlProject.DtoLayer.Dtos.AppUserDtos;
using EnergyControlProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EnergyControlProject.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    UserName = appUserRegisterDto.Username,
                    Name = appUserRegisterDto.Name,
                    SurName = appUserRegisterDto.Surname,
                    Email= appUserRegisterDto.Email,
                    StatusCode=1,
                    City= appUserRegisterDto.City,
                    District= appUserRegisterDto.District,
                    ImageUrl="xxx",
                    Address= appUserRegisterDto.Address,
                    TCKN= appUserRegisterDto.TCKN
                };

                var result = await _userManager.CreateAsync(appUser,appUserRegisterDto.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            } 
            return View();
        }
    }
}
