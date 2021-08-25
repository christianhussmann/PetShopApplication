using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.IServices;
using HussmannDev.PetShopApp.Core.Models;

namespace HussmannDev.PetShopApp.Domain.Services
{
    public class PetTypeService : IPetTypeService
    {
        public PetTypes GetPetType(string name)
        {
            throw new System.NotImplementedException();
        }

        public bool CreatePetType(PetTypes pet)
        {
            throw new System.NotImplementedException();
        }

        public bool RemovePetType(PetTypes pet)
        {
            throw new System.NotImplementedException();
        }

        public Pet UpdatePetType(PetTypes oldPetType, PetTypes NewPetType)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<PetTypes> ReadAllPetTypes()
        {
            throw new System.NotImplementedException();
        }
    }
}