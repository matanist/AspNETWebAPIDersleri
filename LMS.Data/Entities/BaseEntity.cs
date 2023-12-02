namespace LMS.Data.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; } = new DateTime();
        public DateTime? LastUpdatedDate { get; set; } = new DateTime();
        public bool? IsActive { get; set; }
    }
}
