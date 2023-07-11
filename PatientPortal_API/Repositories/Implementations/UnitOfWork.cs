using PatientPortal_API.Context;
using PatientPortal_API.Repositories.Interfaces;

namespace PatientPortal_API.Repositories.Implementations
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            PatientRepository = new PatientRepository(dbContext);
            DiseasesRepository = new DiseasesRepository(dbContext);
            NcdRepository = new NcdRepository(dbContext);
            AllergiesRepository = new AllergiesRepository(dbContext);
        }
        public IPatientRepository PatientRepository { get; private set; }
        public IDiseasesRepository DiseasesRepository { get; private set; }
        public INcdRepository NcdRepository { get; private set; }
        public IAllergiesRepository AllergiesRepository { get; private set; }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
