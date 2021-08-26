using System.Collections;
using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;

namespace HussmannDev.PetShopApp.Core.IServices
{
    public interface IPetService
    {
        Pet GetPet(Pet pet);
        void CreatePet(Pet pet);

        int RemovePet(int id);

        void UpdatePet(Pet pet);

        int ReadPetById(int id);
        
        
        IEnumerable<Pet> ReadAllPets();
    }
}