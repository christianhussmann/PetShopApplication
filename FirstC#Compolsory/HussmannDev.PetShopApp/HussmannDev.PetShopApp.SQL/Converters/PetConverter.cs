using HussmannDev.PetShopApp.Core.Models;
using HussmannDev.PetShopApp.SQL.Entities;

namespace HussmannDev.PetShopApp.SQL.Converters
{
    public class PetConverter
    {
        public Pet Convert(PetEntity entity)
        {
            return new Pet
            {
                Id = entity.Id,
                Name = entity.Name,
                Type = entity.Type,
                Color = entity.Color,
                Price = entity.Price,
                BirthDate = entity.BirthDate,
                SoldDate = entity.SoldDate
            };
        }

        public PetEntity Convert(Pet pet)
        {
            return new PetEntity
            {
                Id = pet.Id,
                Name = pet.Name,
                Type = pet.Type,
                Color = pet.Color,
                Price = pet.Price,
                BirthDate = pet.BirthDate,
                SoldDate = pet.SoldDate
            };
        }
    }
}