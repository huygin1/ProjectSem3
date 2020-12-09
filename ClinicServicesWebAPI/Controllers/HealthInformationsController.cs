using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.Models;
using ClinicServicesWebAPI.Services;

namespace ClinicServicesWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthInformationsController : ControllerBase
    {
        private IHealthInformations iheath;
        public HealthInformationsController(IHealthInformations iheath)
        {
            this.iheath = iheath;
        }
        [HttpGet()]
        public async Task<IEnumerable<HealthInformations>> GetHealthInformations()
        {
            return await iheath.GetHealthInformations();
        }
        [HttpGet("{healthID}")]
        public async Task<HealthInformations> GetHealthInformation(int healthID)
        {
            return await iheath.GetHealthInformation(healthID);
        }
        [HttpPost()]
        public async Task<HealthInformations> PostHealthInformations(HealthInformations healthInformations)
        {
            return await iheath.PostHealthInformations(healthInformations);
        }
        [HttpPut()]
        public async Task<HealthInformations> PutHealthInformations(HealthInformations healthInformations)
        {
            return await iheath.PutHealthInformations(healthInformations);
        }
        [HttpDelete("{healthID}")]
        public async Task<HealthInformations> DeleteHealthInformation(int healthID)
        {
            return await iheath.DeleteHealthInformation(healthID);
        }
    }
}
