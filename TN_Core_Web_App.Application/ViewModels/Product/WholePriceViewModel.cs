﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TN_Core_Web_App.Application.ViewModels.Product
{
    public class WholePriceViewModel
    {
        public int ProductId { get; set; }

        public int FromQuantity { get; set; }

        public int ToQuantity { get; set; }

        public decimal Price { get; set; }
    }
}
