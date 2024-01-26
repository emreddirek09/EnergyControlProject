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
    public class CustomerAccountProcessManager:ICustomerAccountProcessService
    {
        private readonly ICustomerAccountProcessDal _customerAccountProcessDal;

        public CustomerAccountProcessManager(ICustomerAccountProcessDal customerAccountProcessDal)
        {
            _customerAccountProcessDal = customerAccountProcessDal;
        }

        public void TDelete(CustomerAccountProcess t)
        {
            _customerAccountProcessDal.Delete(t);
        }

        public CustomerAccountProcess TGetByID(int i)
        {
           return  _customerAccountProcessDal.GetByID(i);
        }

        public List<CustomerAccountProcess> TGetList()
        {
            return _customerAccountProcessDal.GetList();
        }

        public void TInsert(CustomerAccountProcess t)
        {
           _customerAccountProcessDal.Insert(t);    
        }

        public void TUpdate(CustomerAccountProcess t)
        {
            _customerAccountProcessDal.Update(t);
        }
    }
}
