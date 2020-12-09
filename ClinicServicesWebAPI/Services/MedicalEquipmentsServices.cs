using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.DataConnect;
using ClinicServicesWebAPI.Models;

namespace ClinicServicesWebAPI.Services
{
    public class MedicalEquipmentsServices : IMedicalEquipments
    {
        private ClinicContext context;
        public MedicalEquipmentsServices(ClinicContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<MedicalEquipments>> GetMedicalEquipments()
        {
            return context.MedicalEquipments.ToList();
        }

        public async Task<MedicalEquipments> GetMedicalEquipment(int equipID)
        {
            MedicalEquipments eq = context.MedicalEquipments.SingleOrDefault(s => s.Medi_Equip_ID.Equals(equipID));
            if (eq != null)
            {
                return eq;
            }
            else
            { return null; }
        }

       

        public async Task<MedicalEquipments> PostMedicalEquipments(MedicalEquipments medicalEquipments)
        {
            context.MedicalEquipments.Add(medicalEquipments);
            context.SaveChanges();
            return medicalEquipments;
        }

        public async Task<MedicalEquipments> PutMedicalEquipments(MedicalEquipments medicalEquipments)
        {
            MedicalEquipments model = context.MedicalEquipments.SingleOrDefault(s => s.Medi_Equip_ID.Equals(medicalEquipments.Medi_Equip_ID));
            if (model != null)
            {
               // model.Medi_Equip_ID = medicalEquipments.Medi_Equip_ID;
                model.EquipName = medicalEquipments.EquipName;
                model.EquipSKU = medicalEquipments.EquipSKU;
                model.EquipStatus = medicalEquipments.EquipStatus;
                model.EquipTag = medicalEquipments.EquipTag;
                model.EquipDescription = medicalEquipments.EquipDescription;
                model.EquipPrice = medicalEquipments.EquipPrice;
                model.EquipImage = medicalEquipments.EquipImage;
                model.EquipLock = medicalEquipments.EquipLock;
                model.CategoryChild_ID = medicalEquipments.CategoryChild_ID;
               
                context.SaveChanges();
                return medicalEquipments;
            }
            else
            {
                return null;
            }
        }
        public async Task<MedicalEquipments> DeleteMedicalEquipment(int equipID)
        {
            MedicalEquipments med = context.MedicalEquipments.Where(e => e.Medi_Equip_ID.Equals(equipID)).FirstOrDefault();
            if(med != null)
            {
                context.MedicalEquipments.Remove(med);
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
