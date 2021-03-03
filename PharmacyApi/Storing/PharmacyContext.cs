
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PharmacyApi.Models;

namespace PharmacyApi.Storing
{
    public class PharmacyContext:DbContext
    {
        public DbSet<Patient> Patients {get;set;}

        public DbSet<Drug> Drugs {get;set;}

        
        public PharmacyContext(){}

        public PharmacyContext(DbContextOptions<PharmacyContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=tcp:flutter.database.windows.net,1433;Initial Catalog=SharpPharm;Persist Security Info=False;User ID=sqladmin;Password=pass123!");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Patient>().HasKey(Patient => Patient.EntityId);
            builder.Entity<Drug>().HasKey(Drug => Drug.EntityId);
            SeedData(builder);
        }

        protected void SeedData(ModelBuilder builder)
        {
            builder.Entity<Patient>().HasData(new Patient() {EntityId=1,Name="Hank",LastName="Hill",Age=45,Sex="Male"});
        }
    }
}