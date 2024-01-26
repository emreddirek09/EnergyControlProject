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
    public class StatusManager : IStatusService
    {
        private readonly IStatusDal _statusDal;

        public StatusManager(IStatusDal statusDal)
        {
            _statusDal = statusDal;
        }

        public void TDelete(Status t)
        {
            _statusDal.Delete(t);
        }

        public Status TGetByID(int i)
        {
           return _statusDal.GetByID(i);
        }

        public List<Status> TGetList()
        {
            return _statusDal.GetList();
        }

        public void TInsert(Status t)
        {
            _statusDal.Insert(t);   
        }

        public void TUpdate(Status t)
        {
            _statusDal.Update(t);
        }
    }
}
