using ETicaretAPI.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProgramlama.Data.Context;
using WebProgramlama.Service.Repositories.IRepository.IUserRepository.Admin;

namespace WebProgramlama.Service.Repositories.Repository.UserRepository.Admin
{
    public class AdminReadRepository : ReadRepository<Entity.Entities.UserEntities.Admin> , IAdminReadRepository
    {
        public AdminReadRepository(AppDbContext context):base(context) 
        {
            
        }
    }
}
