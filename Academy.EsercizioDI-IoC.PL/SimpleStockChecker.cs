using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.EsercizioDI_IoC.PL
{
    public class SimpleStockChecker : IStockChecker
    {
        public bool IsInStock(string productId, int quantity)
        {            
            // Simulazione: supponiamo che ci siano sempre 10 unità disponibili
            Console.WriteLine($"Controllo stock per '{productId}': richiesto {quantity}, disponibile 10");            
            return quantity <= 10; 
        } 
    }
}
