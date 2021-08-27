using System;
using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;
using HussmannDev.PetShopApp.Domain.IRepositories;
using HussmannDev.PetShopApp.SQL.Converters;
using HussmannDev.PetShopApp.SQL.Entities;

namespace HussmannDev.PetShopApp.SQL.Repositories
{
    public class PetRepository: IPetRepository
    {
        private static List<PetEntity> _petTable = new List<PetEntity>();
        private static int _id = 1;
        private readonly PetConverter _petConverter;

        public PetRepository()
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
            var petEntity = _petConverter.Convert(pet);
            petEntity.Id = _id++;
            _petTable.Add(petEntity);
            return _petConverter.Convert(petEntity);
        }

        public List<Pet> ReadAllPets()
        {
            var listOfPets = new List<Pet>();
            foreach (var petEntity in _petTable)
            {
                listOfPets.Add(_petConverter.Convert(petEntity));
            }

            return listOfPets;
        }

        public Pet ReadPetById(int id)
        {
            foreach (var petEntity in _petTable)
            {
                if (petEntity.Id == id)
                {
                    return _petConverter.Convert(petEntity);
                }
            }

            return null;
        }

        public Pet RemovePet(int id)
        {
            var PetFromDB = this.ReadPetById(id);
            if (PetFromDB != null)
            {
                _petTable.Remove(_petConverter.Convert(PetFromDB));
                return PetFromDB;
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
                var index = _petTable.FindIndex(p => p.Id == petUpdate.Id);
                _petTable[index] = _petConverter.Convert(petFromDB);
                return petFromDB;
            }

            return null;
        }
    }
}
