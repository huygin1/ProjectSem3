using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.DataConnect;
using ClinicServicesWebAPI.Models;

namespace ClinicServicesWebAPI.Services
{
    public class MedicinesServices : IMedicines
    {
        private ClinicContext context;
        public MedicinesServices(ClinicContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Medicines>> GetMedicines()
        {
            return context.Medicines.ToList();
        }


        public async Task<Medicines> GetMedicine(int medicinesID)
        {
            Medicines med = context.Medicines.SingleOrDefault(s => s.MedicineID.Equals(medicinesID));
            if (med != null)
            {
                return med;
            }
            else
            { return null; }

        }

      
        public async Task<Medicines> PostMedicines(Medicines medicines)
        {
            context.Medicines.Add(medicines);
            context.SaveChanges();
            return medicines;
        }

        public async Task<Medicines> PutMedicines(Medicines medicines)
        {
            Medicines model = context.Medicines.SingleOrDefault(s => s.MedicineID.Equals(medicines.MedicineID));
            if (model != null)
            {
               // model.MedicineID = medicines.MedicineID;
                model.MedicineName = medicines.MedicineName;
                model.MedicineSKU = medicines.MedicineSKU;
                model.MedicineStatus = medicines.MedicineStatus;
                model.MedicineTag = medicines.MedicineTag;
                model.MedicineDescription = medicines.MedicineDescription;
                model.MedicinePrice = medicines.MedicinePrice;
                model.MedicineImage = medicines.MedicineImage;
                model.MedicineLock = medicines.MedicineLock;
                model.MedicineExpiryDate = medicines.MedicineExpiryDate;
                model.CategoryChild_ID = medicines.CategoryChild_ID;
                context.SaveChanges();
                return medicines;
            }
            else
            {
                return null;
            }
        }
        public async Task<Medicines> DeleteMedicine(int medicinesID)
        {
            Medicines medicines = context.Medicines.Where(n => n.MedicineID.Equals(medicinesID)).FirstOrDefault();
            if (medicines != null)
            {
                context.Medicines.Remove(medicines);
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
