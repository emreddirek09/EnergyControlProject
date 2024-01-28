using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyControlProject.DtoLayer.Dtos.CustomerCarDtos
{
    public class CarDto
    {
        public string CustomerCarPlaka { get; set; }
        public int CustomerCarType { get; set; }
        public int CustomerCarEnergyType { get; set; } 
        public DateTime DateTime { get; set; }
    }
}
