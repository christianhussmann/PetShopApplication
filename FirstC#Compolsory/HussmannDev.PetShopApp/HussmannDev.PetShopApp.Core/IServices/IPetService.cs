using System.Collections;
using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;

namespace HussmannDev.PetShopApp.Core.IServices
{
    public interface IPetService
    {
        Pet CreatePet(Pet pet);

        Pet RemovePet(int id);
        
        Pet ReadPetById(int id);

        Pet UpdatePet(Pet pet);
        
        List<Pet> ReadAllPets();
    }
}