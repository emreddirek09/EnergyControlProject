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
    public class EfCustomerWalletDal : GenericRepository<CustomerWallet>, ICustomerWalletDal
    {
        public List<CustomerWallet> MyCustomerWalletById(int i)
        {
            using var context = new Context();
            var values = context.CustomerWallet.Include(y => y.WalletTypes).Where(x => x.AppUserID == i).ToList();
            return values;
        } 
    }
}
