using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;

namespace HussmannDev.PetShopApp.Domain.IRepositories
{
    public interface IInsuranceRepository
    {
        Insurance GetById(int id);
        Insurance CreateInsurance(Insurance insurance);
        List<Insurance> ReadAll();
        Insurance RemoveInsurance(int id);
        Insurance UpdateInsurance(Insurance insurance);
    }
}