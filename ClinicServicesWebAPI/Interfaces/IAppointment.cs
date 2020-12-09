using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.Models;

namespace ClinicServicesWebAPI.Services
{
   public interface IAppointment
    {
        Task<IEnumerable<Appointment>> GetAppointments();
        Task<Appointment> GetAppointment(int appointID);
        Task<Appointment> PostAppointments(Appointment appoint);
        Task<Appointment> PutAppointments(Appointment appoint);
        Task<Appointment> DeleteAppointment(int appointID);
    }
}
