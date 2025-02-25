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
    public partial class ViewRecipe : Form
    {
        
        public ViewRecipe()
        {
            InitializeComponent();

            LoadMenuItems();
        }
        SqlConnection connection = DatabaseConnection.GetConnection();

        private void LoadMenuItems()
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT food_name FROM menu", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    selectRecipeItem.Items.Add(reader["food_name"].ToString());
                }

                connection.Close();
            }
        }

        private void btnViewRecipe_Click(object sender, EventArgs e)
        {
            try
            {
                // ComboBox'tan seçilen yemeği al
                if (selectRecipeItem.SelectedItem == null)
                {
                    MessageBox.Show("Please choose a food.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedFood = selectRecipeItem.SelectedItem.ToString();

                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    // SQL sorgusunu tanımla
                    SqlCommand cmd = new SqlCommand(@"
                SELECT 
                    m.food_name AS [Food Name],
                    i.inventory_name AS [Ingredient],
                    ri.recipe_quantity AS [Quantity],
                    ri.recipe_unit AS [Unit]
                FROM 
                    menu m
                LEFT JOIN 
                    recipe r ON m.menu_id = r.menu_id
                LEFT JOIN 
                    recipe_ingredient ri ON r.recipe_id = ri.recipe_id
                LEFT JOIN 
                    inventory i ON ri.inventory_id = i.inventory_id
                WHERE 
                    m.food_name = @SelectedFoodName", connection);

                    // Parametre ekle
                    cmd.Parameters.AddWithValue("@SelectedFoodName", selectedFood);

                    // Verileri DataTable'a yükle
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable recipeTable = new DataTable();
                    adapter.Fill(recipeTable);

                    // DataGridView'e veri bağla
                    if (recipeTable.Rows.Count > 0)
                    {
                        recipeDataGridView.DataSource = recipeTable;
                    }
                    else
                    {
                        MessageBox.Show("No recipe found for this dish.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        recipeDataGridView.DataSource = null; // Veri yoksa DataGridView'i temizle
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void buttonLogOut_Click_1(object sender, EventArgs e)
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
