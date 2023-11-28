using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProgramlama.Entity.Entities;


namespace WebProgramlama.Data.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {       
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.UseSerialColumns();
        //}
       
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
