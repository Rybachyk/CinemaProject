namespace Cinema.Models.DataBaseModels
{
    public class Users
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }
    }
}
