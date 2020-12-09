using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClinicServicesWebAPI.Models;

namespace ClinicServicesWebAPI.DataConnect
{
    public class ClinicContext : DbContext
    {
        public ClinicContext(DbContextOptions options) : base(options) { }
        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Appointment> Appointment { get; set; }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<CategoryChild> CategoryChild { get; set; }
        public DbSet<DoctorDetail> DoctorDetail { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<HealthInformations> HealthInformations { get; set; }
        public DbSet<MedicalEquipments> MedicalEquipments { get; set; }
        public DbSet<Medicines> Medicines { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Seminar> Seminar { get; set; }
    }
}
