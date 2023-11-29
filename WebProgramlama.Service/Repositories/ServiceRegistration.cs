using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProgramlama.Data.Context;
using WebProgramlama.Service.Repositories.IRepository.ITripRepository.City;
using WebProgramlama.Service.Repositories.IRepository.ITripRepository.Plane;
using WebProgramlama.Service.Repositories.IRepository.ITripRepository.Route;
using WebProgramlama.Service.Repositories.IRepository.ITripRepository.Seat;
using WebProgramlama.Service.Repositories.IRepository.IUserRepository.Admin;
using WebProgramlama.Service.Repositories.IRepository.IUserRepository.Customer;
using WebProgramlama.Service.Repositories.Repository.TripRepository.City;
using WebProgramlama.Service.Repositories.Repository.TripRepository.Plane;
using WebProgramlama.Service.Repositories.Repository.TripRepository.Route;
using WebProgramlama.Service.Repositories.Repository.TripRepository.Seat;
using WebProgramlama.Service.Repositories.Repository.UserRepository.Admin;
using WebProgramlama.Service.Repositories.Repository.UserRepository.Customer;

namespace WebProgramlama.Service.Repositories
{
    public static class ServiceRegistration
    {

        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));


            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            
            services.AddScoped<IAdminReadRepository, AdminReadRepository>();
            services.AddScoped<IAdminWriteRepository, AdminWriteRepository>();
            
            services.AddScoped<ISeatReadRepository, SeatReadRepository>();
            services.AddScoped<ISeatWriteRepository, SeatWriteRepository>();
            
            services.AddScoped<IPlaneReadRepository, PlaneReadRepository>();
            services.AddScoped<IPlaneWriteRepository, PlaneWriteRepository>();
            
            services.AddScoped<IRouteReadRepository, RouteReadRepository>();
            services.AddScoped<IRouteWriteRepository, RouteWriteRepository>();
            
            services.AddScoped<ICityReadRepository, CityReadRepository>();
            services.AddScoped<ICityWriteRepository, CityWriteRepository>();


        }

    }
}
