using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;

namespace HussmannDev.PetShopApp.Core.IServices
{
    public interface IInsuranceService
    {
        Insurance GetById(int id);
        Insurance CreateInsurance(Insurance insurance);
        List<Insurance> ReadAll();
        Insurance RemoveInsurance(int id);

        Insurance UpdateInsurance(Insurance insurance);
    }
}