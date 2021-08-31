using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;

namespace HussmannDev.PetShopApp.Domain.IRepositories
{
    public interface IPetRepository
    {
        Pet CreatePet(Pet pet);
        
        Pet ReadPetById(int id);
        
        Pet UpdatePet(Pet pet);
        
        Pet RemovePet(int id);
        
        List<Pet> ReadAllPets();
    }
}