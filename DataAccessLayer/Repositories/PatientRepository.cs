using DataAccessLayer.EF;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public class PatientRepository
    {
        private Context DB;
        public PatientRepository(Context context)
        {
            DB = context;
        }
        public void Create(Patient patient)
        {
            DB.Patients.Add(patient);
        }
    }
}
