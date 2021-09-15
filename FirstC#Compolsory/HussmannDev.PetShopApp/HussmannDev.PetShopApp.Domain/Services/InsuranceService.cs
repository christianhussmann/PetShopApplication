using HussmannDev.PetShopApp.Core.IServices;
using HussmannDev.PetShopApp.Core.Models;
using HussmannDev.PetShopApp.Domain.IRepositories;

namespace HussmannDev.PetShopApp.Domain.Services
{
    public class InsuranceService : IInsuranceService
    {
            private readonly IInsuranceRepository _insuranceRepository;
            public InsuranceService(IInsuranceRepository insuranceRepository)
            {
                _insuranceRepository = insuranceRepository;
            }
            public Insurance GetById(int id)
            {
                return _insuranceRepository.GetById(id);
            }
        }
    }
