using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.EsercizioDI_IoC.PL
{
    public class OrderManager
    {
        private readonly IPriceCalculator _priceCalculator;
        private readonly IInventoryService _inventoryService;
        public OrderManager(IPriceCalculator priceCalculator, IInventoryService inventoryService) 
        { 
            _priceCalculator = priceCalculator ?? throw new ArgumentNullException(nameof(priceCalculator)); 
            _inventoryService = inventoryService ?? throw new ArgumentNullException(nameof(inventoryService)); 
        }
        public void ProcessOrder(string productId, int quantity, decimal unitPrice)
        {    
            // Verifica disponibilità
             if (_inventoryService.CheckAvailability(productId, quantity))            
             {               
                 // Calcola il prezzo
                 decimal totalPrice = _priceCalculator.CalculatePrice(quantity, unitPrice);
                 Console.WriteLine($"Ordine per '{productId}': {quantity} unità a {unitPrice:C} ciascuna. Totale: {totalPrice:C}");
             }           
             else 
             {
                Console.WriteLine($"Errore: '{productId}' non disponibile in quantità {quantity}"); 
             } 
        } 
    }

}
