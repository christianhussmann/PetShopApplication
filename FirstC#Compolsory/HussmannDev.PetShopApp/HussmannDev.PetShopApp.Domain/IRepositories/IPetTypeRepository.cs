using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;

namespace HussmannDev.PetShopApp.Domain.IRepositories
{
    public interface IPetTypeRepository
    {
        List<PetTypes> GetAllPetTypes();

        PetTypes GetPetType(int id);
    }
}