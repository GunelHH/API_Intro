using System;
using Intro_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Intro_API.DAL.Configurations
{
    public class EngineConfiguration : IEntityTypeConfiguration<Engine>
    {
        public void Configure(EntityTypeBuilder<Engine> builder)
        {
            builder.Property(c => c.Name).HasMaxLength(50).IsRequired();
            builder.Property(c => c.Value).HasMaxLength(50).IsRequired();
            builder.Property(c => c.Torque).IsRequired();
            builder.Property(c => c.HP).HasMaxLength(50).IsRequired();
        }
    }
}

