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
    public class CustomerWriteRepository : WriteRepository<Entity.Entities.UserEntities.Customer> , ICustomerWriteRepository
    {
        public CustomerWriteRepository(AppDbContext context):base(context) 
        {
            
        }
    }
}
