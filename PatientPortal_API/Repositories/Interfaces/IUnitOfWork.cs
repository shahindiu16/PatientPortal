namespace PatientPortal_API.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IPatientRepository PatientRepository { get; }
        IDiseasesRepository DiseasesRepository { get; }
        INcdRepository NcdRepository { get; }
        IAllergiesRepository AllergiesRepository { get; }
        void SaveChanges();
    }
}
