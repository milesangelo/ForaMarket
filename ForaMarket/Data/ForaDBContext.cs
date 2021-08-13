using ForaMarket.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForaMarket.Data
{
    public class ForaDBContext : DbContext
    {

        public ForaDBContext() : base() { }

        public ForaDBContext(DbContextOptions<ForaDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Merchandise>().HasData(
                new Merchandise() { Id = 1, Name = "Dead bee body", DateCreated = DateTime.Now },
                new Merchandise() { Id = 2, Name = "A living bee body", DateCreated = DateTime.Now },
                new Merchandise() { Id = 3, Name = "oh shit, another dead bee body", DateCreated = DateTime.Now });
        }

        public virtual DbSet<Merchandise> Merchandises { get; set; }
    }
}
