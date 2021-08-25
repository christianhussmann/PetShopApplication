using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;

namespace HussmannDev.PetShopApp.Domain.IRepositories
{
    public interface IPetRepository
    {
        Pet GetPet(Pet pet);
        //Create Pet
        bool CreatePet(Pet pet);
        IEnumerable<Pet> ReadAllPets();
        //Read Pet
        int ReadPetById(int id);
        //Delete Pet
        int RemovePet(int id);
        //Edit Pet
        Pet UpdatePet(Pet pet);

    }
}