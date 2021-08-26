using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.IServices;
using HussmannDev.PetShopApp.Core.Models;
using HussmannDev.PetShopApp.Domain.IRepositories;

namespace HussmannDev.PetShopApp.Domain.Services
{
    public class PetTypeService : IPetTypeService
    {
        private IPetTypeRepository _repo2;

        public PetTypeService(IPetTypeRepository repo2)
        {
            _repo2 = repo2;
        }
        public PetTypes GetPetType(string name)
        {
            throw new System.NotImplementedException();
        }

        public PetTypes CreatePetType(PetTypes petTypes)
        {
            return _repo2.CreatePetType(petTypes);
        }

        public PetTypes RemovePetType(int petTypes)
        {
            return _repo2.RemovePetType(petTypes);
        }

        public PetTypes UpdatePetType(PetTypes petTypes)
        {
            return _repo2.UpdatePetType(petTypes);
        }
        

        public List<PetTypes> ReadAllPetTypes()
        {
            return _repo2.ReadAllPetTypes();
        }
    }
}