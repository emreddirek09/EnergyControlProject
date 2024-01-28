using EnergyControlProject.DataAccessLayer.Abstract;
using EnergyControlProject.DataAccessLayer.Concrete;
using EnergyControlProject.DataAccessLayer.Repositories;
using EnergyControlProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyControlProject.DataAccessLayer.EntityFramework
{
    public class EfCustomerWalletDal:GenericRepository<CustomerWallet>,ICustomerWalletDal
    {
        
    }
}
