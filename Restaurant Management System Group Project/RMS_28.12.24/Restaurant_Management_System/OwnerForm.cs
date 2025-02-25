using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class OwnerForm : Form
    {
        public OwnerForm()
        {
            InitializeComponent();
        }

        private void StockManage_Click(object sender, EventArgs e)
        {
            ManageStockForm managestock = new ManageStockForm();
            managestock.Show();
            this.Hide();
        }


        private void AddMenu_Click(object sender, EventArgs e)
        {
            ManageMenuForm addmenu = new ManageMenuForm();
            addmenu.Show();
            this.Hide();
        }

        private void AddWorker_Click(object sender, EventArgs e)
        {
            ManageStaff managestaff = new ManageStaff();
            managestaff.Show();
            this.Hide();
        }

        private void ViewRevenue_Click(object sender, EventArgs e)
        {
            RevenueForm revenueform = new RevenueForm();
            revenueform.Show();
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
