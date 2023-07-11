namespace PatientPortal_API.Models
{
    public class Allergy
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<AllergiesDetails> AllergiesDetails { get; set; } = new List<AllergiesDetails>();
    }
}
