using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;

namespace HussmannDev.PetShopApp.Domain.IRepositories
{
    public interface IPetTypeRepository
    {
        PetTypes GetPetType(string name);

        bool CreatePetType(PetTypes pet);

        bool RemovePetType(PetTypes pet);

        Pet UpdatePetType(PetTypes oldPetType, PetTypes NewPetType);
        
        
        IEnumerable<PetTypes> ReadAllPetTypes();
    }
}