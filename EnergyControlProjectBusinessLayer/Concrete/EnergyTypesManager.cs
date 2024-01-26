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
    public class EnergyTypesManager : IEnergyTypeService
    {
        private readonly IEnergyTypeDal _energyTypeDal;

        public EnergyTypesManager(IEnergyTypeDal energyTypeDal)
        {
            _energyTypeDal = energyTypeDal;
        }

        public void TDelete(EnergyTypes t)
        {
            _energyTypeDal.Delete(t);
        }

        public EnergyTypes TGetByID(int i)
        {
          return _energyTypeDal.GetByID(i);
        }

        public List<EnergyTypes> TGetList()
        {
          return _energyTypeDal.GetList();
        }

        public void TInsert(EnergyTypes t)
        {
            _energyTypeDal.Insert(t);
        }

        public void TUpdate(EnergyTypes t)
        {
            _energyTypeDal.Update(t);
        }
    }
}
