using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;

namespace HussmannDev.PetShopApp.Domain.IRepositories
{
    public interface IPetRepository
    {
        Pet GetPet(Pet pet);
        //Create Pet
        Pet CreatePet(Pet pet);
        List<Pet> ReadAllPets();
        //Read Pet
        Pet ReadPetById(int id);
        //Delete Pet
        Pet RemovePet(int id);
        //Edit Pet
        Pet UpdatePet(Pet pet);

    }
}