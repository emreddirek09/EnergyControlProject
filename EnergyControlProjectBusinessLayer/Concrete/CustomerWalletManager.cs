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
    public class CustomerWalletManager : ICustomerWaalletService
    {
        private readonly ICustomerWalletDal _customerWalletDal;

        public CustomerWalletManager(ICustomerWalletDal customerWalletDal)
        {
            _customerWalletDal = customerWalletDal;
        }

        public void TDelete(CustomerWallet t)
        {
            _customerWalletDal.Delete(t);   
        }

        public CustomerWallet TGetByID(int i)
        {
            return  _customerWalletDal.GetByID(i);    
        }

        public List<CustomerWallet> TGetList()
        {
           return _customerWalletDal.GetList();
        }

        public void TInsert(CustomerWallet t)
        {
            _customerWalletDal.Insert(t);
        }

        public void TUpdate(CustomerWallet t)
        {
            _customerWalletDal.Update(t);
        }
    }
}
