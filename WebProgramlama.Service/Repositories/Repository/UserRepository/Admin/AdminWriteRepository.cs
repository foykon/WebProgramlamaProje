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
    public class AdminWriteRepository : WriteRepository<Entity.Entities.UserEntities.Admin>, IAdminWriteRepository
    {
        public AdminWriteRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
