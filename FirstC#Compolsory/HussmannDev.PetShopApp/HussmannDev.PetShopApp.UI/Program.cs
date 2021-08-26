using HussmannDev.PetShopApp.Core.IServices;
using HussmannDev.PetShopApp.Domain.IRepositories;
using HussmannDev.PetShopApp.Domain.Services;
using HussmannDev.PetShopApp.infrastructure.DataAccess.Repositories;


namespace HussmannDev.PetShopApp.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPetRepository repo = new PetRepositoryInMemory();
            IPetService service = new PetService(repo);
            var menu = new Menu(service);
            menu.Start();
        }
    }
}