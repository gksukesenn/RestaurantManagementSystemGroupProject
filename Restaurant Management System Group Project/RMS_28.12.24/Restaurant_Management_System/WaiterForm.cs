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
using System.Windows.Forms.DataVisualization.Charting;


namespace Restaurant_Management_System
{
    public partial class WaiterForm : Form
    {
        private int _userId;
        public WaiterForm(int userId)
        {
            InitializeComponent();
            LoadTablesToPanel();
            _userId = userId;
        }

        SqlConnection connection = DatabaseConnection.GetConnection();

        private void LoadTablesToPanel()
        {
            // TableLayoutPanel oluştur
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                ColumnCount = 4, // 4 sütun
                RowCount = 3,    // 3 satır
                Dock = DockStyle.Fill, // Panelin tamamını kaplasın
                AutoSize = true
            };

            // Sütun ve satır boyutlarını eşit ayarla
            for (int i = 0; i < 4; i++)
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25)); // %25 her sütun

            for (int i = 0; i < 3; i++)
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33f)); // %33.33 her satır

            // Veritabanından masaları yükle
            LoadTableStatusFromDatabase(tableLayoutPanel);

            // TableLayoutPanel'i Panel içine ekle
            panelTables.Controls.Add(tableLayoutPanel); // 'panelTables' panelin ismi
        }

        private void LoadTableStatusFromDatabase(TableLayoutPanel tableLayoutPanel)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT table_number, is_occupied FROM tables";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int tableNumber = reader.GetInt32(0); // Masa numarası
                        bool isOccupied = reader.GetBoolean(1); // Doluluk durumu

                        // Masa için buton oluştur
                        Button tableButton = new Button
                        {
                            Text = $"Table {tableNumber}\n" + (isOccupied ? "" : ""),
                            BackColor = isOccupied ? Color.Salmon : Color.MediumAquamarine,
                            Dock = DockStyle.Fill,
                            Enabled = false, // Tıklanamaz
                            Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold | FontStyle.Italic)
                        };

                        // TableLayoutPanel'e butonu ekle
                        tableLayoutPanel.Controls.Add(tableButton);
                    }
                }
            }
        }
        private void btnLoadChart_Click(object sender, EventArgs e)
        {
            // SQL bağlantısı
            string query = @"
                SELECT BestMenuItem_food_name AS FoodName, 
                       SUM(BestMenuItem_quantity) AS TotalQuantity
                FROM BestMenuItem
                GROUP BY BestMenuItem_food_name
                ORDER BY TotalQuantity DESC";


            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Chart kontrolünü temizle
                chartBestMenu.Series.Clear();
                chartBestMenu.Titles.Clear();

                // Yeni bir seri oluştur
                Series series = new Series("Best Menu Items")
                {
                    ChartType = SeriesChartType.Pie // Daire dilimi grafiği
                };

                int count = 0; // Sayaç

                // Verileri oku ve seriye ekle
                while (reader.Read())
                {
                    if (count >= 5) break; // İlk beş öğeyi ekle, sonra çık

                    string foodName = reader["FoodName"].ToString();
                    int totalQuantity = Convert.ToInt32(reader["TotalQuantity"]);

                    // Yemek ismini legend için ekleyip, sadece miktarı dilimde göstermek için foodName yerine "" kullan
                    series.Points.AddXY("", totalQuantity);
                    series.Points[series.Points.Count - 1].LegendText = foodName; // Legend kısmında yemek ismini göster

                    count++; // Sayaç artır
                }

                // Grafiğe ekle ve başlık belirle
                chartBestMenu.Series.Add(series);
                chartBestMenu.Titles.Add("Most Ordered Menu Items");
                chartBestMenu.Legends[0].Enabled = true; // Efsane kısmını etkinleştir

                connection.Close();
            }
        }
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AddOrder addOrder = new AddOrder(_userId);
            addOrder.Show();
            this.Hide();
        }

        private void btnViewMenu1_Click(object sender, EventArgs e)
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
