using System.Collections.Generic;
using System.Linq;
using HussmannDev.PetShopApp.Core.Models;
using HussmannDev.PetShopApp.Domain.IRepositories;
using HussmannDev.PetShopApp.EFCore.Entities;

namespace HussmannDev.PetShopApp.EFCore.Repositories
{
    public class PetRepository : IPetRepository
    {
        private readonly PetApplicationDbContext _ctx;

        public PetRepository(PetApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public Pet CreatePet(Pet pet)
        {
            var entity = _ctx.Add(new PetEntity
            {
                Name = pet.Name,
                Price = pet.Price,
                BirthDate = pet.BirthDate,
                SoldDate = pet.SoldDate,
            }).Entity;
            _ctx.SaveChanges();
            return new Pet
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price,
                BirthDate = entity.BirthDate,
                SoldDate = entity.SoldDate,
            };
        }

        public Pet ReadPetById(int id)
        {
            return _ctx.Pets
                .Select(petEntity => new Pet
                {
                    Id = petEntity.Id,
                    Name = petEntity.Name,
                    Price = petEntity.Price,
                    BirthDate = petEntity.BirthDate,
                    SoldDate = petEntity.SoldDate,
                })
                .FirstOrDefault(pet => pet.Id == id);
        }

        public Pet UpdatePet(Pet pet)
        {
            var petEntity = new PetEntity
            {
                Id = pet.Id,
                Name = pet.Name,
                Price = pet.Price,
                BirthDate = pet.BirthDate,
                SoldDate = pet.SoldDate,
            };
            var entity = _ctx.Update(petEntity).Entity;
            _ctx.SaveChanges();
            return new Pet
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price,
                BirthDate = entity.BirthDate,
                SoldDate = entity.SoldDate,
            };
        }
    


        public Pet RemovePet(int id)
        {
            var entity = _ctx.Remove(new PetEntity{Id = id}).Entity;
            _ctx.SaveChanges();
            return new Pet
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price
            };
        }

        public List<Pet> ReadAllPets()
        {
            return _ctx.Pets
                .Select(pet => new Pet
                {
                    Name = pet.Name,
                    Price = pet.Price,
                    BirthDate = pet.BirthDate,
                    SoldDate = pet.SoldDate,
                    Color = pet.Color
                })
                .ToList();
        }
    }
}