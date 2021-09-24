using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;
using HussmannDev.PetShopApp.Domain.IRepositories;

namespace HussmannDev.PetShopApp.SQL.Repositories
{
    public class PetTypeRepository : IPetTypeRepository
    {
        private static List<PetTypes> _petsTypeTable;
        
        public PetTypeRepository()
        {
           _petsTypeTable = new List<PetTypes>();
           
           _petsTypeTable.Add(new PetTypes()
           {
               Id = 1,
               Name = "Dog",
           });
           _petsTypeTable.Add(new PetTypes()
           {
               Id = 2,
               Name = "Cat"
           });
           _petsTypeTable.Add(new PetTypes()
           {
               Id = 3,
               Name = "Fish",
           });
           _petsTypeTable.Add(new PetTypes()
           {
               Id = 4,
               Name = "Monkey",
           });
           _petsTypeTable.Add(new PetTypes()
           {
               Id = 5,
               Name = "Goat",
           });
           _petsTypeTable.Add(new PetTypes()
           {
               Id = 6,
               Name = "Horse",
           });
           _petsTypeTable.Add(new PetTypes()
           {
               Id = 7,
               Name = "Pig",
           });
           _petsTypeTable.Add(new PetTypes()
           {
               Id = 8,
               Name = "Chicken",
           });
           _petsTypeTable.Add(new PetTypes()
           {
               Id = 9,
               Name = "Hamster",
           });
           _petsTypeTable.Add(new PetTypes()
           {
               Id = 10,
               Name = "Snake",
           });
           _petsTypeTable.Add(new PetTypes()
           {
               Id = 11,
               Name = "Rat",
           });
        }
        
        public PetTypes ReadById(int petEntityTypeId)
        {
            foreach(var petType in _petsTypeTable)
            {
                if (petType.Id == petEntityTypeId)
                {
                    return petType;
                }
            }
            return null;
        }

        public List<PetTypes> ReadAllPetTypes()
        {
            return _petsTypeTable;
        }

        public List<PetTypes> GetAllPetTypes()
        {
            throw new System.NotImplementedException();
        }

        public PetTypes GetPetType(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}