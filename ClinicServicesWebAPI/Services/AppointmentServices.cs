using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.DataConnect;
using ClinicServicesWebAPI.Models;

namespace ClinicServicesWebAPI.Services
{
    public class AppointmentServices : IAppointment
    {
        private ClinicContext context;
        public AppointmentServices(ClinicContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Appointment>> GetAppointments()
        {
            return context.Appointment.ToList();
        }
        public async Task<Appointment> GetAppointment(int appointID)
        {
            Appointment ap = context.Appointment.SingleOrDefault(s => s.AccountID.Equals(appointID));
            if (ap != null)
            {
                return ap;
            }
            else
            { return null; }
        }

        

        public async Task<Appointment> PostAppointments(Appointment appoint)
        {
            context.Appointment.Add(appoint);
            context.SaveChanges();
            return appoint;
        }

        public async Task<Appointment> PutAppointments(Appointment appoint)
        {
            Appointment model = context.Appointment.SingleOrDefault(s => s.AppointmentID.Equals(appoint.AppointmentID));
            if (model != null)
            {
               // model.AppointmentID = appoint.AppointmentID;
                model.AppointmentDate = appoint.AppointmentDate;
                model.Reasons = appoint.Reasons;
                model.AccountID = appoint.AccountID;
                model.DoctorID = appoint.DoctorID;
                
                context.SaveChanges();
                return appoint;
            }
            else
            {
                return null;
            }
        }
        public async Task<Appointment> DeleteAppointment(int appointID)
        {
            Appointment ap = context.Appointment.Where(s => s.AppointmentID.Equals(appointID)).FirstOrDefault();
            if (ap != null)
            {
                context.Appointment.Remove(ap);
                context.SaveChanges();
            }
            else
            { //nothing 
            }
            return null;
        }
    }
}
