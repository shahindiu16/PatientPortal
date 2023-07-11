using PatientPortal_API.Models;

namespace PatientPortal_API.Repositories.Interfaces
{
    public interface IPatientRepository : IRepository<Patient>
    {
        void AddWithDependency(PatientViewModel vm);
    }
}
