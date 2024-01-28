using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyControlProject.EntityLayer.Concrete
{
    public class WalletTypes
    {
        public int WalletTypesID { get; set; }
        public string WalletName { get; set; }
        public decimal Amount { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime LastDate { get; set; }
        public int CustomerWalletID { get; set; }

        public CustomerWallet CustomerWallet { get; set; }


    }
}
