using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.IServices;
using HussmannDev.PetShopApp.Core.Models;
using HussmannDev.PetShopApp.Domain.IRepositories;

namespace HussmannDev.PetShopApp.Domain.Services
{
    public class PetService : IPetService
    {
        private IPetRepository _petRepository;

        public PetService(IPetRepository petRepository)
        {
            _petRepository= petRepository;
        }

        public Pet CreatePet(Pet pet)
        {
            return _petRepository.CreatePet(pet);
        }

        public Pet RemovePet(int id)
        {
            return _petRepository.RemovePet(id);
        }

        public Pet UpdatePet(Pet pet)
        {
            return _petRepository.UpdatePet(pet);
        }

        public Pet ReadPetById(int id)
        {
            return _petRepository.ReadPetById(id);
        }

        public List<Pet> ReadAllPets()
        {
            return _petRepository.ReadAllPets();
        }

        public List<Pet> GetPetsByType(PetTypes petTypes)
        {
            throw new System.NotImplementedException();
        }

        public List<Pet> SortPetsByPrice(List<Pet> sortList)
        {
            throw new System.NotImplementedException();
        }
    }
}