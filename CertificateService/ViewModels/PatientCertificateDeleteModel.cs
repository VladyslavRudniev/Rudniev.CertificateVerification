using System.ComponentModel.DataAnnotations;

namespace CertificateService.ViewModels
{
    public class PatientCertificateDeleteModel
    {
        [Required]
        public Guid PatientId { get; set; }
    }
}
