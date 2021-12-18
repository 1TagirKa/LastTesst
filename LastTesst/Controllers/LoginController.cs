using System.Linq;
using LastTesst.Cookie;
using LastTesst.Crypt;
using LastTesst.DataConnection;
using LastTesst.Models;
using Microsoft.AspNetCore.Mvc;

namespace LastTesst.Controllers
{
    public class LoginController : Controller
    {
        private CryptPass crypt = new CryptPass();

        private readonly AppDataConnection _connection;
        public LoginController(AppDataConnection connection) => _connection = connection;


        public IActionResult Fail()
        {
            return View();
        }
        // GET
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel user)
        {
            user.Password = crypt.Encode(user.Password);
            var userSite = _connection.User.FirstOrDefault(x => x.Email == user.Email );
            if (userSite != null)
            {
                if (userSite.Password == user.Password)
                {
                    Cookies.email = userSite.Email;
                    return Redirect("~/Profile/Index");
                }
                else
                {
                    return Redirect("~/Login/Fail");
                }
            }
            else
            {
                return Redirect("~/Login/Fail");
            }
        }

        public IActionResult LogOut()
        {
            Cookies.email = "";
            return Redirect("~/Home/Index");
        }
    }
}