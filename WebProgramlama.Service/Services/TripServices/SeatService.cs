using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProgramlama.Data.Context;

namespace WebProgramlama.Service.Services.TripServices
{
    public class SeatService
    {
        public DbContext dbContext { get; set; }
        public SeatService(DbContext _dbContext) 
        {
            dbContext = _dbContext;
        }
    
       

    }
}
