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
    public partial class ChangeOrderStatus : Form
    {
        private int _userId;
        public ChangeOrderStatus(int userId)
        {
            InitializeComponent();
            LoadTableNumbers2();
            LoadOrderStatuses();
            _userId = userId;
        }
        SqlConnection connection = DatabaseConnection.GetConnection();
        private void LoadTableNumbers2()
        {
            
            string query = "SELECT table_number FROM tables";

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    ChooseTableNumber.Items.Add(row["table_number"].ToString());
                }
            }
        }

        private void ChooseTableNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChooseTableNumber.SelectedItem != null)
            {
                string selectedTable = ChooseTableNumber.SelectedItem.ToString();
                
                string query = "SELECT order_id, table_number, selected_menu_item, total_order_quantity, order_status, order_date " +
                               "FROM orders WHERE table_number = @TableNumber";

                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@TableNumber", selectedTable);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt; // DataGridView’e siparişleri yükle
                }
            }
        }

        private int selectedOrderId = -1; // Seçilen siparişin ID'sini tutacak global bir değişken
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Satır başlıklarına tıklamayı hariç tutmak için
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Seçilen order_id'yi al
                if (selectedRow.Cells["order_id"].Value != null)
                {
                    selectedOrderId = Convert.ToInt32(selectedRow.Cells["order_id"].Value);
                }
                else
                {
                    selectedOrderId = -1; // Sipariş ID'si yoksa -1
                }
            }
        }
        private void LoadOrderStatuses()
        {
            cmbOrderStatus.Items.Clear();
            cmbOrderStatus.Items.Add("completed");
            cmbOrderStatus.Items.Add("cancelled");
        }

        private void cmbOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrderStatus.SelectedItem != null)
            {
                string selectedStatus = cmbOrderStatus.SelectedItem.ToString();
                //MessageBox.Show($"Selected status: {selectedStatus}");
            }
        }

        private void OrderStatus_Click(object sender, EventArgs e)
        {
            
        }

        private void OrderStatus_Click_1(object sender, EventArgs e)
        {
            if (txtOrderId.Text != "" && cmbOrderStatus.SelectedItem != null)
            {
                int orderId;
                if (int.TryParse(txtOrderId.Text, out orderId)) // Order ID'nin geçerli bir sayı olup olmadığını kontrol et
                {
                    string newStatus = cmbOrderStatus.SelectedItem.ToString();

                    // Sadece "completed" ya da "cancelled" değerlerine izin verelim
                    if (newStatus != "completed" && newStatus != "cancelled")
                    {
                        MessageBox.Show("Invalid status selected. Please choose either 'completed' or 'cancelled'.");
                        return;
                    }

                   
                    string query = "UPDATE orders SET order_status = @Status WHERE order_id = @OrderId";

                    using (SqlConnection connection = DatabaseConnection.GetConnection())
                    {
                        try
                        {
                            connection.Open();
                            SqlCommand cmd = new SqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@Status", newStatus);
                            cmd.Parameters.AddWithValue("@OrderId", orderId);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Order status updated successfully.");

                                // Güncellenen tabloyu yeniden yükle
                                ReloadOrdersForSelectedTable();
                            }
                            else
                            {
                                MessageBox.Show("No order found with the given Order ID.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Order ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter an Order ID and select a status.");
            }
        }

        private void ReloadOrdersForSelectedTable()
        {
            if (ChooseTableNumber.SelectedItem != null)
            {
                string selectedTable = ChooseTableNumber.SelectedItem.ToString();
                
                string query = "SELECT order_id, table_number, selected_menu_item, total_order_quantity, order_status, order_date " +
                               "FROM orders WHERE table_number = @TableNumber";

                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@TableNumber", selectedTable);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt; // DataGridView’e siparişleri yükle
                }
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

        private void OrderStatus1_Click(object sender, EventArgs e)
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
