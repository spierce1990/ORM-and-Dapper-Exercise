using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace ORM_Dapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            string connString = config.GetConnectionString("DefaultConnection");
            IDbConnection conn = new MySqlConnection(connString);

            var DepartmentRepo = new DapperDepartmentRepository(conn); //Create instance with costum constructor

            DepartmentRepo.InsertDepartment("Fun Department");  //use instance to call method
            var allDepartment = DepartmentRepo.GetAllDepartments(); //iterate through collection

            foreach (var item in allDepartment)
            {
                Console.WriteLine($"Department name: { item.Name}");
                Console.WriteLine($"Department ID: { item.DepartmentID}");
            }

            var ProductsRepo = new DapperProductRepository(conn);

            var allProducts = ProductsRepo.GetAllProducts();

            foreach (var item in allProducts)
            {
                Console.WriteLine($"Products name: {item.Name}");
            }


        }
    }
}
