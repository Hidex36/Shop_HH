using Microsoft.AspNetCore.Mvc;
using Web_CK.Data;
using Web_CK.ViewModels;

namespace Web_CK.Controllers
{
    public class AccountController : Controller
    {

        public readonly AppDbContext _context;
        public AccountController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> SignIn(SignInVM signIn)
        {
            // Xác thực người dùng (ví dụ: kiểm tra trong cơ sở dữ liệu)
            var user = _context.Users.FirstOrDefault(u => u.Email == signIn.Email && u.PasswordHash == signIn.Password);
            if (user != null)
            {
                // Lưu thông tin người dùng vào session hoặc cookie
                // Ví dụ: HttpContext.Session.SetString("UserId", user.Id.ToString());
                // Chuyển hướng đến trang chính hoặc trang hồ sơ cá nhân
                return RedirectToAction("Profile", new { id = user.Id });
            }
            else
            {
                // Hiển thị thông báo lỗi đăng nhập
                ViewBag.ErrorMessage = "Email hoặc mật khẩu không đúng.";
                return View();
            }
        }

        // GET: /Account/signup
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpVM signUp)
        {
            var NewUser = _context.Users.FirstOrDefault(u => u.Email == signUp.Email);
            if (NewUser != null)
            {
                ViewBag.ErrorMessage = "Email đã tồn tại.";
                return View(signUp);
            }
            //kiem tra cac du lieu khac nhap dung cu phap chua
            return View();
        }

        // PUT: /Account/signup_part2 update_profile_user
        [HttpPut]
        public async Task<IActionResult> SignUp_Part2(UpdateUserVM update)
        {
            var UpdateUser = 10;//tao ham GetCurenntUserId de lay id nguoi dung dang nhap thu muc session
            return View();
        }

        // GET: /Account/profile
        [HttpGet]
        public IActionResult Profile(int? id)
        {
            var Profile = _context.Users.AsQueryable();
            if (id == null)
            {
                return NotFound(/*Link trang ko co dang nhap*/);
            }
            var Result = _context.Users
                .Where(p => p.Id == id)
                .Select(p => new ProfileVM

                {
                    IDUser = p.Id,
                    FullName = p.FullName,
                    Address = p.Address,
                    DateOfBirth = p.DateOfBirth,
                    Email = p.Email,
                    Sex = p.Sex,
                    PhoneNumber = p.PhoneNumber,
                    UrlImage = p.imageUrl
                })
                .FirstOrDefault(); ;
            if(Result == null)
            {
                return NotFound(/*Link trang ko co loi 404-hien msg:loi CSDL*/);
            }
            return View(Result);
        }

        // PUT: /Account/editprofile
        [HttpPut]
        public IActionResult EditProfile(int? id)
        {
            var EditProfile = _context.Users.AsQueryable();
            if (!id.HasValue)
            {
                return NotFound( );
            }
            return View();
        }

        // GET: /Account/wishlist
        public IActionResult GetWishList(int? id)
        {
            var GetWishList = _context.Users.AsQueryable();
            if (!id.HasValue)
            {
                return NotFound( );
            }
            // lay wishlist
            return View();
        }

        public IActionResult DeLeteProduct(int? id)
        {
            return View();
        }

        public IActionResult SignOut()
        {
            // Xóa thông tin người dùng khỏi session hoặc cookie
            // Ví dụ: HttpContext.Session.Remove("UserId");
            return RedirectToAction("SignIn");
        }
    }
}
