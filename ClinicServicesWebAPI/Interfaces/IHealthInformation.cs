using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.Models;

namespace ClinicServicesWebAPI.Services
{
   public interface IHealthInformations
    {
        Task<IEnumerable<HealthInformations>> GetHealthInformations();
        Task<HealthInformations> GetHealthInformation(int healthID);
        Task<HealthInformations> PostHealthInformations(HealthInformations healthInformations);
        Task<HealthInformations> PutHealthInformations(HealthInformations healthInformations);
        Task<HealthInformations> DeleteHealthInformation(int healthID);
    }
}
