using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;

namespace HussmannDev.PetShopApp.Domain.IRepositories
{
    public interface IPetTypeRepository
    {
        PetTypes ReadById(int petEntityTypeId);

        List<PetTypes> ReadAllPetTypes();
    }
}