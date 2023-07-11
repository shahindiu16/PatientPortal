namespace PatientPortal_API.Models
{
    public class Ncd
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<NcdDetails> NcdDetails { get; set; } = new List<NcdDetails>();
    }
}
