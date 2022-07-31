using CertificateService.EF;
using CertificateService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CertificateService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CertificateController : ControllerBase
    {
        private Context db;
        private readonly ILogger<CertificateController> _logger;
        public CertificateController(Context context, ILogger<CertificateController> logger)
        {
            _logger = logger;
            db = context;
        }

        [HttpPost]
        public async Task<ActionResult<Certificate>> Post(PatientCertificateModel model)
        {
            Patient patient = new Patient
            {
                ID = Guid.NewGuid(),
                Name = model.Name,
                Surname = model.Surname,
                BirthDate = model.BirthDate
            };

            Certificate certificate = new Certificate
            {
                ID = Guid.NewGuid(),
                CertificateNumber = model.CertificateNumber,
                Patient = patient
            };

            db.Patients.Add(patient);
            db.Certificates.Add(certificate);
            await db.SaveChangesAsync();
            return Ok(certificate);

        }

    }
}
