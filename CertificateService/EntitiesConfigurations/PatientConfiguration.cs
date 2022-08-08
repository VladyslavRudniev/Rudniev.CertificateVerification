using CertificateService.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CertificateService.EntitiesConfigurations
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable("Patients", schema: "patient");
            builder.Property(m => m.Id).ValueGeneratedNever();
            builder.Property(m => m.Name).HasMaxLength(30);
            builder.Property(m => m.Surname).HasMaxLength(30);
            builder.Property(m => m.BirthDate).HasMaxLength(10);
        }
    }
}
