using System.Collections.Generic;
using System.Linq;
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

            CreateOwner(new Owner()
            {
                Name = "Joe",
                Age = 21
            });
            CreateOwner(new Owner()
            {
                Name = "Christian",
                Age = 24
            });
        }
        public Owner CreateOwner(Owner owner)
        {
            var ownerEntity = _ownerConverter.Convert(owner);
            ownerEntity.Id = _id++;
            _ownersTable.Add(ownerEntity);
            return _ownerConverter.Convert(ownerEntity);
        }

        public Owner ReadOwnerById(int id)
        {
            foreach (var ownerEntity in _ownersTable)
            {
                if (ownerEntity.Id == id)
                {
                    return _ownerConverter.Convert(ownerEntity);
                }
            }

            return null;
        }

        public Owner UpdateOwner(Owner owner)
        {
            var ownerOld = _ownersTable.FirstOrDefault(o => o.Id == owner.Id);
            if (ownerOld != null)
            {
                ownerOld.Name = owner.Name;
                ownerOld.Age = owner.Age;
            }

            return null;
        }

        public Owner RemoveOwner(int id)
        {
            var owner = ReadOwnerById(id);
            _ownersTable.Remove(_ownersTable.FirstOrDefault(p => p.Id == id));
            return owner;
        }

        public List<Owner> ReadAllOwners()
        {
            var listOfOwners = new List<Owner>();
            foreach (var owner in _ownersTable)
            {
                listOfOwners.Add(_ownerConverter.Convert(owner));
            }

            return listOfOwners;
        }
    }
}