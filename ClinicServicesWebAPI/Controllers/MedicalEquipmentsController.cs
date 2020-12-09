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
    public class MedicalEquipmentsController : ControllerBase
    {
        private IMedicalEquipments iequip;
        public MedicalEquipmentsController(IMedicalEquipments iequip)
        {
            this.iequip = iequip;
        }
        [HttpGet()]
        public async Task<IEnumerable<MedicalEquipments>> GetMedicalEquipments()
        {
            return await iequip.GetMedicalEquipments();
        }
        [HttpGet("{equipID}")]
        public async Task<MedicalEquipments> GetMedicalEquipment(int equipID)
        {
            return await iequip.GetMedicalEquipment(equipID);
        }
        [HttpPost()]
        public async Task<MedicalEquipments> PostMedicalEquipments(MedicalEquipments medicalEquipments)
        {
            return await iequip.PostMedicalEquipments(medicalEquipments);
        }
        [HttpPut()]
        public async Task<MedicalEquipments> PutMedicalEquipments(MedicalEquipments medicalEquipments)
        {
            return await iequip.PutMedicalEquipments(medicalEquipments);
        }
        [HttpDelete("{equipID}")]
        public async Task<MedicalEquipments> DeleteMedicalEquipment(int equipID)
        {
            return await iequip.DeleteMedicalEquipment(equipID);
        }
    }
}
