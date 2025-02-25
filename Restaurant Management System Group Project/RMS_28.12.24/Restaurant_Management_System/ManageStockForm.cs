using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class ManageStockForm : Form
    {
        
        public ManageStockForm()
        {
            InitializeComponent();
            LoadInventoryData();
            PopulateComboBox();
            PopulateComboBox2();
        }

        SqlConnection connection = DatabaseConnection.GetConnection();

        private void LoadInventoryData()
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT inventory_name, stock_quantity, inventory_unit, inventory_price FROM dbo.inventory";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataStockView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory data: " + ex.Message);
            }
        }

        private void PopulateComboBox()
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT inventory_name FROM dbo.inventory";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    comboFoodName.Items.Clear();
                    while (reader.Read())
                    {
                        comboFoodName.Items.Add(reader["inventory_name"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating food names: " + ex.Message);
            }
        }

        private void buttonIncrease_Click(object sender, EventArgs e)
        {
            UpdateStockQuantity(1);
        }

        private void buttonDecrease_Click(object sender, EventArgs e)
        {
            UpdateStockQuantity(-1);
        }

        private void UpdateStockQuantity(int multiplier)
        {
            if (comboFoodName.SelectedItem == null || string.IsNullOrWhiteSpace(textAmount.Text))
            {
                MessageBox.Show("Please select a food item and enter a valid amount.");
                return;
            }

            if (!int.TryParse(textAmount.Text, out int amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for the amount.");
                return;
            }

            bool isPriceProvided = !string.IsNullOrWhiteSpace(PricePerUnitTxtBox.Text);
            decimal pricePerUnit = 0;

            if (isPriceProvided)
            {
                if (!decimal.TryParse(PricePerUnitTxtBox.Text, out pricePerUnit) || pricePerUnit <= 0)
                {
                    MessageBox.Show("Please enter a valid positive number for the price per unit, or leave it empty.");
                    return;
                }
            }

            bool isUnitProvided = !string.IsNullOrWhiteSpace(InventoryUnitTxtBox.Text);
            string inventoryUnit = isUnitProvided ? InventoryUnitTxtBox.Text : null;

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    string query;
                    SqlCommand command = new SqlCommand();

                    if (isPriceProvided && isUnitProvided)
                    {
                        query = @"UPDATE dbo.inventory 
                          SET stock_quantity = stock_quantity + @Amount, 
                              inventory_price = @PricePerUnit, 
                              inventory_unit = @InventoryUnit 
                          WHERE inventory_name = @InventoryName";
                        command.Parameters.AddWithValue("@PricePerUnit", pricePerUnit);
                        command.Parameters.AddWithValue("@InventoryUnit", inventoryUnit);
                    }
                    else if (isPriceProvided)
                    {
                        query = @"UPDATE dbo.inventory 
                          SET stock_quantity = stock_quantity + @Amount, 
                              inventory_price = @PricePerUnit 
                          WHERE inventory_name = @InventoryName";
                        command.Parameters.AddWithValue("@PricePerUnit", pricePerUnit);
                    }
                    else if (isUnitProvided)
                    {
                        query = @"UPDATE dbo.inventory 
                          SET stock_quantity = stock_quantity + @Amount, 
                              inventory_unit = @InventoryUnit 
                          WHERE inventory_name = @InventoryName";
                        command.Parameters.AddWithValue("@InventoryUnit", inventoryUnit);
                    }
                    else
                    {
                        query = @"UPDATE dbo.inventory 
                          SET stock_quantity = stock_quantity + @Amount 
                          WHERE inventory_name = @InventoryName";
                    }

                    command.CommandText = query;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@Amount", amount * multiplier);
                    command.Parameters.AddWithValue("@InventoryName", comboFoodName.SelectedItem.ToString());

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Stock quantity, price, and unit updated successfully.");
                        LoadInventoryData();
                    }
                    else
                    {
                        MessageBox.Show("No matching record found to update.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating stock quantity, price, and unit: " + ex.Message);
            }
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
                MessageBox.Show("Error during logout: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageStaff manageStaff = new ManageStaff();
            manageStaff.Show();
            this.Hide();
        }

        private void ManageMenu_Click(object sender, EventArgs e)
        {
            ManageMenuForm manageMenu = new ManageMenuForm();
            manageMenu.Show();
            this.Hide();
        }

        private void dataStockView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bu olay için herhangi bir özel işlem yapılmıyor.
        }

        private void ViewRevenue_Click(object sender, EventArgs e)
        {
            RevenueForm revenueform = new RevenueForm();
            revenueform.Show();
            this.Hide();
        }

        private void AddNewInventoryButton_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan verileri kontrol et
            string inventoryName = InventoryNameTxtBox.Text.Trim();
            string stockQuantityText = StockQuantityTxtBox.Text.Trim();
            string inventoryUnit = InventoryUnitTxtBox2.Text.Trim();
            string pricePerUnitText = PricePerUnitTxtBox2.Text.Trim();

            // Gerekli alanların doluluğunu kontrol et
            if (string.IsNullOrEmpty(inventoryName) || string.IsNullOrEmpty(stockQuantityText) ||
                string.IsNullOrEmpty(inventoryUnit) || string.IsNullOrEmpty(pricePerUnitText))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Miktar ve fiyatın geçerli bir sayı olduğundan emin olun
            if (!int.TryParse(stockQuantityText, out int stockQuantity) || stockQuantity <= 0)
            {
                MessageBox.Show("Please enter a valid stock quantity.");
                return;
            }

            if (!decimal.TryParse(pricePerUnitText, out decimal pricePerUnit) || pricePerUnit <= 0)
            {
                MessageBox.Show("Please enter a valid unit price.");
                return;
            }

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    // Veritabanına ekleme sorgusu
                    string query = @"INSERT INTO dbo.inventory 
                             (inventory_name, stock_quantity, inventory_unit, inventory_price)
                             VALUES (@InventoryName, @StockQuantity, @InventoryUnit, @PricePerUnit)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@InventoryName", inventoryName);
                    command.Parameters.AddWithValue("@StockQuantity", stockQuantity);
                    command.Parameters.AddWithValue("@InventoryUnit", inventoryUnit);
                    command.Parameters.AddWithValue("@PricePerUnit", pricePerUnit);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("New inventory item added successfully.");
                        InventoryNameTxtBox.Clear();
                        StockQuantityTxtBox.Clear();
                        InventoryUnitTxtBox2.Clear();
                        PricePerUnitTxtBox2.Clear();
                        LoadInventoryData(); // Tabloyu güncelle
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while adding inventory.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PopulateComboBox2()
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT inventory_name FROM dbo.inventory";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    comboFoodName2.Items.Clear();
                    while (reader.Read())
                    {
                        comboFoodName2.Items.Add(reader["inventory_name"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating food names: " + ex.Message);
            }
        }

        private void RemoveInventoryButton_Click(object sender, EventArgs e)
        {
            // Seçili bir öğe olup olmadığını kontrol et
            if (comboFoodName2.SelectedItem == null)
            {
                MessageBox.Show("Please select an inventory item you want to delete.");
                return;
            }

            // Seçili öğeyi al
            string selectedInventory = comboFoodName2.SelectedItem.ToString();

            // Kullanıcıya emin olup olmadığını sor
            DialogResult confirmation = MessageBox.Show(
                $"Are you sure you want to delete the selected item ({selectedInventory})?", "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmation != DialogResult.Yes)
            {
                return;
            }


            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    // Silme sorgusu
                    string query = "DELETE FROM dbo.inventory WHERE inventory_name = @InventoryName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@InventoryName", selectedInventory);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Inventory item deleted successfully.");
                        LoadInventoryData(); // Tabloyu güncelle
                        PopulateComboBox2(); // ComboBox'u güncelle
                    }
                    else
                    {
                        MessageBox.Show("The selected item could not be deleted. It was not found in the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
