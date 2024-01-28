using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyControlProject.DtoLayer.Dtos.CustomerWalletDtos
{
    public class CustomerWalletDto
    {
        public int WalletID { get; set; }
        public string CarPlaka { get; set; }
        public string WalletName { get; set; }
        public string WalletAmount { get; set; }
        public int AppUserID { get; set; }
        public DateTime CustomerWalletDate { get; set; }
    }
}
