using System;
using System.Collections.Generic;
using System.Linq;
using HussmannDev.PetShopApp.Core.Models;
using HussmannDev.PetShopApp.Domain.IRepositories;
using HussmannDev.PetShopApp.SQL.Converters;
using HussmannDev.PetShopApp.SQL.Entities;

namespace HussmannDev.PetShopApp.SQL.Repositories
{
    public class PetRepository : IPetRepository
    {
        private static List<PetEntity> _petsTable = new List<PetEntity>();
        private List<PetTypes> _petTypes = new PetTypeRepository().GetAll();
        private static int _id = 1;
        private readonly PetConverter _petConverter;

        public PetRepository()
        {
            _petConverter = new PetConverter();
            
            CreatePet(new Pet()
            {
                Name = "Joe",
                Type = _petTypes[1],
                Color = "Blue",
                Price = 20000,
                BirthDate = DateTime.Now,
                SoldDate = DateTime.Now
            });
            CreatePet(new Pet()
            
            {
                Name = "Bill",
                Type = _petTypes[1],
                Color = "Brown",
                Price = 30000,
                BirthDate = DateTime.Now,
                SoldDate = DateTime.Now
            });
            CreatePet(new Pet()

            
            {
                Name = "Jonas",
                Type = _petTypes[2],
                Color = "Grey",
                Price = 20000,
                BirthDate = DateTime.Now,
                SoldDate = DateTime.Now
            });
            CreatePet(new Pet()
            
            {
                Name = "Billy Joe",
                Type = _petTypes[3],
                Color = "Blue",
                Price = 40000,
                BirthDate = DateTime.Now,
                SoldDate = DateTime.Now
            });
            CreatePet(new Pet()
            {
                Name = "Mercy",
                Type = _petTypes[4],
                Color = "Grey",
                Price = 20000,
                BirthDate = DateTime.Now,
                SoldDate = DateTime.Now
            });
            CreatePet(new Pet()
            
            {
                Name = "Josh",
                Type = _petTypes[4],
                Color = "Blue",
                Price = 1110000,
                BirthDate = DateTime.Now,
                SoldDate = DateTime.Now
            });
        }

        public Pet CreatePet(Pet pet)
        {
            var petEntity = _petConverter.Convert(pet);
            petEntity.Id = _id++;
            _petsTable.Add(petEntity);
            return _petConverter.Convert(petEntity);
        }

        public List<Pet> ReadAllPets()
        {
            var listOfPets = new List<Pet>();
            foreach (var pet in _petsTable)
            {
                listOfPets.Add(_petConverter.Convert(pet));
            }

            return listOfPets;
        }

        public Pet ReadPetById(int id)
        {
            foreach (var petEntity in _petsTable)
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
            var pet = ReadPetById(id);
            _petsTable.Remove(_petsTable.FirstOrDefault(p => p.Id == id));
            return pet;
        }

        public Pet UpdatePet(Pet pet)
        {
            var petOld = _petsTable.FirstOrDefault(p => p.Id == pet.Id);
            if (petOld != null)
            {
                petOld.Name = pet.Name;
                petOld.Color = pet.Color;
                petOld.Price = pet.Price;
                petOld.BirthDate = pet.BirthDate;
                petOld.SoldDate = pet.SoldDate;
                petOld.TypeId = pet.Type.Id;
            }


            return null;
        }

        public List<PetTypes> GetPetTypes()
        {
            return _petTypes;
        }

    }
}
