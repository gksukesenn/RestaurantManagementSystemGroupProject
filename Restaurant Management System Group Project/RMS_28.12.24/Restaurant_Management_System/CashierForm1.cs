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
    public partial class CashierForm1 : Form
    {
        
        public CashierForm1()
        {
            InitializeComponent();
        }
        private void CashierForm1_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde ComboBox'ı doldur
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
                    string query = "SELECT DISTINCT table_number FROM cash_register";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    TableNumber.Items.Clear();
                    //TableNumber.Items.Add("All"); // Tüm masalar için seçenek

                    while (reader.Read())
                    {
                        TableNumber.Items.Add(reader["table_number"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OrderDetails_Click(object sender, EventArgs e)
        {
            // Seçilen masa numarasını al
            string selectedTable = TableNumber.SelectedItem?.ToString();
            int? tableNumber = null;

            if (!string.IsNullOrEmpty(selectedTable) && selectedTable != "All")
            {
                tableNumber = int.Parse(selectedTable);
            }

            FetchCompletedOrdersDetails(tableNumber);
        }

        private void FetchCompletedOrdersDetails(int? tableNumber)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    //MessageBox.Show("Gönderilen TableNumber: " + (tableNumber.HasValue ? tableNumber.Value.ToString() : "NULL"));

                    connection.Open();

                    SqlCommand command = new SqlCommand("GetCompletedOrdersDetails", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Prosedüre parametre ekle
                    command.Parameters.AddWithValue("@TableNumber", tableNumber.HasValue ? (object)tableNumber.Value : DBNull.Value);

                    // Veri seti ile sonuçları al
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    // İlk sorgu sonucu (Order Details)
                    if (dataSet.Tables.Count > 0)
                    {
                        dataGridView1.DataSource = dataSet.Tables[0];
                    }

                    // İkinci sorgu sonucu (Toplam Fiyatlar)
                    if (dataSet.Tables.Count > 1)
                    {
                        dataGridView2.DataSource = dataSet.Tables[1];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CashierForm1_Load_1(object sender, EventArgs e)
        {
            try
            {
                // Bağlantı dizesi


                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    // "tables" tablosundaki table_number değerlerini al
                    string query = "SELECT table_number FROM tables";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // ComboBox'a table_number değerlerini ekle
                                TableNumber.Items.Add(reader["table_number"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading tables: " + ex.Message);
            }
        }

        private void ClearTable_Click(object sender, EventArgs e)
        {
            // Seçilen masa numarasını al
            string selectedTable = TableNumber.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedTable) || selectedTable == "All")
            {
                MessageBox.Show("Please select a table number to clear.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tableNumber;
            if (!int.TryParse(selectedTable, out tableNumber))
            {
                MessageBox.Show("Invalid table number selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Prosedürü çağır
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    // `ClearTable` prosedürünü çağıran komut
                    using (SqlCommand command = new SqlCommand("ClearTable", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Prosedüre masa numarasını parametre olarak ekle
                        command.Parameters.AddWithValue("@TableNumber", tableNumber);

                        // Prosedürü çalıştır
                        command.ExecuteNonQuery();

                        // İşlem başarıyla tamamlandığında kullanıcıya bilgi ver
                        MessageBox.Show($"Table {tableNumber} was successfully cleared and related data updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Masaları tekrar yükle
                    LoadTableNumbers();

                    TableNumber.SelectedIndex = -1; // ComboBox seçimini sıfırla
                    dataGridView1.DataSource = null; // İlk DataGridView'i temizle
                    dataGridView2.DataSource = null;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
