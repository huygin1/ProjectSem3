using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.Models;

namespace ClinicServicesWebAPI.Services
{
    public interface IDoctorDetail
    {
        Task<IEnumerable<DoctorDetail>> GetDoctorDetails();
        Task<DoctorDetail> GetDoctorDetail(int drdetailID);
        Task<DoctorDetail> PostDoctorDetails(DoctorDetail doctorDetail);
        Task<DoctorDetail> PutDoctorDetails(DoctorDetail doctorDetail);
        Task<DoctorDetail> DeleteDoctorDetail(int drdetailID);
    }
}
