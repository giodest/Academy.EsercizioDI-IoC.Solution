using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.EsercizioDI_IoC.PL
{
    public class StandardPriceCalculator : IPriceCalculator 
    { 
        public decimal CalculatePrice(int quantity, decimal unitPrice) 
        { 
            return quantity * unitPrice; 
        } 
    }
}
