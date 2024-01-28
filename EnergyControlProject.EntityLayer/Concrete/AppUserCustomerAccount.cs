using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyControlProject.EntityLayer.Concrete
{
    public class AppUserCustomerAccount
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public int CustomerAccountId { get; set; }
    }
}
