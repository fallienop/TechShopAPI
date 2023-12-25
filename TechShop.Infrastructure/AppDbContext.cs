using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.Domain.Entities;

namespace TechShop.Infrastructure
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt):base(opt) 
        {
            
        }

        
        public    DbSet<Category>     Categories { get; set; }
        public    DbSet<Cpu>     CPUs { get; set; }
        public    DbSet<Gpu>     GPUs { get; set; }
        public    DbSet<Laptop>  Laptops { get; set; }
        public    DbSet<PC>      PCs { get; set; }
        public    DbSet<Screen>  Screens { get; set; }
        public    DbSet<MobilePhones>       Phones { get; set; }
        public    DbSet<GamingAccessories>  Gaming { get; set; }
        public    DbSet<Accessories> Accessories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            
            
            modelBuilder.Entity<Cpu>().Property(x => x.Speed).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<PC>().Property(x => x.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Laptop>().Property(x => x.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Screen>().Property(x => x.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Gpu>().Property(x => x.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Cpu>().Property(x => x.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<MobilePhones>().Property(x => x.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<GamingAccessories>().Property(x => x.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Accessories>().Property(x => x.Price).HasColumnType("decimal(18,2)");
           
           
           
        }

    }
}
