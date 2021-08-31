using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Channel> Channels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<Channel>()
            .HasData(
                new Channel
                {
                    Id = Guid.NewGuid(),
                    Name = "DotNetCore",
                    Description = "Channel dedicated to development in ASP.NET Core 5"
                },
                new Channel
                {
                    Id = Guid.NewGuid(),
                    Name = "Angular",
                    Description = "Channel dedicated to development in Angular"
                },
                new Channel
                {
                    Id = Guid.NewGuid(),
                    Name = "React.js",
                    Description = "Channel dedicated to development in React.js"
                });

            // base.OnModelCreating(modelBuilder);
        }

    }
}