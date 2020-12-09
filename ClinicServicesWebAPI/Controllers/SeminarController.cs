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
    public class SeminarController : ControllerBase
    {
        private ISeminar iseminar;
        public SeminarController(ISeminar iseminar)
        {
            this.iseminar = iseminar;
        }
        [HttpGet()]
        public async Task<IEnumerable<Seminar>> GetSeminars()
        {
            return await iseminar.GetSeminars();
        }
        [HttpGet("{seminarID}")]
        public async Task<Seminar> GetSeminar(int seminarID)
        {
            return await iseminar.GetSeminar(seminarID);
        }
        [HttpPost()]
        public async Task<Seminar> PostSeminars(Seminar seminar)
        {
            return await iseminar.PostSeminars(seminar);
        }
        [HttpPut()]
        public async Task<Seminar> PutSeminars(Seminar seminar)
        {
            return await iseminar.PutSeminars(seminar);
        }
        [HttpDelete("{seminarID}")]
        public async Task<Seminar> DeleteSeminar(int seminarID)
        {
            return await iseminar.DeleteSeminar(seminarID);
        }
    }
}
