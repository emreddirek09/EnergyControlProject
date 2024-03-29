﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyControlProject.EntityLayer.Concrete
{
    public class AppUser:  IdentityUser<int>
    {
        public string Name { get; set; }
        public string SurName { get; set; }     
        public string TCKN { get; set; }     
        public string District { get; set; }     
        public string City { get; set; }     
        public string ImageUrl { get; set; }     
        public string Address { get; set; }           
        public int  StatusCode { get; set; }       
        
        public List<CustomerAccount> CustomerAccounts { get; set; }=new List<CustomerAccount>();
        public List<CustomerCar> CustomerCars { get; set; } = new List<CustomerCar>();
        public List<CustomerWallet> CustomerWallets { get; set; } = new List<CustomerWallet>();
    }
}
