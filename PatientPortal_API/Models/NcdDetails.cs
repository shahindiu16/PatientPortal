namespace PatientPortal_API.Models
{
    public class NcdDetails
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int? NCDId { get; set; }
        public Ncd? NCD { get; set; } = null;
        public Patient Patient { get; set; } = null!;
    }
}
