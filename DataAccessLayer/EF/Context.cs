using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EF
{
    public class Context : DbContext
    {
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Patient> Patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=HospitalDB;Trusted_Connection=True;");
        }
    }
}
