using CertificateService.EF;
using CertificateService.Entities;
using CertificateService.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CertificateService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CertificateController : ControllerBase
    {
        private ApplicationDbContext db;
        private readonly ILogger<CertificateController> _logger;
        public CertificateController(ApplicationDbContext context, ILogger<CertificateController> logger)
        {
            _logger = logger;
            db = context;
        }

        [EnableCors("AllowOrigin")]
        [HttpPost]
        public async Task<ActionResult> Post(PatientCertificateModel model)
        {
            int result;

            if (!string.IsNullOrEmpty(model.Name) && !string.IsNullOrEmpty(model.Surname)
                && !string.IsNullOrEmpty(model.BirthDate) && !string.IsNullOrEmpty(model.CertificateNumber))
            {
                Patient patient = new Patient
                {
                    Id = Guid.NewGuid(),
                    Name = model.Name,
                    Surname = model.Surname,
                    BirthDate = model.BirthDate
                };
                db.Patients.Add(patient);
                Certificate certificate = new Certificate
                {
                    Id = Guid.NewGuid(),
                    CertificateNumber = model.CertificateNumber,
                    Patient = patient
                };
                db.Certificates.Add(certificate);
                result = await db.SaveChangesAsync();
            }
            else
            {
                return BadRequest(model);
            }

            if (result == 2)
                return Ok();
            else
                return StatusCode(500);
        }

    }
}
