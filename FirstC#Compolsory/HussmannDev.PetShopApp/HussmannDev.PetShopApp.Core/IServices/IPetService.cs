using System.Collections;
using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;

namespace HussmannDev.PetShopApp.Core.IServices
{
    public interface IPetService
    {
        Pet GetPet(Pet pet);
        Pet CreatePet(Pet pet);

        Pet RemovePet(int id);

        Pet UpdatePet(Pet pet);

        Pet ReadPetById(int id);
        
        
        List<Pet> ReadAllPets();
    }
}