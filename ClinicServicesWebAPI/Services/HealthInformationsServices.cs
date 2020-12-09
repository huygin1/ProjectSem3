using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.DataConnect;
using ClinicServicesWebAPI.Models;

namespace ClinicServicesWebAPI.Services
{
    public class HealthInformationsServices : IHealthInformations
    {
        private ClinicContext context;
        public HealthInformationsServices(ClinicContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<HealthInformations>> GetHealthInformations()
        {
            return context.HealthInformations.ToList();
        }

        public async Task<HealthInformations> GetHealthInformation(int healthID)
        {
            HealthInformations health = context.HealthInformations.SingleOrDefault(h => h.HealthInfoID.Equals(healthID));
            if (health != null)
            {
                return health;
            }
            else
            {
                return null;
            }
        }

       

        public async Task<HealthInformations> PostHealthInformations(HealthInformations healthInformations)
        {
            context.HealthInformations.Add(healthInformations);
            context.SaveChanges();
            return healthInformations;
        }

        public async Task<HealthInformations> PutHealthInformations(HealthInformations healthInformations)
        {
            HealthInformations model = context.HealthInformations.SingleOrDefault(h => h.HealthInfoID.Equals(healthInformations.HealthInfoID));
            if (model != null)
            {
               // model.HealthInfoID = healthInformations.HealthInfoID;
                model.Header = healthInformations.Header;
                model.HeathContent = healthInformations.HeathContent;
                model.HealthImage = healthInformations.HealthImage;
                model.HeathReferences = healthInformations.HeathReferences;
                model.InfoLock = healthInformations.InfoLock;
                context.SaveChanges();
                return healthInformations;
            }
            else
            {
                return null;
            }
        }
        public async Task<HealthInformations> DeleteHealthInformation(int healthID)
        {
            HealthInformations health = context.HealthInformations.Where(h => h.HealthInfoID.Equals(healthID)).FirstOrDefault();
            if (health != null)
            {
                context.HealthInformations.Remove(health);
                context.SaveChanges();
                return null;
            }
            else
            {
                return null;
            }
        }

    }
}
