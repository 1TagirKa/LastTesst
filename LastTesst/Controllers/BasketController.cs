using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Dataflow;
using LastTesst.Cookie;
using LastTesst.DataConnection;
using LastTesst.Models;
using LinqToDB;
using Microsoft.AspNetCore.Mvc;

namespace LastTesst.Controllers
{
    public class BasketController : Controller
    {
        private readonly AppDataConnection _connection;
        public BasketController(AppDataConnection connection) => _connection = connection;
        
        // GET
        public IActionResult Index()
        {
            var user = _connection.User.FirstOrDefault(x => x.Email == Cookies.getCookie("email") );
            int[] products = user.Products;

            Product[] allProducts = new Product[products.Length];
            
            for (int i = 0; i < products.Length; i++)
            {
                var prod = _connection.Product.FirstOrDefault(x => x.Id == products[i]);
                allProducts[i] = prod;
            }
            
            return View(allProducts);
        }


        public IActionResult AddProduct(int id)
        {
            var user = _connection.User.FirstOrDefault(x => x.Email == Cookies.getCookie("email") );
            int[] arr = new int[user.Products.Length + 1];
            for (int i = 0; i < user.Products.Length + 1; i++)
            {
                if (i != user.Products.Length)
                {
                    arr[i]= user.Products[i];
                }
                else
                {
                    arr[i]= id;
                }
            }
            _connection.Delete(user);
            user.Products = arr;
            _connection.Insert(user);
            return Redirect("~/Basket/Index");
        }
    }
}