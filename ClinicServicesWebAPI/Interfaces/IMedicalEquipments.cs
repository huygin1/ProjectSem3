using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.Models;
namespace ClinicServicesWebAPI.Services
{
   public interface IMedicalEquipments
    {
        Task<IEnumerable<MedicalEquipments>> GetMedicalEquipments();
        Task<MedicalEquipments> GetMedicalEquipment(int equipID);
        Task<MedicalEquipments> PostMedicalEquipments(MedicalEquipments medicalEquipments);
        Task<MedicalEquipments> PutMedicalEquipments(MedicalEquipments medicalEquipments);
        Task<MedicalEquipments> DeleteMedicalEquipment(int equipID);
    }
}
