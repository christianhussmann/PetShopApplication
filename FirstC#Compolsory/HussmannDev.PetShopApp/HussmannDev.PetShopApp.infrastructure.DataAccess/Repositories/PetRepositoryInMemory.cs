using System;
using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;
using HussmannDev.PetShopApp.Domain.IRepositories;

namespace HussmannDev.PetShopApp.infrastructure.DataAccess.Repositories
{
    public class PetRepositoryInMemory : IPetRepository
    {
        private static List<Pet> _petTable = new List<Pet>();
        private static int _id = 1;

        public PetRepositoryInMemory()
        {
            var pet1 = new Pet()
            {
                Name = "Joe",
                Type = "Cocker Spaniel",
                Color = "Blue",
                Price = 20000,
                BirthDate = DateTime.Now,
                SoldDate = DateTime.Now
            };
            CreatePet(pet1);
            
            var pet2 = new Pet()
            {
                Name = "Bill",
                Type = "Cocker Spaniel",
                Color = "Brown",
                Price = 30000,
                BirthDate = DateTime.Now,
                SoldDate = DateTime.Now
            };
            CreatePet(pet2);
            
            
            var pet3 = new Pet()
            {
                Name = "Jonas",
                Type = "Pitbull",
                Color = "Grey",
                Price = 20000,
                BirthDate = DateTime.Now,
                SoldDate = DateTime.Now
            };
            CreatePet(pet3);
            
            
            var pet4 = new Pet()
            {
                Name = "Billy Joe",
                Type = "God Damn Queen",
                Color = "Blue",
                Price = 40000,
                BirthDate = DateTime.Now,
                SoldDate = DateTime.Now
            };
            CreatePet(pet4);
            
            
            var pet5 = new Pet()
            {
                Name = "Mercy",
                Type = "God Damn Queen",
                Color = "Grey",
                Price = 20000,
                BirthDate = DateTime.Now,
                SoldDate = DateTime.Now
            };
            CreatePet(pet5);
            
            
            var pet6 = new Pet()
            {
                Name = "Josh",
                Type = "Cocker Spaniel",
                Color = "Blue",
                Price = 1110000,
                BirthDate = DateTime.Now,
                SoldDate = DateTime.Now
            };
            CreatePet(pet6);
            
        }

        Pet IPetRepository.CreatePet(Pet pet)
        {
            return CreatePet(pet);
        }

        Pet IPetRepository.ReadPetById(int id)
        {
            return ReadPetById(id);
        }
        
        
        public Pet GetPet(Pet pet)
        {
            throw new System.NotImplementedException();
        }

        public Pet CreatePet(Pet pet)
        {
            pet.Id = _id++;
            _petTable.Add(pet);
            return pet;
        }

        public List<Pet> ReadAllPets()
        {
            return _petTable;
        }

        public Pet ReadPetById(int id)
        {
            foreach (var pet in _petTable)
            {
                if (pet.Id == id)
                {
                    return pet;
                }
            }

            return null;
        }

        public Pet RemovePet(int id)
        {
            var petFound = this.ReadPetById(id);
            if (petFound != null)
            {
                _petTable.Remove(petFound);
                return petFound;
            }

            return null;
        }

        public Pet UpdatePet(Pet petUpdate)
        {
            var petFromDB = this.ReadPetById(petUpdate.Id);
            if (petFromDB != null)
            {
                petFromDB.Name = petUpdate.Name;
                petFromDB.Type = petUpdate.Type;
                petFromDB.Color = petUpdate.Color;
                petFromDB.Price = petUpdate.Price;
                petFromDB.BirthDate = petUpdate.BirthDate;
                petFromDB.SoldDate = petUpdate.SoldDate;
                return petFromDB;
            }

            return null;
        }

        public bool GetPet(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}