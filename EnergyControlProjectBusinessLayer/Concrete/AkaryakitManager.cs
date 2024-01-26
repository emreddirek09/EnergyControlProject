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
    public class AkaryakitManager : IAkaryakitService
    {
        private readonly IAkaryakitDal _akaryakitDal;

        public AkaryakitManager(IAkaryakitDal akaryakitDal)
        {
            _akaryakitDal = akaryakitDal;
        }

        public void TDelete(Akaryakit t)
        {
            _akaryakitDal.Delete(t);
        }

        public Akaryakit TGetByID(int i)
        {
            return _akaryakitDal.GetByID(i);
        }

        public List<Akaryakit> TGetList()
        {
           return _akaryakitDal.GetList();
        }

        public void TInsert(Akaryakit t)
        {
            _akaryakitDal.Insert(t);
        }

        public void TUpdate(Akaryakit t)
        {
            _akaryakitDal.Update(t);
        }
    }
}
