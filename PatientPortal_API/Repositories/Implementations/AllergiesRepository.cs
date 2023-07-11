using PatientPortal_API.Context;
using PatientPortal_API.Models;
using PatientPortal_API.Repositories.Interfaces;

namespace PatientPortal_API.Repositories.Implementations
{
    public class AllergiesRepository : Repository<Allergy>, IAllergiesRepository
    {
        public AllergiesRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
