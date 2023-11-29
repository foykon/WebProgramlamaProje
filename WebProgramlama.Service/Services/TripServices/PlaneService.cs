using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProgramlama.Entity.Entities.TripEntities;

namespace WebProgramlama.Service.Services.TripServices
{
    public class PlaneService : BaseService
    {
        public DbContext _dbContext { get; set; }
        public PlaneService(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void CreatePlane(Plane plane)
        {

            _dbContext.AddAsync(plane);
        }
    }
}
