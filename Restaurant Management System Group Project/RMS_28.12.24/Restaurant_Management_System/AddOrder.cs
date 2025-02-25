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
    public partial class AddOrder : Form
    {
        private int _userId;
        public AddOrder(int userId)
        {
            InitializeComponent();
            LoadTableNumbers();
            LoadMenuItems();
            _userId = userId;
        }

        SqlConnection connection = DatabaseConnection.GetConnection();
        private void LoadTableNumbers()
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT table_number FROM tables";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        TableNumber.Items.Add(reader["table_number"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading table numbers: " + ex.Message);
                }
            }
        }

        private void TableNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedTableNumber = int.Parse(TableNumber.SelectedItem.ToString());
            LoadMenuItems();
        }

        private void LoadMenuItems()
        {
            ChooseMenuItem.Items.Clear(); // Daha önceki menü seçeneklerini temizle

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT food_name FROM AvailableMenuItems";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ChooseMenuItem.Items.Add(reader["food_name"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading menu items: " + ex.Message);
                }
            }
        }

        private void UpdateTableStatusProcedure(int tableNumber)
        {
            try
            {
                // SQL bağlantısını oluştur
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    // Stored Procedure çağrısını oluştur
                    using (SqlCommand cmd = new SqlCommand("UpdateTableStatus", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Prosedür parametresini ekle
                        cmd.Parameters.AddWithValue("@TableNumber", tableNumber);

                        // Bağlantıyı aç ve prosedürü çalıştır
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        //MessageBox.Show($"Masa {tableNumber} durumu başarıyla güncellendi: Masa artık dolu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddOrder2_Click(object sender, EventArgs e)
        {
            if (TableNumber.SelectedItem == null || ChooseMenuItem.SelectedItem == null || numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Please select a table, menu item, and enter a valid quantity.");
                return;
            }

            int tableNumber = int.Parse(TableNumber.SelectedItem.ToString());
            string foodName = ChooseMenuItem.SelectedItem.ToString();
            int quantity = (int)numericUpDown1.Value;

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string getMenuIdQuery = "SELECT menu_id FROM menu WHERE food_name = @foodName";
                SqlCommand getMenuIdCommand = new SqlCommand(getMenuIdQuery, connection);
                getMenuIdCommand.Parameters.AddWithValue("@foodName", foodName);

                try
                {
                    connection.Open();

                    int menuId = (int)getMenuIdCommand.ExecuteScalar();

                    // UpdateBestMenuItem prosedürünü çağır
                    using (SqlCommand cmd = new SqlCommand("UpdateBestMenuItem", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@selected_menu_item", menuId);
                        cmd.Parameters.AddWithValue("@total_order_quantity", quantity);

                        cmd.ExecuteNonQuery();
                    }

                    string insertOrderQuery = @"INSERT INTO orders (table_number, selected_menu_item, total_order_quantity, order_user_id) 
                                        VALUES (@tableNumber, @menuId, @quantity, @userId)";

                    SqlCommand insertOrderCommand = new SqlCommand(insertOrderQuery, connection);
                    insertOrderCommand.Parameters.AddWithValue("@tableNumber", tableNumber);
                    insertOrderCommand.Parameters.AddWithValue("@menuId", menuId);
                    insertOrderCommand.Parameters.AddWithValue("@quantity", quantity);
                    insertOrderCommand.Parameters.AddWithValue("@userId", _userId); // Kullanıcı kimliği

                    int rowsAffected = insertOrderCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        AddCashRegisterEntry(tableNumber);
                        // ComboBox'tan seçilen değeri al
                        if (TableNumber.SelectedItem != null)
                        {
                            int selectedTableNumber = int.Parse(TableNumber.SelectedItem.ToString());
                            UpdateTableStatusProcedure(selectedTableNumber);

                            MessageBox.Show("Order added successfully.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to add order.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding order: " + ex.Message);
                }
            }
        }

        private void AddCashRegisterEntry(int tableNumber)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("AddCashRegisterEntry", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TableNumber", tableNumber);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        //MessageBox.Show($"Cash register entry added for table {tableNumber}.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding cash register entry: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AddOrder addOrder = new AddOrder(_userId);
            addOrder.Show();
            this.Hide();
        }

        private void btnViewMenu_Click(object sender, EventArgs e)
        {
            ViewMenu viewMenu = new ViewMenu(_userId);
            viewMenu.Show();
            this.Hide();
        }

        private void OrderStatus_Click(object sender, EventArgs e)
        {
            ChangeOrderStatus orderStatus = new ChangeOrderStatus(_userId);
            orderStatus.Show();
            this.Hide();
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
    }
}
