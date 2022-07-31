using CertificateService.Models;
using Microsoft.EntityFrameworkCore;

namespace CertificateService.EF
{
    public class Context : DbContext
    {
        public DbSet<CertificateModel> Certificates { get; set; }
        public DbSet<PatientModel> Patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=HospitalDB;Trusted_Connection=True;");
        }
    }
}
