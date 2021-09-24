using System.Collections.Generic;
using HussmannDev.PetShopApp.Core.Models;

namespace HussmannDev.PetShopApp.Core.IServices
{
    public interface IPetTypeService
    {
        List<PetTypes> GetAllPetTypes();

        PetTypes GetPetType(int id);
    }
}