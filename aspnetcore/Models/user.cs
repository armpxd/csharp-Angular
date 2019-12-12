namespace aspnetcore.Models
{
    public class user
    {
        public int Id { get; set; }
        public string User { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}