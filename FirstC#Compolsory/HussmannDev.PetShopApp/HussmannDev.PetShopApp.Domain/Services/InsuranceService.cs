using System.Collections.Generic;
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

            public Insurance CreateInsurance(Insurance insurance)
            {
                return _insuranceRepository.CreateInsurance(insurance);
            }

            public List<Insurance> ReadAll()
            {
                return _insuranceRepository.ReadAll();
            }

            public Insurance RemoveInsurance(int id)
            {
                return _insuranceRepository.RemoveInsurance(id);
            }

            public Insurance UpdateInsurance(Insurance insurance)
            {
                return _insuranceRepository.UpdateInsurance(insurance);
            }
    }
    }
