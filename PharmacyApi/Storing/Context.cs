namespace PharmacyApi.Storing
{
    public class PharmacyContext:DbContext
    {
        public DbSet<Patient> Patients {get;set;}

        public DbSet<Drug> Drugs {get;set;}

        // empty constructor
        public PharmacyContext(){}

        public PharmacyContext(DbContextOptions<PharmacyContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=tcp:flutter.database.windows.net,1433;Initial Catalog=SharpPharm;Persist Security Info=False;User ID=sqladmin;Password=pass123!");
        }
        protected override void OnConfiguring(ModelBuilder model)
        {
            builder.Entity<Patient>().HasKey(Patient => Patient.EntityId);
            builder.Entity<Patient>().HasKey(Drug => Drug.EntityId);
        }
    }
}