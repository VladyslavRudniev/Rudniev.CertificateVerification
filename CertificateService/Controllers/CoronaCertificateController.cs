using CertificateService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CertificateService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoronaCertificateController : ControllerBase
    {
        private readonly ILogger<CoronaCertificateController> _logger;
        public CoronaCertificateController(ILogger<CoronaCertificateController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "addcertificate")]
        public void Create(string name, string surname, string birthDate, string certificateNumber)
        {
            PatientModel patient = new PatientModel()
            {
                ID = Guid.NewGuid(),
                Name = name,
                Surname = surname,
                BirthDate = birthDate
            };
            CertificateModel certificate = new CertificateModel()
            {
                ID = Guid.NewGuid(),
                CertificateNumber = certificateNumber,
                Patient = patient
            };
            patient.Certificate = certificate;

        }

    }
}
