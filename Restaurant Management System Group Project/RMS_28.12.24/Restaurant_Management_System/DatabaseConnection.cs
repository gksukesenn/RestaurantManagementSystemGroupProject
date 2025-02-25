using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System
{
    // DatabaseConnection.cs
    public static class DatabaseConnection
    {
        // Burada bağlantı cümlenizi tutuyoruz
        public static string ConnectionString { get; } = "Data Source=GÖKSUKESEN\\SQLEXPRESS;Initial Catalog=RestaurantManagementProject;Integrated Security=True;TrustServerCertificate=True";

        // Bağlantıyı almak için statik bir metod ekliyoruz
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }

}
