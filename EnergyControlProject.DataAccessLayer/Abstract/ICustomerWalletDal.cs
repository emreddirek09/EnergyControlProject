using EnergyControlProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyControlProject.DataAccessLayer.Abstract
{
    public interface ICustomerWalletDal:IGenericDal<CustomerWallet>
    {
        List<CustomerWallet> MyCustomerWalletById(int i);
    }
}
