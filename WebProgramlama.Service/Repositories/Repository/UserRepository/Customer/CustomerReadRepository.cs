using ETicaretAPI.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProgramlama.Data.Context;
using WebProgramlama.Service.Repositories.IRepository.IUserRepository.Customer;

namespace WebProgramlama.Service.Repositories.Repository.UserRepository.Customer
{
    public class CustomerReadRepository : ReadRepository<Entity.Entities.UserEntities.Customer> , ICustomerReadRepository
    {
        public CustomerReadRepository(AppDbContext context):base(context) 
        {
            
        }
    }
}
