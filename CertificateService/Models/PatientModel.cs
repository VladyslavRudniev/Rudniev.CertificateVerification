using System.ComponentModel.DataAnnotations.Schema;

namespace CertificateService.Models
{
    public class PatientModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }
        public CertificateModel Certificate { get; set; }
    }
}
