using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HussmannDev.PetShopApp.Core.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HussmannDev.PetShop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService _ownerService;
    }
}