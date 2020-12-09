using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.DataConnect;
using ClinicServicesWebAPI.Models;

namespace ClinicServicesWebAPI.Services 
{
    public class SeminarServices : ISeminar
    {
        private ClinicContext context;
        public SeminarServices(ClinicContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Seminar>> GetSeminars()
        {
            return context.Seminar.ToList();
        }

        public async Task<Seminar> GetSeminar(int seminarID)
        {
            Seminar sem = context.Seminar.SingleOrDefault(s => s.SeminarID.Equals(seminarID));
            if (sem != null)
            {
                return sem;
            }
            else
            { return null; }
        }

       

        public async Task<Seminar> PostSeminars(Seminar seminar)
        {
            context.Seminar.Add(seminar);
            context.SaveChanges();
            return seminar;
        }

        public async Task<Seminar> PutSeminars(Seminar seminar)
        {
            Seminar model = context.Seminar.SingleOrDefault(s => s.SeminarID.Equals(seminar.SeminarID));
            if (model != null)
            {
                //model.SeminarID = seminar.SeminarID;
                model.SeminarTopic = seminar.SeminarTopic;
                model.Staff = seminar.Staff;
                model.SeminarDate = seminar.SeminarDate;
                model.SeminarMaterials = seminar.SeminarMaterials;
                model.SeminarDescription = seminar.SeminarDescription;
                model.NumOfParticipants = seminar.NumOfParticipants;
                model.Staff_Info = seminar.Staff_Info;
                model.SeminarLock = model.SeminarLock;
                context.SaveChanges();
                return seminar;
            }
            else
            {
                return null;
            }
        }
        public async Task<Seminar> DeleteSeminar(int seminarID)
        {
            Seminar sem = context.Seminar.Where(n => n.SeminarID.Equals(seminarID)).FirstOrDefault();
            if (sem != null)
            {
                context.Seminar.Remove(sem);
                context.SaveChanges();
             
            }
            else
            {
                //no thing 
            }
            return null;
        }
    }
}
