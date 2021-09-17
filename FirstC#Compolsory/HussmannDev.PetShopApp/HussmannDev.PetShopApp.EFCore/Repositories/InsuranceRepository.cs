using System.Collections.Generic;
using System.Linq;
using HussmannDev.PetShopApp.Core.Models;
using HussmannDev.PetShopApp.Domain.IRepositories;
using HussmannDev.PetShopApp.EFCore.Entities;

namespace HussmannDev.PetShopApp.EFCore.Repositories
{
    public class InsuranceRepository : IInsuranceRepository
    {
        private readonly PetApplicationDbContext _ctx;
        public InsuranceRepository(PetApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public Insurance GetById(int id)
        {
            return _ctx.Insurances
                .Select(insuranceEntity => new Insurance
                {
                    Id = insuranceEntity.Id,
                    Name = insuranceEntity.Name,
                    Price = insuranceEntity.Price
                } )
                .FirstOrDefault(insurance => insurance.Id == id);
            
        }

        public Insurance CreateInsurance(Insurance insurance)
        {
            var entity = _ctx.Add(new InsuranceEntity
            {
                Name = insurance.Name,
                Price = insurance.Price
            }).Entity;
            _ctx.SaveChanges();
            return new Insurance
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price
            };
        }

        public List<Insurance> ReadAll()
        {
            return _ctx.Insurances
                .Select(insurance => new Insurance
                {
                    Id = insurance.Id,
                    Name = insurance.Name,
                    Price = insurance.Price
                    
                })
                .ToList();
        }

        
        public Insurance RemoveInsurance(int id)
        {
            var entity = _ctx.Remove(new InsuranceEntity{Id = id}).Entity;
            _ctx.SaveChanges();
            return new Insurance
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price
            };
        }

        public Insurance UpdateInsurance(Insurance insurance)
        {
            var insuranceEntity = new InsuranceEntity
            {
                Id = insurance.Id,
                Name = insurance.Name,
                Price = insurance.Price
            };
            var entity = _ctx.Update(insuranceEntity).Entity;
            _ctx.SaveChanges();
            return new Insurance
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price
            };
        }
    }
}