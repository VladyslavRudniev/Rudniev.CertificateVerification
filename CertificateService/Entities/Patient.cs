namespace CertificateService.Entities
{
    public class Patient
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string BirthDate { get; set; } = null!;
        public Certificate? Certificate { get; set; }
    }
}
