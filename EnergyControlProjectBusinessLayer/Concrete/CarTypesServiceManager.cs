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
    public class CarTypesServiceManager : ICarTypesService
    {
        private readonly ICarTypesDal _carTypesDal;

        public CarTypesServiceManager(ICarTypesDal carTypesDal)
        {
            _carTypesDal = carTypesDal;
        }

        public void TDelete(CarTypes t)
        {
            _carTypesDal.Delete(t);
        }

        public CarTypes TGetByID(int i)
        {
            return _carTypesDal.GetByID(i); 
        }

        public List<CarTypes> TGetList()
        {
            return _carTypesDal.GetList();
        }

        public void TInsert(CarTypes t)
        {
            _carTypesDal.Insert(t);
        }

        public void TUpdate(CarTypes t)
        {
            _carTypesDal.Update(t);
        }
    }
}
