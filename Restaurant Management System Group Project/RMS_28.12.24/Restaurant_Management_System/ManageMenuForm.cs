using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurant_Management_System
{
    public partial class ManageMenuForm : Form
    {

        public ManageMenuForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadFoodNamesIntoComboBox();
            LoadRecipeFoodIntoComboBox();
            this.Load += new System.EventHandler(this.AddMenuItemForm_Load);
        }

        SqlConnection connection = DatabaseConnection.GetConnection();


        private void AddMenuItemForm_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void InitializeDatabaseConnection()
        {
            
        }

        private void LoadMenuDataIntoGridView()
        {
            try
            {
                connection.Open();
                string query = "SELECT food_name, price FROM menu";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // DataGridView'e veriyi bağla
                dataGridViewFood.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading menu data: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            // UI bileşenini yeniden çiz
            dataGridViewFood.Refresh();
        
        }

        private void LoadIngredientsForRecipe(int recipeId)
        {
            // Bağlantı durumunu kontrol et
            if (connection.State == ConnectionState.Open)
            {
                connection.Close(); // Eğer bağlantı açıksa, kapat
            }

            try
            {
                connection.Open();

                // recipe_id'ye karşılık gelen malzemeleri al
                string query = @"
        SELECT 
            i.inventory_name AS 'Ingredient Name',
            ri.recipe_quantity AS 'Quantity',
            ri.recipe_unit AS 'Unit'
        FROM 
            recipe_ingredient ri
        INNER JOIN 
            inventory i ON ri.inventory_id = i.inventory_id
        WHERE 
            ri.recipe_id = @recipeId";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@recipeId", recipeId);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // DataGridView'e veriyi bağla
                dataGridViewFood.DataSource = dataTable;

                // Otomatik sütun genişliği
                dataGridViewFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ingredients: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close(); // Bağlantıyı kapat
                }
            }
        }

        private void LoadRecipeFoodIntoComboBox()
        {
            try
            {
                connection.Open();
                string query = "SELECT food_name FROM menu";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                selectRecipeFood.Items.Clear();
                while (reader.Read())
                {
                    selectRecipeFood.Items.Add(reader["food_name"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading recipe food: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadFoodNamesIntoComboBox()
        {
            try
            {
                connection.Open();
                string query = "SELECT food_name FROM menu";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                comboSelectFood.Items.Clear();
                comboSelectFood.MaxDropDownItems = 6; // Maksimum 6 öğe göster

                while (reader.Read())
                {
                    comboSelectFood.Items.Add(reader["food_name"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading food names: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void RefreshForm()
        {
            try
            {
                // Menu verilerini ComboBox'a ve DataGridView'e yükle
                LoadFoodNamesIntoComboBox();
                LoadMenuDataIntoGridView();
                

                // DataGridView tasarımı için otomatik sütun genişliği
                dataGridViewFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Sütun başlıklarını güncelle
                if (dataGridViewFood.Columns["food_name"] != null)
                    dataGridViewFood.Columns["food_name"].HeaderText = "Food Name";

                if (dataGridViewFood.Columns["price"] != null)
                    dataGridViewFood.Columns["price"].HeaderText = "Price";

                // Metin kutularını temizle
                textFood.Clear();
                textPrice.Clear();

                // ComboBox seçim durumu sıfırla
                comboSelectFood.SelectedIndex = -1;

                // UI bileşenlerini yeniden çiz
                comboSelectFood.Refresh();
                dataGridViewFood.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing form: " + ex.Message);
            }
        }

        private void textPrice_TextChanged(object sender, EventArgs e)
        {
            // Price sadece sayı kabul edecek şekilde kontrol ekleniyor.
            foreach (char c in textPrice.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("The price must consist of numbers only.");
                    textPrice.Text = string.Empty;
                    return;
                }
            }
        }
        private void menuAdd_Click(object sender, EventArgs e)
        {
            string foodName = textFood.Text;
            if (!int.TryParse(textPrice.Text, out int price))
            {
                MessageBox.Show("Geçerli bir fiyat girin.");
                return;
            }

            if (string.IsNullOrEmpty(foodName))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            string insertMenuQuery = "INSERT INTO menu (food_name, price) VALUES (@foodName, @price)";
            string getMenuIdQuery = "SELECT menu_id FROM menu WHERE food_name = @foodName";
            string insertRecipeQuery = "INSERT INTO recipe (menu_id) VALUES (@menuId)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connection.ConnectionString))
                {
                    conn.Open();

                    // Menü tablosuna yeni yiyecek ekle
                    using (SqlCommand insertMenuCommand = new SqlCommand(insertMenuQuery, conn))
                    {
                        insertMenuCommand.Parameters.AddWithValue("@foodName", foodName);
                        insertMenuCommand.Parameters.AddWithValue("@price", price);

                        insertMenuCommand.ExecuteNonQuery();
                        MessageBox.Show("Food has been added successfully.");
                    }

                    // Yeni eklenen yiyeceğin menu_id'sini al
                    int menuId;
                    using (SqlCommand getMenuIdCommand = new SqlCommand(getMenuIdQuery, conn))
                    {
                        getMenuIdCommand.Parameters.AddWithValue("@foodName", foodName);
                        menuId = (int)getMenuIdCommand.ExecuteScalar();
                    }

                    // Recipe tablosuna bu menu_id'yi ekle
                    using (SqlCommand insertRecipeCommand = new SqlCommand(insertRecipeQuery, conn))
                    {
                        insertRecipeCommand.Parameters.AddWithValue("@menuId", menuId);
                        insertRecipeCommand.ExecuteNonQuery();
                        MessageBox.Show("Successfully added menu_id to Recipe table.");
                    }
                }

                // Formu yenile
                RefreshForm();
                LoadRecipeFoodIntoComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding food or updating recipe: " + ex.Message);
            }
        }
        private void buttonRemoveMenu_Click(object sender, EventArgs e)
        {
            if (comboSelectFood.SelectedItem == null)
            {
                MessageBox.Show("Please select a food to delete.");
                return;
            }

            string selectedFood = comboSelectFood.SelectedItem.ToString();

            // Menüden bağlı tüm tarif ve içerikleri silmek için sorgular
            string deleteRecipeIngredientsQuery = @"
        DELETE FROM recipe_ingredient 
        WHERE recipe_id IN (
            SELECT recipe_id 
            FROM recipe 
            WHERE menu_id = (
                SELECT menu_id 
                FROM menu 
                WHERE food_name = @foodName
            )
        )";

            string deleteRecipesQuery = @"
        DELETE FROM recipe 
        WHERE menu_id = (
            SELECT menu_id 
            FROM menu 
            WHERE food_name = @foodName
        )";

            string deleteMenuQuery = @"
        DELETE FROM menu 
        WHERE food_name = @foodName";

            try
            {
                using (SqlConnection conn = new SqlConnection(connection.ConnectionString))
                {
                    conn.Open();

                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Recipe_ingredient tablosundan sil
                            using (SqlCommand command = new SqlCommand(deleteRecipeIngredientsQuery, conn, transaction))
                            {
                                command.Parameters.AddWithValue("@foodName", selectedFood);
                                command.ExecuteNonQuery();
                            }

                            // Recipe tablosundan sil
                            using (SqlCommand command = new SqlCommand(deleteRecipesQuery, conn, transaction))
                            {
                                command.Parameters.AddWithValue("@foodName", selectedFood);
                                command.ExecuteNonQuery();
                            }

                            // Menu tablosundan sil
                            using (SqlCommand command = new SqlCommand(deleteMenuQuery, conn, transaction))
                            {
                                command.Parameters.AddWithValue("@foodName", selectedFood);
                                command.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Food and related recipes have been deleted successfully.");
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }

                // Formu yenile
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing food: " + ex.Message);
            }
        }


        private void selectRecipeFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshForm();
            if (selectRecipeFood.SelectedItem == null) return;

            string selectedFoodName = selectRecipeFood.SelectedItem.ToString();

            try
            {
                connection.Open();

                // Seçilen food_name'e karşılık gelen menu_id'yi al
                string getMenuIdQuery = "SELECT menu_id FROM menu WHERE food_name = @foodName";
                SqlCommand getMenuIdCommand = new SqlCommand(getMenuIdQuery, connection);
                getMenuIdCommand.Parameters.AddWithValue("@foodName", selectedFoodName);
                int menuId = (int)getMenuIdCommand.ExecuteScalar();

                // menu_id'ye karşılık gelen recipe_id'yi al
                string getRecipeIdQuery = "SELECT recipe_id FROM recipe WHERE menu_id = @menuId";
                SqlCommand getRecipeIdCommand = new SqlCommand(getRecipeIdQuery, connection);
                getRecipeIdCommand.Parameters.AddWithValue("@menuId", menuId);
                int recipeId = (int)getRecipeIdCommand.ExecuteScalar();

                // Tüm inventory_name değerlerini yükle
                string getInventoryQuery = "SELECT inventory_name FROM inventory";
                SqlCommand getInventoryCommand = new SqlCommand(getInventoryQuery, connection);
                SqlDataReader reader = getInventoryCommand.ExecuteReader();

                selectRecipeItem.Items.Clear();
                while (reader.Read())
                {
                    selectRecipeItem.Items.Add(reader["inventory_name"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory items: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void selectRecipeItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void recipeAdd_Click(object sender, EventArgs e)
        {
            if (selectRecipeFood.SelectedItem == null || selectRecipeItem.SelectedItem == null || string.IsNullOrEmpty(textQuantity.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string selectedFoodName = selectRecipeFood.SelectedItem.ToString();
            string selectedInventoryName = selectRecipeItem.SelectedItem.ToString();

            if (!float.TryParse(textQuantity.Text, out float quantity))
            {
                MessageBox.Show("Enter a valid amount.");
                return;
            }

            try
            {
                connection.Open();

                // Seçilen food_name'e karşılık gelen menu_id'yi al
                string getMenuIdQuery = "SELECT menu_id FROM menu WHERE food_name = @foodName";
                SqlCommand getMenuIdCommand = new SqlCommand(getMenuIdQuery, connection);
                getMenuIdCommand.Parameters.AddWithValue("@foodName", selectedFoodName);
                object menuIdResult = getMenuIdCommand.ExecuteScalar();

                if (menuIdResult == null)
                {
                    MessageBox.Show("The selected meal could not be found.");
                    return;
                }

                int menuId = (int)menuIdResult;

                // menu_id'ye karşılık gelen recipe_id'yi al
                string getRecipeIdQuery = "SELECT recipe_id FROM recipe WHERE menu_id = @menuId";
                SqlCommand getRecipeIdCommand = new SqlCommand(getRecipeIdQuery, connection);
                getRecipeIdCommand.Parameters.AddWithValue("@menuId", menuId);
                object recipeIdResult = getRecipeIdCommand.ExecuteScalar();

                if (recipeIdResult == null)
                {
                    MessageBox.Show("The selected recipe could not be found.");
                    return;
                }

                int recipeId = (int)recipeIdResult;

                // Seçilen inventory_name'e karşılık gelen inventory_id ve inventory_unit'i al
                string getInventoryDataQuery = "SELECT inventory_id, inventory_unit FROM inventory WHERE inventory_name = @inventoryName";
                SqlCommand getInventoryDataCommand = new SqlCommand(getInventoryDataQuery, connection);
                getInventoryDataCommand.Parameters.AddWithValue("@inventoryName", selectedInventoryName);

                SqlDataReader reader = getInventoryDataCommand.ExecuteReader();
                if (!reader.Read())
                {
                    MessageBox.Show("The selected material could not be found.");
                    reader.Close();
                    return;
                }

                int inventoryId = (int)reader["inventory_id"];
                string inventoryUnit = reader["inventory_unit"].ToString();
                reader.Close();

                // Seçilen recipe_id ve inventory_id'nin recipe_unit'i kontrol et
                string checkUnitQuery = "SELECT recipe_unit FROM recipe_ingredient WHERE recipe_id = @recipeId AND inventory_id = @inventoryId";
                SqlCommand checkUnitCommand = new SqlCommand(checkUnitQuery, connection);
                checkUnitCommand.Parameters.AddWithValue("@recipeId", recipeId);
                checkUnitCommand.Parameters.AddWithValue("@inventoryId", inventoryId);

                object recipeUnitResult = checkUnitCommand.ExecuteScalar();
                string recipeUnit = recipeUnitResult?.ToString();

                if (recipeUnit != null && recipeUnit != inventoryUnit)
                {
                    MessageBox.Show("The unit of the selected ingredient does not match the recipe.");
                    return;
                }

                // recipe_ingredient tablosunda recipe_quantity'yi güncelle
                string updateRecipeQuantityQuery = @"
        UPDATE recipe_ingredient
        SET recipe_quantity = recipe_quantity + @quantity, recipe_unit = @unit
        WHERE recipe_id = @recipeId AND inventory_id = @inventoryId";
                SqlCommand updateRecipeQuantityCommand = new SqlCommand(updateRecipeQuantityQuery, connection);
                updateRecipeQuantityCommand.Parameters.AddWithValue("@quantity", quantity);
                updateRecipeQuantityCommand.Parameters.AddWithValue("@unit", inventoryUnit);
                updateRecipeQuantityCommand.Parameters.AddWithValue("@recipeId", recipeId);
                updateRecipeQuantityCommand.Parameters.AddWithValue("@inventoryId", inventoryId);

                int rowsAffected = updateRecipeQuantityCommand.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    // Eğer satır yoksa yeni bir satır ekle
                    string insertRecipeIngredientQuery = @"
            INSERT INTO recipe_ingredient (recipe_id, inventory_id, recipe_quantity, recipe_unit)
            VALUES (@recipeId, @inventoryId, @quantity, @unit)";
                    SqlCommand insertRecipeIngredientCommand = new SqlCommand(insertRecipeIngredientQuery, connection);
                    insertRecipeIngredientCommand.Parameters.AddWithValue("@recipeId", recipeId);
                    insertRecipeIngredientCommand.Parameters.AddWithValue("@inventoryId", inventoryId);
                    insertRecipeIngredientCommand.Parameters.AddWithValue("@quantity", quantity);
                    insertRecipeIngredientCommand.Parameters.AddWithValue("@unit", inventoryUnit);

                    insertRecipeIngredientCommand.ExecuteNonQuery();
                }

                MessageBox.Show("The recipe has been updated successfully.");

                if (recipeId <= 0)
                {
                    MessageBox.Show("Invalid recipe ID.");
                    return;
                }

                // Malzemeleri dataGridViewFood'da göstermek için LoadIngredientsForRecipe çağrısı
                LoadIngredientsForRecipe(recipeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the recipe: " + ex.Message);
            }
            finally
            {
                connection.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            ManageStaff managestaff = new ManageStaff();
            managestaff.Show();
            this.Hide();
        }

        private void ManageMenu_Click(object sender, EventArgs e)
        {
            ManageMenuForm addmenu = new ManageMenuForm();
            addmenu.Show();
            this.Hide();
        }

        private void ViewRevenue_Click(object sender, EventArgs e)
        {
            RevenueForm revenueform = new RevenueForm();
            revenueform.Show();
            this.Hide();
        }
        private void StockManage_Click(object sender, EventArgs e)
        {
            ManageStockForm managestock = new ManageStockForm();
            managestock.Show();
            this.Hide();
        }

    }
}


