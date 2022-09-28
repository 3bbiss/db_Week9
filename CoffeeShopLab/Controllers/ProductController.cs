using Microsoft.AspNetCore.Mvc;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using CoffeeShopLab.Controllers;
using CoffeeShopLab.Models;

namespace CoffeeShopLab.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var db = new MySqlConnection("Server=127.0.0.1;Database=coffeeshop;Uid=root;Pwd=abc123;");
            IEnumerable<Product> prods = db.GetAll<Product>();
            return View(prods);
            //List<Product> prods = db.GetAll<Product>().ToList();
        }

        public IActionResult Detail(string id)
        {
            var db = new MySqlConnection("Server=127.0.0.1;Database=coffeeshop;Uid=root;Pwd=abc123;");
            Product prod = db.Get<Product>(id);
            return View(prod);
        }

        public IActionResult Category(string category)
        {
            var db = new MySqlConnection("Server=127.0.0.1;Database=coffeeshop;Uid=root;Pwd=abc123;");
            //List<Product> prods = db.Query<Product>($"select distinct category from product").ToList();
            IEnumerable<Product> prods = db.Query<Product>($"select * from product where category = '{category}'");
            ViewData["categories"] = prods;
            return View();
        }
    }
}
