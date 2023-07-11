using PatientPortal_API.Context;
using PatientPortal_API.Models;
using PatientPortal_API.Repositories.Interfaces;

namespace PatientPortal_API.Repositories.Implementations
{
    public class NcdRepository : Repository<Ncd>, INcdRepository
    {
        public NcdRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
