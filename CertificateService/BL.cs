using AutoMapper;
using CertificateService.Models;
using DataAccessLayer;
using DataAccessLayer.Entities;

namespace CertificateService
{
    public class BL : IDisposable
    {
        private UnitOfWork DB { get; }

        public BL()
        {
            DB = new UnitOfWork();
        }
        public void AddPatient(PatientModel element)
        {
            DB.Patients.Create(Mapper.Map<Patient>(element));
            DB.Save();
        }
        public void AddCertificate(CertificateModel element)
        {
            DB.Certificates.Create(Mapper.Map<Certificate>(element));
            DB.Save();
        }
        public void Dispose()
        {
            DB.Dispose();
        }
    }
}
