using System.Linq;
using LastTesst.DataConnection;
using Microsoft.AspNetCore.Mvc;

namespace LastTesst.Controllers
{
    public class ProductPageController : Controller
    {
        private readonly AppDataConnection _connection;
        public ProductPageController(AppDataConnection connection) => _connection = connection;
        // GET
        public IActionResult Index(int id)
        {
            
            var product = _connection.Product.FirstOrDefault(x => x.Id == id);
            return View(product);
        }
    }
}