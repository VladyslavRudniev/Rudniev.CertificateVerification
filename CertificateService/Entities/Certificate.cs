namespace CertificateService.Entities
{
    public class Certificate
    {
        public Guid Id { get; set; }
        public string CertificateNumber { get; set; } = null!;
        public Guid PatientId { get; set; }
        public Patient Patient { get; set; } = null!;
    }
}
