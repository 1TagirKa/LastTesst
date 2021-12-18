using System;
using System.Linq;
using LastTesst.Cookie;
using LastTesst.DataConnection;
using Microsoft.AspNetCore.Mvc;

namespace LastTesst.Controllers
{
    public class ProfileController : Controller
    {
        private readonly AppDataConnection _connection;
        public ProfileController(AppDataConnection connection) => _connection = connection;
        // GET
        public IActionResult Index()
        {
            var user = _connection.User.FirstOrDefault(x => x.Email == Cookies.getCookie("email") );
            return View(user);
            
        }
    }
}