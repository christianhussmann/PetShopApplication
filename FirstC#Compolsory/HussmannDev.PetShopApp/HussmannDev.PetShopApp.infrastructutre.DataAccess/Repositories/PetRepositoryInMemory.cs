using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;
using HussmannDev.PetShopApp.Domain.IRepositories;

namespace HussmannDev.PetShopApp.infrastructutre.DataAccess.Repositories
{
    public class PetRepositoryInMemory : IPetRepository
    {
        public Pet GetPet(Pet pet)
        {
            throw new System.NotImplementedException();
        }

        public bool CreatePet(Pet pet)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Pet> ReadAllPets()
        {
            throw new System.NotImplementedException();
        }

        public int ReadPetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public int RemovePet(int id)
        {
            throw new System.NotImplementedException();
        }

        public Pet UpdatePet(Pet pet)
        {
            throw new System.NotImplementedException();
        }

        public bool GetPet(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}