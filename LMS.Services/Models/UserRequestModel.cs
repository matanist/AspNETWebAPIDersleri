namespace LMS.Services.Models
{
    public class UserRequestModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int RoleId { get; set; }
    }
}
