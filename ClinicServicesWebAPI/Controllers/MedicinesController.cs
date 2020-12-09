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
    public class MedicinesController : ControllerBase
    {
        private IMedicines imedicines;
        public MedicinesController(IMedicines imedicines)
        {
            this.imedicines = imedicines;
        }
        [HttpGet()]
        public async Task<IEnumerable<Medicines>> GetMedicines()
        {
            return await imedicines.GetMedicines();
        }
        [HttpGet("{medicinesID}")]
        public async Task<Medicines> GetMedicine(int medicinesID)
        {
            return await imedicines.GetMedicine(medicinesID);
        }
        [HttpPost()]
        public async Task<Medicines> PostMedicines(Medicines medicines)
        {
            return await imedicines.PostMedicines(medicines);
        }
        [HttpPut()]
        public async Task<Medicines> PutMedicines(Medicines medicines)
        {
            return await imedicines.PutMedicines(medicines);
        }
        [HttpDelete("{accountID}")]
        public async Task<Medicines> DeleteMedicine(int medicinesID)
        {
            return await imedicines.DeleteMedicine(medicinesID);
        }
    }
}
