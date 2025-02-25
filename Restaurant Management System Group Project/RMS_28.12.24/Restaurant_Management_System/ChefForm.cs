using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class ChefForm : Form
    {
        public ChefForm()
        {
            InitializeComponent();
            LoadTableNumbers();
        }
        SqlConnection connection = DatabaseConnection.GetConnection();
        private void LoadTableNumbers()
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT DISTINCT table_number FROM dbo.orders";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboTableNumber.Items.Add(reader["table_number"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ChefForm_Load(object sender, EventArgs e)
        {

        }

        private void comboTableNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ComboBox'ta masa numarası seçildiğinde yiyecek listesini yükleyin.
            LoadPendingFoods();
        }

        private void LoadPendingFoods()
        {
            if (comboTableNumber.SelectedItem == null)
                return;

            string selectedTable = comboTableNumber.SelectedItem.ToString();
            comboSelectFood.Items.Clear();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT m.food_name
                             FROM dbo.orders o
                             INNER JOIN dbo.menu m ON o.selected_menu_item = m.menu_id
                             WHERE o.table_number = @TableNumber AND o.order_status = 'pending'";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@TableNumber", selectedTable);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboSelectFood.Items.Add(reader["food_name"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void comboSelectFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (comboTableNumber.SelectedItem == null || comboSelectFood.SelectedItem == null)
            {
                MessageBox.Show("Please choose a table number and food.");
                return;
            }

            string selectedTable = comboTableNumber.SelectedItem.ToString();
            string selectedFood = comboSelectFood.SelectedItem.ToString();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"UPDATE o
                             SET o.order_status = 'in progress'
                             FROM dbo.orders o
                             INNER JOIN dbo.menu m ON o.selected_menu_item = m.menu_id
                             WHERE o.table_number = @TableNumber AND m.food_name = @FoodName AND o.order_status = 'pending'";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@TableNumber", selectedTable);
                    cmd.Parameters.AddWithValue("@FoodName", selectedFood);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order status updated to 'In Progress'.");
                    }
                    else
                    {
                        MessageBox.Show("The update process failed.");
                    }

                    // DataGridView ve ComboBox'ı güncelleyin
                    LoadPendingFoods();
                    UpdateDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void UpdateDataGridView()
        {
            if (comboTableNumber.SelectedItem == null)
                return;

            string selectedTable = comboTableNumber.SelectedItem.ToString();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT 
                                o.table_number AS [Table Number],
                                m.food_name AS [Food],
                                o.total_order_quantity AS [Quantity],
                                o.order_status AS [Status],
                                o.order_date AS [Date]
                             FROM dbo.orders o
                             INNER JOIN dbo.menu m ON o.selected_menu_item = m.menu_id
                             WHERE o.table_number = @TableNumber";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@TableNumber", selectedTable);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    ViewFoodStatus.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ViewFoodStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonShowOrder_Click(object sender, EventArgs e)
        {
            if (comboTableNumber.SelectedItem == null)
            {
                MessageBox.Show("Please select a table number.");
                return;
            }

            string selectedTable = comboTableNumber.SelectedItem.ToString();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT 
                                o.table_number AS [Table Number],
                                m.food_name AS [Food],
                                o.total_order_quantity AS [Quantity],
                                o.order_status AS [Status],
                                o.order_date AS [Date]
                             FROM dbo.orders o
                             INNER JOIN dbo.menu m ON o.selected_menu_item = m.menu_id
                             WHERE o.table_number = @TableNumber";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@TableNumber", selectedTable);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    ViewFoodStatus.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                // Login formunu oluştur ve göster
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                // Mevcut formu gizle
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during logout: " + ex.Message);
            }
        }

        private void ViewOrderBtn_Click(object sender, EventArgs e)
        {
            ChefForm chefForm = new ChefForm();
            chefForm.Show();
            this.Hide();
        }

        private void ViewRecipeBtn_Click(object sender, EventArgs e)
        {
            ViewRecipe viewRecipe = new ViewRecipe();
            viewRecipe.Show();
            this.Hide();
        }
    }
}
