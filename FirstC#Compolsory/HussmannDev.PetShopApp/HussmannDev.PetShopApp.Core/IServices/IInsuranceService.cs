using HussmannDev.PetShopApp.Core.Models;

namespace HussmannDev.PetShopApp.Core.IServices
{
    public interface IInsuranceService
    {
        Insurance GetById(int id);
        Insurance CreateInsurance(Insurance insurance);
    }
}