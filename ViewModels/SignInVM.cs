namespace Web_CK.ViewModels
{
    public class SignInVM
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class SignUpVM
    {
        public int idUser { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ComfirmPassword { get; set; }
    }
    public class ProfileVM
    {
        public int IDUser { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Sex { get; set; }
        public string UrlImage { get; set; }
    }

    public class UpdateUserVM
    {
        public int IDUser { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Sex { get; set; }
    }
}
