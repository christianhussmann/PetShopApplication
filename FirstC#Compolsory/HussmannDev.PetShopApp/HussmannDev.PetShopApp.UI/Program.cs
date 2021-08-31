using Microsoft.Extensions.DependencyInjection;
using HussmannDev.PetShopApp.Core.IServices;
using HussmannDev.PetShopApp.Domain.IRepositories;
using HussmannDev.PetShopApp.Domain.Services;
using HussmannDev.PetShopApp.SQL.Repositories;


namespace HussmannDev.PetShopApp.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddScoped<IPetRepository, PetRepository>();
        serviceCollection.AddScoped<IPetTypeRepository, PetTypeRepository>();
        serviceCollection.AddScoped<IPetService, PetService>();
        serviceCollection.AddScoped<IPetTypeService, PetTypeService>();

        var serviceProvider = serviceCollection.BuildServiceProvider();
            
        IPetRepository petRepository = new PetRepository();
        IPetTypeRepository petTypeRepository = new PetTypeRepository();
        IPetService petService = new PetService(petRepository);
            
        var menu = new Menu(petService, petTypeRepository);
        menu.Start();
        }
    }

    
}