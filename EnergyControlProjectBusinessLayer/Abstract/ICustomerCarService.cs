using EnergyControlProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyControlProjectBusinessLayer.Abstract
{
    public interface ICustomerCarService : IGenericService<CustomerCar>
    {
        List<CustomerCar> TMyCustomerCarById(int i);
    }
}
