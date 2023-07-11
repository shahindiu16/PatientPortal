namespace PatientPortal_API.Models
{
    public class AllergiesDetails
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int? AllergyId { get; set; }
        public Patient Patient { get; set; } = null!;
        public Allergy? Allergy { get; set; } = null;
    }
}
