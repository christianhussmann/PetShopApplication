using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.IServices;
using HussmannDev.PetShopApp.Core.Models;
using HussmannDev.PetShopApp.Domain.IRepositories;

namespace HussmannDev.PetShopApp.Domain.Services
{
    public class PetTypeService : IPetTypeService
    {
        private IPetTypeRepository _petTypeRepository;

        public PetTypeService(IPetTypeRepository repository)
        {
            _petTypeRepository = repository;
        }
        public List<PetTypes> GetAllPetTypes()
        {
            return _petTypeRepository.GetAllPetTypes();
        }

        public PetTypes GetPetType(int id)
        {
            return _petTypeRepository.GetPetType(id);
        }
    }
}