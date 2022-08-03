using System;
using Intro_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Intro_API.DAL
{
    public class APIDbContext:DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext>options):base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }

    }
}

