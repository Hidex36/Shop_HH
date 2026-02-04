namespace Web_CK.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string imageUrl { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Sex { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        //role

        public ICollection<Orders> Orders { get; set; }
        public ICollection<WishList> WishLists { get; set; }
    }
}
