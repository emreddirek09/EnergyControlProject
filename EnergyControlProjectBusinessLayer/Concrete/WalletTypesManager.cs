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
    public class WalletTypesManager : IWalletTypesService
    {
        private readonly IWalletTypesDal _walletTypesDal;

        public WalletTypesManager(IWalletTypesDal walletTypesDal)
        {
            _walletTypesDal = walletTypesDal;
        }

        public void TDelete(WalletTypes t)
        {
            _walletTypesDal.Delete(t);
        }

        public WalletTypes TGetByID(int i)
        {
            return _walletTypesDal.GetByID(i);
        }

        public List<WalletTypes> TGetList()
        {
            return _walletTypesDal.GetList();
        }

        public void TInsert(WalletTypes t)
        {
            _walletTypesDal.Insert(t);
        }

        public void TUpdate(WalletTypes t)
        {
           _walletTypesDal.Update(t);
        }
    }
}
