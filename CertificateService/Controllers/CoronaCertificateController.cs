using CertificateService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CertificateService.Controllers
{
    [ApiController]
    public class CoronaCertificateController : Controller
    {

        // POST: CoronaCertificateController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
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

            using (var db = new BL())
            {
                db.AddPatient(patient);
                db.AddCertificate(certificate);
            }

        }

    }
}
