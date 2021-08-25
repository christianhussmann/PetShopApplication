using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;

namespace HussmannDev.PetShopApp.Domain.IRepositories
{
    public interface IPetRepository
    {
        Pet GetPet(Pet pet);
        bool CreatePet(Pet pet);
        IEnumerable<Pet> ReadAllPets();
        int ReadPetById(int id);
        int RemovePet(int id);
        Pet UpdatePet(Pet pet);

    }
}