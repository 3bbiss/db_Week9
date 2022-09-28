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
            // validates we're receiving correct value/param.
            //return Content(id);
            var db = new MySqlConnection("Server=127.0.0.1;Database=business;Uid=root;Pwd=abc123;");
            Department dep = db.Get<Department>(id);

            // Get a list of ppl in dept.
            List<Employee> emps = db.Query<Employee>($"select * from employee where department = '{id}'").ToList();
            ViewData["employees"] = emps;
            return View(dep);
        }

        // View that presents a form for adding a new department
        public IActionResult AddForm()
        {
            return View();
        }

        // (C)RUD An action that responds to the form for adding a new department

        // CRU(D) Delete a department
        public IActionResult Delete(string id)
        {
            var db = new MySqlConnection("Server=127.0.0.1;Database=business;Uid=root;Pwd=abc123;");
            Department dep = new Department() { id = id };
            db.Delete<Department>(dep);
            return Redirect("/Department");
            //return Content("Deleted!");
            //return View();
        }


        // CR(U)D Edit a department 
    }
}
