﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.EsercizioDI_IoC.PL
{
    public interface IPriceCalculator 
    { 
        decimal CalculatePrice(int quantity, decimal unitPrice); 
    }
}
