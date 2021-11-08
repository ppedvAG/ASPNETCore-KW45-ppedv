using DependencyInversionSample;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInversionInASPNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //IServiceCollection wird verwenden um den IOC Container zu befüllen 
            IServiceCollection serviceCollection = new ServiceCollection();
            //Instanz(en) werden hinzugefügt


            serviceCollection.AddSingleton<ICar, MockCar>();
            serviceCollection.AddSingleton<ICar, Car>();

            //serviceCollection.AddScoped<ICar, MockCar>();
            //serviceCollection.AddTransient<ICar, MockCar>();
            ServiceProvider provider = serviceCollection.BuildServiceProvider(); //


            //ICar car = new MockCar()
            ICar car = provider.GetRequiredService<ICar>();

            Console.WriteLine(car.Id);
            Console.WriteLine(car.Brand);
            Console.WriteLine(car.Model);
        }
    }
}
