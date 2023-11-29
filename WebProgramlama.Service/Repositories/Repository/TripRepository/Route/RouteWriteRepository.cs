using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProgramlama.Data.Context;
using WebProgramlama.Service.Repositories.IRepository.ITripRepository.Route;

namespace WebProgramlama.Service.Repositories.Repository.TripRepository.Route
{
    public class RouteWriteRepository : WriteRepository<Entity.Entities.TripEntities.Route> , IRouteWriteRepository
    {
        public RouteWriteRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
