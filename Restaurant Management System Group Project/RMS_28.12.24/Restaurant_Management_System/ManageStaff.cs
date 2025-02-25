using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class ManageStaff : Form
    {
      
        public ManageStaff()
        {
            InitializeComponent();
            LoadRoles();
            LoadStaffData();
            LoadUsernames();
        }
        SqlConnection connection = DatabaseConnection.GetConnection();
        private void LoadRoles()
        {
            comboRole.Items.Add("owner");
            comboRole.Items.Add("chef");
            comboRole.Items.Add("cashier");
            comboRole.Items.Add("waiter");
        }
        private void LoadStaffData()
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT username, password_hash, role, salary FROM users";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable staffTable = new DataTable();
                    adapter.Fill(staffTable);

                    dataStaffView.DataSource = staffTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void LoadUsernames()
        {
            try
            {
                comboUsername.Items.Clear();

                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT username FROM users";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            comboUsername.Items.Add(reader["username"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading usernames: " + ex.Message);
            }
        }

        private void buttonAddStaff_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string passwordHash = textPassword.Text;
            string role = comboRole.SelectedItem?.ToString();
            decimal salary;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(passwordHash) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Make sure you fill in all fields.");
                return;
            }

            if (!decimal.TryParse(textSalary.Text, out salary))
            {
                MessageBox.Show("The salary field must be a valid number.");
                return;
            }

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = "INSERT INTO users (username, password_hash, role, salary) VALUES (@username, @passwordHash, @role, @salary)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@passwordHash", passwordHash);
                        command.Parameters.AddWithValue("@role", role);
                        command.Parameters.AddWithValue("@salary", salary);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff added successfully.");
                            ClearFields();
                            LoadStaffData();
                            LoadUsernames();
                        }
                        else
                        {
                            MessageBox.Show("Adding staff failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void buttonRemoveStaff_Click(object sender, EventArgs e)
        {
            string username = comboUsername.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("You must select a username to delete.");
                return;
            }

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = "DELETE FROM users WHERE username = @username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("The employee was deleted successfully.");
                            LoadStaffData();
                            LoadUsernames();
                        }
                        else
                        {
                            MessageBox.Show("Employee deletion failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            textUsername.Clear();
            textPassword.Clear();
            textSalary.Clear();
            comboRole.SelectedIndex = -1;
        }

        private void dataStaffView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // İstenirse burada tıklanan hücreye göre bir işlem eklenebilir.
        }
        private void ManageMenu_Click(object sender, EventArgs e)
        {
            ManageMenuForm manageMenu = new ManageMenuForm();
            manageMenu.Show();
            this.Hide();
        }

        private void StockManage_Click(object sender, EventArgs e)
        {
            ManageStockForm manageStock = new ManageStockForm();
            manageStock.Show();
            this.Hide();
        }

        private void ViewRevenue_Click(object sender, EventArgs e)
        {
            RevenueForm revenueform = new RevenueForm();
            revenueform.Show();
            this.Hide();
        }
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during exit: " + ex.Message);
            }
        }
    }
}
