﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyControlProject.EntityLayer.Concrete
{
    public class CustomerCar
    {
        public int CustomerCarID { get; set; }
        public string CustomerCarPlaka { get; set; }
        public int CustomerCarType { get; set; }
        public int CustomerCarEnergyType { get; set; }
        public int AppUserID { get; set; }
        public List<EnergyTypes> energyTypes { get; set; }
        public List<CarTypes> carTypes { get; set; }
        public DateTime CustomerCarDate { get; set; }
    }
}
