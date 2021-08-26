using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;

namespace HussmannDev.PetShopApp.Domain.IRepositories
{
    public interface IPetTypeRepository
    {
        PetTypes GetPetType(string name);

        PetTypes CreatePetType(PetTypes petTypes);

        PetTypes RemovePetType(int typeId);

        PetTypes UpdatePetType(PetTypes petTypes);
            
            
        List<PetTypes> ReadAllPetTypes();
    }
}