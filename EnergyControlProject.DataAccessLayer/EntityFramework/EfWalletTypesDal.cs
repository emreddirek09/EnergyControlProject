using EnergyControlProject.DataAccessLayer.Abstract;
using EnergyControlProject.DataAccessLayer.Repositories;
using EnergyControlProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyControlProject.DataAccessLayer.EntityFramework
{ 
    public class EfWalletTypesDal : GenericRepository<WalletTypes>, IWalletTypesDal
    {
    }
}
