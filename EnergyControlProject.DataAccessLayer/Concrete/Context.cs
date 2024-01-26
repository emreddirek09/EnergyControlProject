using EnergyControlProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyControlProject.DataAccessLayer.Concrete
{
    public class Context: IdentityDbContext<AppUser, AppRole, int>
    {
        //IdentityDbContext<AppUser,AppRole,int>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS; initial catalog=EnergyControlDb; integrated Security=true;  TrustServerCertificate=True");
        }
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public DbSet<CustomerAccountProcess> CustomerAccountProcesses { get; set; }

        public DbSet<Akaryakit> Akaryakits { get; set; }
        public DbSet<CarTypes> CarTypeses { get; set; }
        public DbSet<CustomerCar> CustomerCars { get; set; }
        public DbSet<CustomerWallet> CustomerWallet { get; set; }
        public DbSet<EnergyTypes> EnergyTypeses { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}
