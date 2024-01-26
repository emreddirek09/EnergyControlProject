using EnergyControlProject.DataAccessLayer.Abstract;
using EnergyControlProject.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyControlProject.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context con = new Context();   
        public void Delete(T t)
        { 
            con.Set<T>().Remove(t);
            con.SaveChanges();
        }

        public T GetByID(int i)
        {
            return con.Set<T>().Find(i);
        }

        public List<T> GetList()
        {
           return con.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            con.Set<T>().Add(t);
            con.SaveChanges();
        }

        public void Update(T t)
        {
            con.Set<T>().Update(t);
            con.SaveChanges();
        }
    }
}
