using ASCIIStringConverter.Data.Configuration;
using ASCIIStringConverter.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ASCIIStringConverter.Data
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options)
            : base(options)
        { }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new PersonConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
