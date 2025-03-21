using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.EsercizioDI_IoC.PL
{
    public class InventoryService : IInventoryService 
    { 
        private readonly IStockChecker _stockChecker; 
        public InventoryService(IStockChecker stockChecker) 
        { 
            _stockChecker = stockChecker ?? throw new ArgumentNullException(nameof(stockChecker)); 
        }
        public bool CheckAvailability(string productId, int quantity)
        {
            return _stockChecker.IsInStock(productId, quantity);
        }
    }
}
