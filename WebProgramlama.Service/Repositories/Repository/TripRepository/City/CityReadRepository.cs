using ETicaretAPI.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProgramlama.Data.Context;
using WebProgramlama.Entity.Entities.UserEntities;
using WebProgramlama.Service.Repositories.IRepository.ITripRepository.City;

namespace WebProgramlama.Service.Repositories.Repository.TripRepository.City
{
    public class CityReadRepository : ReadRepository<Entity.Entities.TripEntities.City>, ICityReadRepository
    {
        public CityReadRepository(AppDbContext context):base(context)
        {
            
        }
    }
}
