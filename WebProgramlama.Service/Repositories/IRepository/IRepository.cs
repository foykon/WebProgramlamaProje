using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProgramlama.Entity.Entities.BaseEntitiy;

namespace ETicaretAPI.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        //ortak repository alanlarını buraya yazıyoruz
        DbSet<T> Table { get; }

    }
}
