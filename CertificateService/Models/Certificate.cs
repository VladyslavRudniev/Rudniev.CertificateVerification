using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CertificateService.Models
{
    public class Certificate
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ID { get; set; }
        public string CertificateNumber { get; set; }
        public Guid PatientID { get; set; }
        public Patient Patient { get; set; }
    }
}
