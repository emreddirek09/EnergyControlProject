using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyControlProject.EntityLayer.Concrete
{
    public class CustomerCar
    {
        public int CustomerCarID { get; set; }

        public string CustomerCarPlaka { get; set; }

        public string CustomerCarType { get; set; }

        public string CustomerCarEnergyType { get; set;}

        public DateTime CustomerCarDate { get; set; }
    }
}
