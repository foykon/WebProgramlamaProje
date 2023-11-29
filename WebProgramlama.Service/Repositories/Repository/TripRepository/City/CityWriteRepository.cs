using ETicaretAPI.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProgramlama.Data.Context;
using WebProgramlama.Service.Repositories.IRepository.ITripRepository.City;

namespace WebProgramlama.Service.Repositories.Repository.TripRepository.City
{
    public class CityWriteRepository : WriteRepository<Entity.Entities.TripEntities.City> , ICityWriteRepository
    {
        public CityWriteRepository(AppDbContext context):base(context) { }
       
    }
}
