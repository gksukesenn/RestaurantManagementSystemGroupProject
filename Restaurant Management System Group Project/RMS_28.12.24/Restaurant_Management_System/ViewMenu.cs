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
    public partial class ViewMenu : Form
    {
        private int _userId;
        public ViewMenu(int userId)
        {
            InitializeComponent();
            loadMenu();
            _userId = userId;
        }

        SqlConnection connection = DatabaseConnection.GetConnection();

        private void loadMenu()
        {
            // Temizleme (FlowLayoutPanel içini boşaltır)
            flowLayoutPanel1.Controls.Clear();

            // Veritabanı bağlantısı
           
            string query = "SELECT food_name, price FROM AvailableMenuItems";

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Veritabanından değerleri al
                                string foodName = reader["food_name"].ToString();
                                string price = reader["price"].ToString();

                                // Yeni bir panel oluştur
                                Panel menuItemPanel = new Panel
                                {
                                    Width = flowLayoutPanel1.ClientSize.Width - 25,
                                    Height = 30,
                                    BorderStyle = BorderStyle.FixedSingle,
                                    Padding = new Padding(5),
                                    Margin = new Padding(5),
                                    AutoScroll = true
                                };

                                // Yemek adı için bir etiket
                                Label lblFoodName = new Label
                                {
                                    Text = foodName,
                                    AutoSize = true,
                                    Dock = DockStyle.Left,
                                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                                    Padding = new Padding(5)
                                };

                                // Fiyat için bir etiket
                                Label lblPrice = new Label
                                {
                                    Text = "₺" + price,
                                    AutoSize = true,
                                    Dock = DockStyle.Right,
                                    TextAlign = System.Drawing.ContentAlignment.MiddleRight,
                                    Padding = new Padding(5)
                                };

                                // Panel içine etiketleri ekle
                                menuItemPanel.Controls.Add(lblFoodName);
                                menuItemPanel.Controls.Add(lblPrice);

                                // FlowLayoutPanel'e ekle
                                flowLayoutPanel1.Controls.Add(menuItemPanel);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AddOrder addOrder = new AddOrder(_userId);
            addOrder.Show();
            this.Hide();
        }

        private void OrderStatus1_Click(object sender, EventArgs e)
        {
            ChangeOrderStatus orderStatus = new ChangeOrderStatus(_userId);
            orderStatus.Show();
            this.Hide();
        }

        private void btnViewMenu1_Click(object sender, EventArgs e)
        {
            ViewMenu viewMenu = new ViewMenu(_userId);
            viewMenu.Show();
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
