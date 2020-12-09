using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.DataConnect;
using ClinicServicesWebAPI.Models;

namespace ClinicServicesWebAPI.Services
{
    public class DoctorDetailServices : IDoctorDetail
    {
        private ClinicContext context;
        public DoctorDetailServices(ClinicContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<DoctorDetail>> GetDoctorDetails()
        {
            return context.DoctorDetail.ToList();
        }


        public async Task<DoctorDetail> GetDoctorDetail(int drdetailID)
        {
            DoctorDetail dr = context.DoctorDetail.SingleOrDefault(d => d.DoctorID.Equals(drdetailID));
            if (dr != null)
            {
                return dr;
            }
            else
            { return null; }
        }



        public async Task<DoctorDetail> PostDoctorDetails(DoctorDetail doctorDetail)
        {
            context.DoctorDetail.Add(doctorDetail);
            context.SaveChanges();
            return doctorDetail;
        }

        public async Task<DoctorDetail> PutDoctorDetails(DoctorDetail doctorDetail)
        {
            DoctorDetail model = context.DoctorDetail.SingleOrDefault(s => s.DoctorID.Equals(doctorDetail.DoctorID));
            if (model != null)
            {
                model.DrQualification = doctorDetail.DrQualification;
                model.Specialist = doctorDetail.Specialist;
                model.DrDescription = doctorDetail.DrDescription;
                model.DrPosition = doctorDetail.DrPosition;
                model.DrExperiences = doctorDetail.DrExperiences;
                model.DrImage = doctorDetail.DrExperiences;
                model.DrLock = doctorDetail.DrLock;
                       
                context.SaveChanges();
                return doctorDetail;
            }
            else
            {
                return null;
            }
        }
        public async Task<DoctorDetail> DeleteDoctorDetail(int drdetailID)
        {
            throw new NotImplementedException();
        }
    }
}
