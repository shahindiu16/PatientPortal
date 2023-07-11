using PatientPortal_API.Context;
using PatientPortal_API.Models;
using PatientPortal_API.Repositories.Interfaces;

namespace PatientPortal_API.Repositories.Implementations
{
    public class PatientRepository : Repository<Patient>, IPatientRepository
    {
        public PatientRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public void AddWithDependency(PatientViewModel vm)
        {

            var patient = new Patient();
            patient.Id = vm.Id;
            patient.DiseaseId = vm.DiseaseId;
            patient.Name = vm.PatientName;

            var allergiesDetails = new List<AllergiesDetails>();
            foreach (var item in vm.Allergies)
            {
                var allergiesDetail = new AllergiesDetails();
                allergiesDetail.AllergyId = item;
                allergiesDetails.Add(allergiesDetail);
            }
            var ncdDetails = new List<NcdDetails>();
            foreach (var item in vm.Ncds)
            {
                var ncdDetail = new NcdDetails();
                ncdDetail.NCDId = item;
                ncdDetails.Add(ncdDetail);
            }

            patient.AllergiesDetails = allergiesDetails;
            patient.NcdDetails = ncdDetails;

            _dbContext.Patients.Add(patient);
        }
    }
}
