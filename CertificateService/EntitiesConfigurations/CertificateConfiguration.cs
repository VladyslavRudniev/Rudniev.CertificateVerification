using CertificateService.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CertificateService.EntitiesConfigurations
{
    public class CertificateConfiguration : IEntityTypeConfiguration<Certificate>
    {
        public void Configure(EntityTypeBuilder<Certificate> builder)
        {
            builder.ToTable("CoronaCertificates", schema: "patient");
            builder.Property(m => m.Id).ValueGeneratedNever();
            builder.Property(m => m.CertificateNumber).HasMaxLength(20);
        }
    }
}
