using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyControlProject.EntityLayer.Concrete
{
    public class Akaryakit
    {
        public int AkaryakitID { get; set; }
        public string AkaryakitCarPlaka { get; set; }
        public decimal AkaryakitAmount { get; set; }
        public DateTime AkaryakitDate { get; set; }

    }
}
