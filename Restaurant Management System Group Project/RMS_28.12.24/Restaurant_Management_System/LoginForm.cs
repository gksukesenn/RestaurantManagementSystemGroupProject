using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Restaurant_Management_System
{
    public partial class LoginForm : Form
    {

        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;


        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection connection = DatabaseConnection.GetConnection();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUserName.Text;
            string password = txtPassword.Text;

            // Veritabanı bağlantısı
            
            com = new SqlCommand();

            try
            {
                connection.Open();
                com.Connection = connection;

                // SQL sorgusu (Parametreli sorgu kullanımı SQL Injection'ı önler)
                com.CommandText = "SELECT user_id, role FROM users WHERE username = @username AND password_hash = @password";
                com.Parameters.AddWithValue("@username", user);
                com.Parameters.AddWithValue("@password", password);

                dr = com.ExecuteReader();

                if (dr.Read()) // Eğer kullanıcı bulunduysa
                {
                    int userId = (int)dr["user_id"];     // Kullanıcının user_id'sini al
                    string role = dr["role"].ToString(); // Kullanıcının rolünü al

                    // Rolüne göre forma yönlendirme
                    switch (role)
                    {
                        case "owner":
                            OwnerForm ownerForm = new OwnerForm();
                            ownerForm.Show();
                            break;
                        case "cashier":
                            CashierForm1 cashierForm = new CashierForm1();
                            cashierForm.Show();
                            break;
                        case "chef":
                            ChefForm chefForm = new ChefForm();
                            chefForm.Show();
                            break;
                        case "waiter":
                            WaiterForm waiterForm = new WaiterForm(userId);
                            waiterForm.Show();
                            break;
                        default:
                            MessageBox.Show("Role is not defined properly.");
                            break;
                    }

                    this.Hide(); // Giriş formunu gizle
                }
                else
                {
                    MessageBox.Show("Wrong username or password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }


    }
}
