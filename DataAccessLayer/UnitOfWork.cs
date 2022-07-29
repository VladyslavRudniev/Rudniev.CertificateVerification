using DataAccessLayer.EF;
using DataAccessLayer.Repositories;

namespace DataAccessLayer
{
    public class UnitOfWork : IDisposable
    {
        private Context DataBase { get; }
        private PatientRepository patientRepository;
        private CertificateRepository certificateRepository;

        public UnitOfWork()
        {
            DataBase = new Context();
        }

        public PatientRepository Patients
        {
            get
            {
                if (patientRepository == null)
                    patientRepository = new PatientRepository(DataBase);
                return patientRepository;
            }
        }
        public CertificateRepository Certificates
        {
            get
            {
                if (certificateRepository == null)
                    certificateRepository = new CertificateRepository(DataBase);
                return certificateRepository;
            }
        }
        public void Save()
        {
            DataBase.SaveChanges();
        }
        public void Dispose()
        {
            DataBase.Dispose();
        }
    }
}
