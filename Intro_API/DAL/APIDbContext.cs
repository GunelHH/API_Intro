using System;
using Intro_API.DAL.Configurations;
using Intro_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Intro_API.DAL
{
    public class APIDbContext:DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext>options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarConfiguration());
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Engine> Engines { get; set; }
    }
}

