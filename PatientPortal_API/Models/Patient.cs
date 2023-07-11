namespace PatientPortal_API.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int DiseaseId { get; set; }
        public int EpilepsyId { get; set; }
        public Disease Disease { get; set; } = null!;
        public List<NcdDetails> NcdDetails { get; set; } = new List<NcdDetails>();
        public List<AllergiesDetails> AllergiesDetails { get; set; } = new List<AllergiesDetails>();
    }
}
