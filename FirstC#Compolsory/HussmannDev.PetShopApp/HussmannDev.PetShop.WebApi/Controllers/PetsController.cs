using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HussmannDev.PetShopApp.Core.IServices;
using HussmannDev.PetShopApp.Core.Models;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HussmannDev.PetShop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly IPetService _petService;

        public PetsController(IPetService petService)
        {
            _petService = petService;
        }
        
        [HttpPost]
        public Pet Create(Pet pet)
        {
            return _petService.CreatePet(pet);
        }
        
        [HttpGet]
        public List<Pet> GetAll()
        {
            return _petService.ReadAllPets();
        }

        [HttpDelete("{id}")]
        public Pet Delete(int id)
        {
            return _petService.RemovePet(id);
        }

        [HttpGet("{id}")]
        public Pet ReadById(int id)
        {
            return _petService.ReadPetById(id);
        }

        [HttpPut("{id}")]
        public Pet Edit(Pet pet)
        {
            return _petService.UpdatePet(pet);
        }
        
    }
}