namespace CertificateService.Models
{
    public class CertificateModel
    {
        public Guid ID { get; set; }
        public string CertificateNumber { get; set; }
        public PatientModel Patient { get; set; }
    }
}
