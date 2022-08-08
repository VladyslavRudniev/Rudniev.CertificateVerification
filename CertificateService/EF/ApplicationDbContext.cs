using CertificateService.Entities;
using CertificateService.EntitiesConfigurations;
using Microsoft.EntityFrameworkCore;

namespace CertificateService.EF
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            var configurationBasePath = Directory.GetCurrentDirectory();
            builder.SetBasePath(configurationBasePath);
            builder.AddJsonFile("appsettings.json");

            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.LogTo(message => System.Diagnostics.Debug.WriteLine(message));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new CertificateConfiguration());
        }
        public DbSet<Certificate> Certificates { get; set; } = null!;
        public DbSet<Patient> Patients { get; set; } = null!;

    }
}
