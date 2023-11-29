using ETicaretAPI.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProgramlama.Data.Context;
using WebProgramlama.Service.Repositories.IRepository.ITripRepository.Seat;

namespace WebProgramlama.Service.Repositories.Repository.TripRepository.Seat
{
    public class SeatReadRepository : ReadRepository<Entity.Entities.TripEntities.Seat> , ISeatReadRepository
    {
        public SeatReadRepository(AppDbContext context): base(context) 
        {
            
        }
    }
}
