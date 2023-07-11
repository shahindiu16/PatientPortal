using PatientPortal_API.Context;
using PatientPortal_API.Models;
using PatientPortal_API.Repositories.Interfaces;

namespace PatientPortal_API.Repositories.Implementations
{
    public class DiseasesRepository : Repository<Disease>, IDiseasesRepository
    {
        public DiseasesRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
