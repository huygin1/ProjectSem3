using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.Models;

namespace ClinicServicesWebAPI.Services
{
   public interface ISeminar
    {
        Task<IEnumerable<Seminar>> GetSeminars();
        Task<Seminar> GetSeminar(int seminarID);
        Task<Seminar> PostSeminars(Seminar seminar);
        Task<Seminar> PutSeminars(Seminar seminar);
        Task<Seminar> DeleteSeminar(int seminarID);
    }
}
