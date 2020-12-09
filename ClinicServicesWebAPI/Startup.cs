using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.Models;
using ClinicServicesWebAPI.Services;
using Microsoft.EntityFrameworkCore;

namespace ClinicServicesWebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ClinicServicesWebAPI.DataConnect.ClinicContext>(options => options.UseSqlServer
               ("server=projectsem3.database.windows.net;database=ProjectSem3;uid=thienkim;pwd=Tk23062001.,"));
            services.AddScoped<IAccounts, AccountsServices>();
            services.AddScoped<IAppointment, AppointmentServices>();
            services.AddScoped<ICategories, CategoriesServices>();
            services.AddScoped<ICategoryChild, CategoryChildServices>();
            services.AddScoped<IDoctorDetail, DoctorDetailServices>();
            services.AddScoped<IFeedback, FeedbackServices>();
            services.AddScoped<IHealthInformations, HealthInformationsServices>();
            services.AddScoped<IMedicalEquipments, MedicalEquipmentsServices>();
            services.AddScoped<IMedicines, MedicinesServices>();
            services.AddScoped<IOrders, OrdersServices>();
            services.AddScoped<ISeminar, SeminarServices>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
