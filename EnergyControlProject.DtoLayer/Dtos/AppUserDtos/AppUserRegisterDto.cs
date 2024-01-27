using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyControlProject.DtoLayer.Dtos.AppUserDtos
{
    public class AppUserRegisterDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string City { get; set; } = String.Empty;
        public string District { get; set; } = String.Empty;
        public string ImageUrl { get; set; } = String.Empty;
        public string Address { get; set; } = String.Empty;
        public string TCKN { get; set; } = String.Empty;
    }
}
