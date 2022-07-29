using DataAccessLayer.EF;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public class CertificateRepository
    {
        private Context DB;
        public CertificateRepository(Context context)
        {
            DB = context;
        }
        public void Create(Certificate certificate)
        {
            DB.Certificates.Add(certificate);
        }
    }
}
