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
    public partial class RevenueForm : Form
    {
        
        public RevenueForm()
        {
            InitializeComponent();
            LoadRevenueTable();
            LoadTableNumbers();
            LoadWaiterNames();
        }

        SqlConnection connection = DatabaseConnection.GetConnection();
        private void LoadRevenueTable()
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM revenue";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable revenueTable = new DataTable();
                adapter.Fill(revenueTable);
                dataGridView1.DataSource = revenueTable;
            }
        }
        private void LoadExpenseTable()
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM expense";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable expenseTable = new DataTable();
                adapter.Fill(expenseTable);
                dataGridView1.DataSource = expenseTable;
            }
        }

        private void LoadTableNumbers()
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT table_number FROM tables";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TableNumberForGiro.Items.Add(reader["table_number"].ToString());
                }
                connection.Close();
            }
        }

        private void LoadWaiterNames()
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT DISTINCT waiter_name FROM revenue";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    WaiterSelctionBox.Items.Add(reader["waiter_name"].ToString());
                }
                connection.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }



        private void DailyGiroBtn_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM revenue WHERE CAST(transaction_date AS DATE) = @SelectedDate";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SelectedDate", selectedDate);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dailyTable = new DataTable();
                adapter.Fill(dailyTable);

                if (dailyTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dailyTable;
                }
                else
                {
                    MessageBox.Show("No data found on the selected date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //LoadRevenueTable();
            }

        }

        private void CalculateForTableBtn_Click(object sender, EventArgs e)
        {
            if (TableNumberForGiro.SelectedItem == null)
            {
                MessageBox.Show("Please select a table number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedTableNumber = int.Parse(TableNumberForGiro.SelectedItem.ToString());

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT SUM(total_price) FROM revenue WHERE table_number = @TableNumber";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TableNumber", selectedTableNumber);

                connection.Open();
                object result = command.ExecuteScalar();
                connection.Close();

                if (result != DBNull.Value)
                {
                    decimal totalGiro = Convert.ToDecimal(result);
                    TabelGiroLabel.Text = $"{totalGiro:F2} TL";
                }
                else
                {
                    TabelGiroLabel.Text = "0.00 TL";
                }
                LoadRevenueTable();
            }
        }

        private void TotalGiroBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string revenueQuery = "SELECT SUM(total_price) FROM revenue";
                string expenseQuery = "SELECT SUM(total_price) FROM expense";

                decimal totalRevenue = 0;
                decimal totalExpense = 0;

                // Gelir toplamını al
                using (SqlCommand revenueCommand = new SqlCommand(revenueQuery, connection))
                {
                    connection.Open();
                    object revenueResult = revenueCommand.ExecuteScalar();
                    if (revenueResult != DBNull.Value)
                    {
                        totalRevenue = Convert.ToDecimal(revenueResult);
                    }
                    connection.Close();
                }

                // Gider toplamını al
                using (SqlCommand expenseCommand = new SqlCommand(expenseQuery, connection))
                {
                    connection.Open();
                    object expenseResult = expenseCommand.ExecuteScalar();
                    if (expenseResult != DBNull.Value)
                    {
                        totalExpense = Convert.ToDecimal(expenseResult);
                    }
                    connection.Close();
                }

                // Net toplamı hesapla
                decimal netTotal = totalRevenue - totalExpense;

                // Sonucu göster
                TotalGiroLabel.Text = $"{netTotal:F2} TL";

                // Gelir tablosunu yükle
                LoadRevenueTable();
            }
        }


        private void GiroForWaiterBtn_Click(object sender, EventArgs e)
        {
            if (WaiterSelctionBox.SelectedItem == null)
            {
                MessageBox.Show("Please choose a waiter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedWaiter = WaiterSelctionBox.SelectedItem.ToString();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT SUM(total_price) FROM revenue WHERE waiter_name = @WaiterName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@WaiterName", selectedWaiter);

                connection.Open();
                object result = command.ExecuteScalar();
                connection.Close();

                if (result != DBNull.Value)
                {
                    decimal totalGiro = Convert.ToDecimal(result);
                    GiroForWaiterLabel.Text = $"{totalGiro:F2} TL"; // Sonucu formatla
                }
                else
                {
                    GiroForWaiterLabel.Text = "0.00 TL";
                }
            }
        }

        private void StockManage_Click(object sender, EventArgs e)
        {
            ManageStockForm managestock = new ManageStockForm();
            managestock.Show();
            this.Hide();
        }

        private void ViewRevenue_Click(object sender, EventArgs e)
        {
            RevenueForm revenueform = new RevenueForm();
            revenueform.Show();
            this.Hide();
        }
        private void ManageMenu_Click(object sender, EventArgs e)
        {
            ManageMenuForm addmenu = new ManageMenuForm();
            addmenu.Show();
            this.Hide();
        }

        private void ManageStaff_Click(object sender, EventArgs e)
        {
            ManageStaff managestaff = new ManageStaff();
            managestaff.Show();
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

        private void ShowExpenseBtn_Click(object sender, EventArgs e)
        {
            LoadExpenseTable();
        }


    }
}
