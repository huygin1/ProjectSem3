using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.Models;

namespace ClinicServicesWebAPI.Services
{
  public interface IMedicines
    {
        Task<IEnumerable<Medicines>> GetMedicines();
        Task<Medicines> GetMedicine(int medicinesID);
        Task<Medicines> PostMedicines(Medicines medicines);
        Task<Medicines> PutMedicines(Medicines medicines);
        Task<Medicines> DeleteMedicine(int medicinesID);
    }
}
