using System;
using Intro_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Intro_API.DAL.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.Property(c => c.Model).HasMaxLength(30).IsRequired();
            builder.Property(c => c.Brand).HasMaxLength(25).IsRequired();
            builder.Property(c => c.Price).HasColumnType("decimal(9,2)").IsRequired();
            builder.Property(c => c.Color).HasMaxLength(15).IsRequired();
            
        }
    }
}

