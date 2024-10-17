namespace Catalog_Management_Service.Models
{
    public class CourseModel
    {
        public int id { get; set; }
        public string course_name { get; set; }
        public string Description { get; set; }
        public string language { get; set; }
        public string Technology { get; set; }
        public string Category { get; set; }
        public double price { get; set; }
        public bool IsCompletionCertificateAvailable { get; set; }
        public string duration { get; set; }
        public DateTime Created_At { get; set; }
    }
}
