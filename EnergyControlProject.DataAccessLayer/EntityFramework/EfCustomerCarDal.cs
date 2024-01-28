using EnergyControlProject.DataAccessLayer.Abstract;
using EnergyControlProject.DataAccessLayer.Concrete;
using EnergyControlProject.DataAccessLayer.Repositories;
using EnergyControlProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyControlProject.DataAccessLayer.EntityFramework
{
    public class EfCustomerCarDal : GenericRepository<CustomerCar>, ICustomerCarDal
    {
        public List<CustomerCar> MyCustomerCarById(int i)
        {
            using var context = new Context();
            var values = context.CustomerCars.Include(y=>y.carTypes).Include(z=>z.energyTypes).Where(x => x.AppUserID == i).ToList();
            return values;
        }
    }
}
