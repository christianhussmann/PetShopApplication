using System.Linq;
using HussmannDev.PetShopApp.Core.Models;
using HussmannDev.PetShopApp.Domain.IRepositories;

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
    }
}