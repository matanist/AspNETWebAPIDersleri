namespace LMS.Services.Models
{
    public class UserResponseModel
    {
        public string Email { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public int? RoleId { get; set; }
    }
}
