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
    public class DoctorDetailsController : ControllerBase
    {
        private IDoctorDetail idoc;
        public DoctorDetailsController(IDoctorDetail idoc)
        {
            this.idoc = idoc;
        }
        [HttpGet()]
        public async Task<IEnumerable<DoctorDetail>> GetDoctorDetails()
        {
            return await idoc.GetDoctorDetails();
        }
        [HttpGet("{drdetailID}")]
        public async Task<DoctorDetail> GetDoctorDetail(int drdetailID)
        {
            return await idoc.GetDoctorDetail(drdetailID);
        }
        [HttpPost()]
        public async Task<DoctorDetail> PostDoctorDetails(DoctorDetail doctorDetail)
        {
            return await idoc.PostDoctorDetails(doctorDetail);
        }
        [HttpPut()]
        public async Task<DoctorDetail> PutDoctorDetails(DoctorDetail doctorDetail)
        {
            return await idoc.PutDoctorDetails(doctorDetail);
        }
        [HttpDelete("{drdetailID}")]
        public async Task<DoctorDetail> DeleteDoctorDetail(int drdetailID)
        {
            return await idoc.DeleteDoctorDetail(drdetailID);
        }
    }
}
