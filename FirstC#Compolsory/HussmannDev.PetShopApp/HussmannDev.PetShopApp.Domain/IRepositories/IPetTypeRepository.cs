using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;

namespace HussmannDev.PetShopApp.Domain.IRepositories
{
    public interface IPetTypeRepository
    {
        PetTypes GetPetType(string name);

        bool CreatePetType(PetTypes petTypes);

        bool RemovePetType(PetTypes petTypes);

        PetTypes UpdatePetType(PetTypes petTypes);
        
        IEnumerable<PetTypes> ReadAllPetTypes();
    }
}