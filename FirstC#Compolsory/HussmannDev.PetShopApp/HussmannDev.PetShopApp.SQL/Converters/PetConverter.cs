using HussmannDev.PetShopApp.Core.Models;
using HussmannDev.PetShopApp.Domain.IRepositories;
using HussmannDev.PetShopApp.SQL.Entities;
using HussmannDev.PetShopApp.SQL.Repositories;

namespace HussmannDev.PetShopApp.SQL.Converters
{
    public class PetConverter
    {
        private IPetTypeRepository _petTypeRepo = new PetTypeRepository();
        private IOwnerRepository _petOwnerRepo = new OwnerRepository();
        public PetEntity Convert(Pet pet)
        {
            return new PetEntity()
            {
                Id = pet.Id,
                Name = pet.Name,
                TypeId = pet.Type.Id,
                Color = pet.Color,
                Price = pet.Price,
                BirthDate = pet.BirthDate,
                SoldDate = pet.SoldDate
            };
        }

        public Pet Convert(PetEntity petEntity)
        {
            return new Pet()
            {
                Id = petEntity.Id,
                BirthDate = petEntity.BirthDate,
                Color = petEntity.Color,
                Name = petEntity.Name,
                Price = petEntity.Price,
                SoldDate = petEntity.SoldDate,
                Type = _petTypeRepo.GetPetType(petEntity.TypeId),
            };
        }
    }
}