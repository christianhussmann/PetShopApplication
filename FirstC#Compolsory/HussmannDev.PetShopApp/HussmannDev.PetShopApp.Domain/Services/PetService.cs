using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.IServices;
using HussmannDev.PetShopApp.Core.Models;
using HussmannDev.PetShopApp.Domain.IRepositories;

namespace HussmannDev.PetShopApp.Domain.Services
{
    public class PetService : IPetService
    {
        private IPetRepository _repo;

        public PetService(IPetRepository repo)
        {
            _repo = repo;
        }


        public Pet GetPet(Pet pet)
        {
            throw new System.NotImplementedException();
        }

        public bool CreatePet(Pet pet)
        {
            return _repo.CreatePet(pet);
        }

        public int RemovePet(int id)
        {
            return _repo.RemovePet(id);
        }

        public Pet UpdatePet(Pet pet)
        {
            return _repo.UpdatePet(pet);
        }

        public int ReadPetById(int id)
        {
            return _repo.ReadPetById(id);
        }

        public IEnumerable<Pet> ReadAllPets()
        {
            return _repo.ReadAllPets();
        }
    }
}