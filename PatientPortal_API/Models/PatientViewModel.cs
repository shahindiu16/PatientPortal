namespace PatientPortal_API.Models
{
    public class PatientViewModel
    {
        public int Id { get; set; }
        public int DiseaseId { get; set; }
        public int EpilepsyId { get; set; }
        public string PatientName { get; set; } = string.Empty;
        public List<int> Ncds { get; set; } = new List<int>();
        public List<int> Allergies { get; set; } = new List<int>();
    }
}
