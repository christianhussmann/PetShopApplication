using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;
using HussmannDev.PetShopApp.Domain.IRepositories;
using HussmannDev.PetShopApp.SQL.Converters;
using HussmannDev.PetShopApp.SQL.Entities;

namespace HussmannDev.PetShopApp.SQL.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        private static List<OwnerEntity> _ownersTable = new List<OwnerEntity>();
        private static int _id = 1;
        private readonly OwnerConverter _ownerConverter;

        public OwnerRepository()
        {
            _ownerConverter = new OwnerConverter();
        }
        public Owner CreateOwner(Owner owner)
        {
            throw new System.NotImplementedException();
        }

        public Owner ReadOwnerById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Owner UpdateOwner(Owner owner)
        {
            throw new System.NotImplementedException();
        }

        public Owner RemoveOwner(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Owner> ReadAllOwners()
        {
            throw new System.NotImplementedException();
        }
    }
}