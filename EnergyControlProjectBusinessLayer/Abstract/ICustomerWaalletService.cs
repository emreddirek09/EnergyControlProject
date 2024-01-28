﻿using EnergyControlProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyControlProjectBusinessLayer.Abstract
{
    public interface ICustomerWaalletService : IGenericService<CustomerWallet>
    {
        List<CustomerWallet> TMyCustomerWalletById(int i);
    }
}
