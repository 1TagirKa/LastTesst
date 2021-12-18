using LastTesst.Crypt;
using LastTesst.DataConnection;
using LastTesst.Models;
using LinqToDB;
using Microsoft.AspNetCore.Mvc;

namespace LastTesst.Controllers
{
    public class RegisterController : Controller
    {
        private CryptPass crypt = new CryptPass();

        private readonly AppDataConnection _connection;
        public RegisterController(AppDataConnection connection) => _connection = connection;
        
        // GET
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegistrationModel user)
        {
            user.Password = crypt.Encode(user.Password);
            _connection.Insert(new User()
                { Name = user.Name, Nickname = user.Username, Email = user.Email, Password = user.Password, Phone = user.Phone, Image = "~/Images/profile/alex.png", Products = new int[1]});
            return NoContent();
        }
    }
}