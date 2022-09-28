using Dapper;
using Dapper.Contrib.Extensions;
using DapperConsole;
using MySql.Data.MySqlClient;

//var db = new MySqlConnection("Server=127.0.0.1;Database=business;Uid=root;Pwd=abc123");
var db = new MySqlConnection("Server=127.0.0.1;Database=business;Uid=root;Pwd=abc123;");

List<Employee> emps = db.GetAll<Employee>().ToList();

foreach (Employee emp in emps)
{
    Console.WriteLine(emp);
}

Console.WriteLine();
Console.WriteLine();

// Let's add a new employee
//Employee e1 = new Employee() { firstname = "Ali", lastname = "Abbiss", phone = "111-222-3333", email = "ali@goat.com", department = "IT" };
//db.Insert(e1);

//db.Delete(new Employee() { id = 29 });


//Console.WriteLine("Let's read a single row by ID. 5.");

//// db.GET() is supposedly tied to Table's ID.
//Employee emp2 = db.Get<Employee>(5);
//Console.WriteLine(emp2);


// Change emily to emilie
//emp2.firstname = "Emilie";
//db.Update<Employee>(emp2);

//Console.WriteLine();
//Console.WriteLine("Let's get all IT employees.");

//List<Employee> emps2 = db.Query<Employee>("select * from employee where department = 'IT' ").ToList();

//foreach (Employee emp in emps2)
//{
//    Console.WriteLine(emp);
//}


List<Department> deps = db.GetAll<Department>().ToList();

foreach (Department dep in deps)
{
    Console.WriteLine(dep);
}

Console.WriteLine();
Console.WriteLine();

Department d1 = db.Get<Department>("ACCT");
Console.WriteLine(d1);

Console.WriteLine();
Console.WriteLine();

//Department d2 = new Department() { id = "EGR", name = "Engineering", location = "Detroit" };
//db.Insert(d2);

//deps = db.GetAll<Department>().ToList();

//foreach (Department dep in deps)
//{
//    Console.WriteLine(dep);
//}

//Console.WriteLine();
//Console.WriteLine();

//db.Delete(new Department() { id = "EGR" });

//deps = db.GetAll<Department>().ToList();

//foreach (Department dep in deps)
//{
//    Console.WriteLine(dep);
//}

Department dep2 = db.Get<Department>("ACCT");
dep2.location = "Miami";

Console.WriteLine(dep2);