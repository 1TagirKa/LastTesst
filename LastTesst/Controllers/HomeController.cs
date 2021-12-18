using System.Collections.Generic;
using System.Linq;
using LastTesst.DataConnection;
using LastTesst.Models;
using Microsoft.AspNetCore.Mvc;

namespace LastTesst.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDataConnection _connection;
        public HomeController(AppDataConnection connection) => _connection = connection;
        
        // GET
        public IActionResult Index()
        {
            List<Product> products = _connection.Product.ToList();
            
            return View(products);
        }
    }
}