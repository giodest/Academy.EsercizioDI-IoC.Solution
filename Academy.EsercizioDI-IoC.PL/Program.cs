using Microsoft.Extensions.DependencyInjection;
using System.Security.Authentication.ExtendedProtection;

namespace Academy.EsercizioDI_IoC.PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IInventoryService, InventoryService>();
            serviceCollection.AddSingleton<IStockChecker, SimpleStockChecker>();
            serviceCollection.AddSingleton<IPriceCalculator, StandardPriceCalculator>();

            serviceCollection.AddSingleton<OrderManager>();
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var service = serviceProvider.GetService<OrderManager>();
            service.ProcessOrder("P1", 1, 10);
            service.ProcessOrder("P2", 11, 10);

        }
    }
}
