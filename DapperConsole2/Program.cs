using Dapper;
using Dapper.Contrib.Extensions;
using DapperConsole2;
using MySql.Data.MySqlClient;

var db = new MySqlConnection("Server=127.0.0.1;Database=grocerystore;Uid=root;Pwd=abc123;");

List<Category> c1 = db.GetAll<Category>().ToList();
foreach (Category cat in c1)
{
    Console.WriteLine(cat);
}

Console.WriteLine();
Console.WriteLine();

List<Product> p1 = db.GetAll<Product>().ToList();
foreach (Product prod in p1)
{
    Console.WriteLine(prod);
}