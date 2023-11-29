using ETicaretAPI.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProgramlama.Data.Context;
using WebProgramlama.Service.Repositories.IRepository.ITripRepository.Plane;

namespace WebProgramlama.Service.Repositories.Repository.TripRepository.Plane
{
    public class PlaneWriteRepository : WriteRepository<Entity.Entities.TripEntities.Plane> , IPlaneWriteRepository
    {
        public PlaneWriteRepository(AppDbContext context):base(context)
        {
            
        }
    }
}
