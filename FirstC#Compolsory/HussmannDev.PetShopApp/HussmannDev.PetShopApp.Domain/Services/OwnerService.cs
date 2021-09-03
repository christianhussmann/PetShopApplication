using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.IServices;
using HussmannDev.PetShopApp.Core.Models;
using HussmannDev.PetShopApp.Domain.IRepositories;

namespace HussmannDev.PetShopApp.Domain.Services
{
    public class OwnerService : IOwnerService
    {
        private IOwnerRepository _ownerRepository;

        public OwnerService(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }
        
        public Owner CreateOwner(Owner owner)
        {
            return _ownerRepository.CreateOwner(owner);
        }

        public Owner RemoveOwner(int id)
        {
            return _ownerRepository.RemoveOwner(id);
        }

        public Owner ReadOwnerById(int id)
        {
            return _ownerRepository.ReadOwnerById(id);
        }

        public Owner UpdateOwner(Owner owner)
        {
            return _ownerRepository.UpdateOwner(owner);
        }

        public List<Owner> ReadAllOwners()
        {
            return _ownerRepository.ReadAllOwners();
        }
    }
}