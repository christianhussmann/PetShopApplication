using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;

namespace HussmannDev.PetShopApp.Core.IServices
{
    public interface IPetTypeService
    {
        PetTypes GetPetType(string name);

        bool CreatePetType(PetTypes pet);

        bool RemovePetType(PetTypes pet);

        PetTypes UpdatePetType(PetTypes petTypes);
        
        
        IEnumerable<PetTypes> ReadAllPetTypes();
    }
}