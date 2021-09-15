using HussmannDev.PetShopApp.Core.Models;

namespace HussmannDev.PetShopApp.Domain.IRepositories
{
    public interface IInsuranceRepository
    {
        Insurance GetById(int id);
    }
}