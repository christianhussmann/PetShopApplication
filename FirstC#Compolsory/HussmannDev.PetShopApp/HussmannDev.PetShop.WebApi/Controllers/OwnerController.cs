using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HussmannDev.PetShopApp.Core.IServices;
using HussmannDev.PetShopApp.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HussmannDev.PetShop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService _ownerService;

        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }

        [HttpPost]
        public Owner Create(Owner owner)
        {
            return _ownerService.CreateOwner(owner);
        }

        [HttpGet]
        public List<Owner> GetAll()
        {
            return _ownerService.ReadAllOwners();
        }

        [HttpDelete("{id}")]
        public Owner Delete(int id)
        {
            return _ownerService.RemoveOwner(id);
        }

        [HttpGet("{id}")]
        public Owner ReadById(int id)
        {
            return _ownerService.ReadOwnerById(id);
        }

        [HttpPut("{id}")]
        public Owner Edit(Owner owner)
        {
            return _ownerService.UpdateOwner(owner);
        }
    }
}