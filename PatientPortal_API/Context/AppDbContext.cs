using Microsoft.EntityFrameworkCore;
using PatientPortal_API.Models;

namespace PatientPortal_API.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Patient> Patients { get; set; } = null!;
        public DbSet<Ncd> Ncd { get; set; } = null!;
        public DbSet<Disease> Diseases { get; set; } = null!;
        public DbSet<NcdDetails> NcdDetails { get; set; } = null!;
        public DbSet<Allergy> Allergies { get; set; } = null!;
        public DbSet<AllergiesDetails> AllergiesDetails { get; set; } = null!;
    }
}
