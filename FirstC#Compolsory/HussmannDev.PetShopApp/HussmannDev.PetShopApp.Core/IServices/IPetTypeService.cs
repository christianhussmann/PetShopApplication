using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;

namespace HussmannDev.PetShopApp.Core.IServices
{
    public interface IPetTypeService
    {
        PetTypes CreatePetType(PetTypes pet);

        PetTypes RemovePetType(int id);
        
        PetTypes ReadById(int id);

        PetTypes UpdatePetType(PetTypes pet);
        
        List<Pet> ReadAllPetTypes();
    }
}