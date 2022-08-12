namespace CertificateService.ViewModels
{
    public class PatientCertificateReadAndUpdateModel
    {
        public Guid PatientId { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? BirthDate { get; set; }
        public string? CertificateNumber { get; set; }
    }
}
