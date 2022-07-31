using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CertificateService.Models
{
    public class Certificate
    {
        [Key]
        [ForeignKey("Patient")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ID { get; set; }
        public string CertificateNumber { get; set; }
        public Patient Patient { get; set; }
    }
}
