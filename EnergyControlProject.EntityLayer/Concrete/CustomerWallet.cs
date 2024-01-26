using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyControlProject.EntityLayer.Concrete
{
    public class CustomerWallet
    {
        public int CustomerWalletID { get; set; }
        public string CustomerWalletName { get; set;}
        public string CustomerWalletAmount { get; set;}
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
        public DateTime CustomerWalletDate { get; set;}

    }
}
