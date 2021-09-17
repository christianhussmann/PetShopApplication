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

        [HttpPost]
            public ActionResult<Insurance> Create([FromBody]Insurance insurance)
            {
                try
                {
                    return _insuranceService.CreateInsurance(insurance);
                }
                catch (Exception e)
                {
                    return StatusCode(500, "FUCK CALL MY MOM!");
                }
            }
            
        [HttpGet]
        public ActionResult<List<Insurance>> ReadAll()
        {
            try
            {
                return Ok(_insuranceService.ReadAll());
            }
            catch (Exception e)
            {
                return StatusCode(500, "Shit.....Dont ask why it doesn't work....");
            }
            
        }
        [HttpDelete("{id}")]
        public ActionResult<Insurance> Delete(int id)
        {
            try
            {
                return Ok(_insuranceService.RemoveInsurance(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, "Reeeeeeeee");
            }
            
        }
        
        [HttpPut("{id}")]
        public ActionResult<Insurance> Update(int id, [FromBody] Insurance insurance)
        {
            try
            {
                if (id != insurance.Id)
                {
                    return BadRequest("Id in insurance must match param id");
                }
                return Ok(_insuranceService.UpdateInsurance(insurance));
            }
            catch (Exception e)
            {
                return StatusCode(500, "Fuck this shit im ouuut");
            }
            
        }
        
        
        }
    }
