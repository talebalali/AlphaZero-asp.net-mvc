﻿using System;
using AlphaZero.Data.Cart;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaZero.Data.ViewModels
{
    public class ShoppingCartVM
    {
        public ShoppingCart ShoppingCart { get; set; }
        public double ShoppingCartTotal { get; set; }
    }
}
