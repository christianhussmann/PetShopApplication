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
    public class InsuranceController : ControllerBase
    {
        private readonly IInsuranceService _insuranceService;

        public InsuranceController(IInsuranceService insuranceService)
        {
            _insuranceService = insuranceService;
        }
        
        
        [HttpGet("{id}")]
        public ActionResult<Insurance> GetById(int id)
        {
            try
            {
                return _insuranceService.GetById(id);
            }
            catch (Exception e)
            {
                return StatusCode(500, "call 911");
            }
        }
    }
}