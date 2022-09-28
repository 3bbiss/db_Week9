using Microsoft.AspNetCore.Mvc;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using GroceryStoreDemo.Models;

namespace GroceryStoreDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var db = new MySqlConnection("Server=127.0.0.1;Database=grocerystore;Uid=root;Pwd=abc123;");
            List<Product> prods = db.GetAll<Product>().ToList();
            return View(prods);
        }
    }
}
