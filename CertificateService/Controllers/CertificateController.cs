using CertificateService.EF;
using CertificateService.Entities;
using CertificateService.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CertificateService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CertificateController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        private readonly ILogger<CertificateController> _logger;
        public CertificateController(ApplicationDbContext context, ILogger<CertificateController> logger)
        {
            _logger = logger;
            db = context;
        }

        [EnableCors("AllowOrigin")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PatientCertificateReadAndUpdateModel>>> Get()
        {
            List<PatientCertificateReadAndUpdateModel> model = new List<PatientCertificateReadAndUpdateModel>();

            var patients = await db.Patients.Include(o => o.Certificate).OrderBy(o => o.Surname).ThenBy(o => o.Name).ToListAsync();

            foreach (var patient in patients)
            {
                model.Add(new PatientCertificateReadAndUpdateModel
                {
                    PatientId = patient.Id,
                    Name = patient.Name,
                    Surname = patient.Surname,
                    BirthDate = patient.BirthDate,
                    CertificateNumber = string.IsNullOrEmpty(patient.Certificate?.CertificateNumber) ? "no number" : patient.Certificate.CertificateNumber
                });
            }

            return model;
        }

        [EnableCors("AllowOrigin")]
        [HttpPost]
        public async Task<ActionResult> Post(PatientCertificateCreateModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

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
            var result = await db.SaveChangesAsync();

            if (result == 2)
                return Ok();
            else
                return StatusCode(500);
        }

        [EnableCors("AllowOrigin")]
        [HttpPut]
        public async Task<ActionResult> Put(PatientCertificateReadAndUpdateModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else if (!db.Patients.Any(o => o.Id == model.PatientId))
            {
                return NotFound();
            }

            var patient = db.Patients.First(o => o.Id == model.PatientId);
            patient.Name = model.Name;
            patient.Surname = model.Surname;
            patient.BirthDate = model.BirthDate;
            db.Patients.Update(patient);

            var certificate = db.Certificates.FirstOrDefault(o => o.PatientId == model.PatientId);
            if (certificate is null)
            {
                Certificate newCertificate = new Certificate
                {
                    Id = Guid.NewGuid(),
                    CertificateNumber = model.CertificateNumber,
                    Patient = patient
                };
                db.Certificates.Add(newCertificate);
            }
            else
            {
                certificate.CertificateNumber = model.CertificateNumber;
                db.Certificates.Update(certificate);
            }

            var result = await db.SaveChangesAsync();

            if (result == 2)
                return Ok();
            else
                return StatusCode(500);
        }

        [EnableCors("AllowOrigin")]
        [HttpDelete]
        public async Task<ActionResult> Delete(PatientCertificateDeleteModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else if (!db.Patients.Any(o => o.Id == model.PatientId))
            {
                return NotFound();
            }

            var certificate = db.Certificates.FirstOrDefault(o => o.PatientId == model.PatientId);
            if (!(certificate is null))
            {
                db.Certificates.Remove(certificate);
            }

            var patient = db.Patients.First(o => o.Id == model.PatientId);
            db.Patients.Remove(patient);

            var result = await db.SaveChangesAsync();

            if (result == 2 || result == 1)
                return Ok();
            else
                return StatusCode(500);
        }
    }
}
