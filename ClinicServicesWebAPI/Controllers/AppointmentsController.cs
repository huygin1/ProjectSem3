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
    public class AppointmentsController : ControllerBase
    {
        private IAppointment iappoint;
        public AppointmentsController(IAppointment iappoint)
        {
            this.iappoint = iappoint;
        }
        [HttpGet()]
        public async Task<IEnumerable<Appointment>> GetAppointments()
        {
            return await iappoint.GetAppointments();
        }
        [HttpGet("{accountID}")]
        public async Task<Appointment> GetAppointment(int appointID)
        {
            return await iappoint.GetAppointment(appointID);
        }
        [HttpPost()]
        public async Task<Appointment> PostAppointments(Appointment appoint)
        {
            return await iappoint.PostAppointments(appoint);
        }
        [HttpPut()]
        public async Task<Appointment> PutAppointments(Appointment appoint)
        {
            return await iappoint.PutAppointments(appoint);
        }
        [HttpDelete("{appointID}")]
        public async Task<Appointment> DeleteAppointment(int appointID)
        {
            return await iappoint.DeleteAppointment(appointID);
        }
    }
}
