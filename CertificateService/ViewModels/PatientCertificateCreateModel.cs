using System.ComponentModel.DataAnnotations;

namespace CertificateService.ViewModels
{
    public class PatientCertificateCreateModel
    {
        [Required]
        [MaxLength(30)]
        [MinLength(1)]
        public string? Name { get; set; }
        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string? Surname { get; set; }
        
        [Required]
        [MaxLength(10)]
        public string? BirthDate { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(16)]
        public string? CertificateNumber { get; set; }
    }
}
