using HussmannDev.PetShopApp.Core.Models;
using HussmannDev.PetShopApp.SQL.Entities;

namespace HussmannDev.PetShopApp.SQL.Converters
{
    public class OwnerConverter
    {
        public OwnerEntity Convert(Owner owner)
        {
            return new OwnerEntity()
            {
                Id = owner.Id,
                Name = owner.Name,
                Age = owner.Age
            };
        }

        public Owner Convert(OwnerEntity ownerEntity)
        {
            return new Owner()
            {
                Id = ownerEntity.Id,
                Name = ownerEntity.Name,
                Age = ownerEntity.Age
            };
        }
    }
}