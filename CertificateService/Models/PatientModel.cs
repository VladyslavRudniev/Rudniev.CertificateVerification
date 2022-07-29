namespace CertificateService.Models
{
    public class PatientModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }
        public CertificateModel Certificate { get; set; }
    }
}
