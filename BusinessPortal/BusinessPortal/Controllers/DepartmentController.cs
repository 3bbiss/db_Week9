using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using BusinessPortal.Models;

namespace BusinessPortal.Controllers
{
    public class DepartmentController : Controller
    {
        //C(R)UD - View that lists all departments
        public IActionResult Index()
        {
            // List all of the departments
            var db = new MySqlConnection("Server=127.0.0.1;Database=business;Uid=root;Pwd=abc123;");
            IEnumerable<Department> depts = db.GetAll<Department>();
            return View(depts);
        }

        // C(R)UD View a single department and its details
        public IActionResult Detail(string id)
        {
            return Content(id);
        }

        // View that presents a form for adding a new department

        // (C)RUD An action that responds to the form for adding a new department

        // CRU(D) Delete a department

        // CR(U)D Edit a department 
    }
}
