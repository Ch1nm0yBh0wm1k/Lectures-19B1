using CRUDUsingQuery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;


namespace CRUDUsingQuery.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IConfiguration _configuration;
        public CustomerController(IConfiguration configuration)
        {

            _configuration = configuration; 

        }

        //public IActionResult Index()
        //{
        //    List<Customer> cust = new List<Customer>();


        //    var conString = "Server=localhost;Database=19B2;Trusted_Connection=True;MultipleActiveResultSets=true";

        //    using (SqlConnection conn = new SqlConnection(conString))
        //    {
        //        string query = "select * from mis_Customer";

        //        SqlCommand cmd = new SqlCommand(query, conn);

        //        conn.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            cust.Add(new Customer
        //            {
        //                Id = (int)reader["Id"],
        //                Name = (string)reader["Name"],
        //                Email = (string)reader["Email"],
        //                Address = (string)reader["Address"],

        //            });
        //        }
        //    }

        //    return View(cust);
        //}

        public IActionResult Index()
        {
            List<Customer> cust = new List<Customer>();


            var conString = _configuration.GetConnectionString("DefaultConnection");

            using (SqlConnection conn = new SqlConnection(conString))
            {
                

                SqlCommand cmd = new SqlCommand("sp_GetCustomerDetails", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cust.Add(new Customer
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        Email = (string)reader["Email"],
                        Address = (string)reader["Address"],

                    });
                }
            }

            return View(cust);
        }
        [HttpPost]
        public IActionResult Create(Customer cust)
        {
            var conString = "Server=localhost;Database=19B2;Trusted_Connection=True;MultipleActiveResultSets=true";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                //string query = "INSERT INTO mis_Customer (Name, Email, Address) VALUES (@Param1, @Param2,@Param3)";
                SqlCommand cmd = new SqlCommand("sp_InsertCustomer", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Param1", cust.Name);
                cmd.Parameters.AddWithValue("@Param2", cust.Email);
                cmd.Parameters.AddWithValue("@Param3", cust.Address);

                conn.Open();

                cmd.ExecuteNonQuery();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
