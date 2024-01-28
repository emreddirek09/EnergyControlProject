using EnergyControlProject.DataAccessLayer.Abstract;
using EnergyControlProject.EntityLayer.Concrete;
using EnergyControlProjectBusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyControlProjectBusinessLayer.Concrete
{
    public class CustomerCarManager : ICustomerCarService
    {
        private readonly ICustomerCarDal _customerCarDal;

        public CustomerCarManager(ICustomerCarDal customerCarDal)
        {
            _customerCarDal = customerCarDal;
        }

        public void TDelete(CustomerCar t)
        {
            _customerCarDal.Delete(t);  
        }

        public CustomerCar TGetByID(int i)
        {
            return _customerCarDal.GetByID(i);
        }

        public List<CustomerCar> TGetList()
        {
          return _customerCarDal.GetList(); 
        }

        public void TInsert(CustomerCar t)
        {
            _customerCarDal.Insert(t);
        }

        public List<CustomerCar> TMyCustomerCarById(int i)
        {
            return _customerCarDal.MyCustomerCarById(i);
        }

        public void TUpdate(CustomerCar t)
        {
            _customerCarDal.Update(t);
        }
    }
}
