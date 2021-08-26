using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;

namespace HussmannDev.PetShopApp.Core.IServices
{
    public interface IPetTypeService
    {
        PetTypes GetPetType(string name);

        PetTypes CreatePetType(PetTypes petTypes);

        PetTypes RemovePetType(int typeId);

        PetTypes UpdatePetType(PetTypes petTypes);
        
        
        List<PetTypes> ReadAllPetTypes();
    }
}