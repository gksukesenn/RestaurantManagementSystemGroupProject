namespace Restaurant_Management_System
{
    partial class RevenueForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevenueForm));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DailyGiroBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TableNumberForGiro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CalculateForTableBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TabelGiroLabel = new System.Windows.Forms.Label();
            this.TotalGiroLabel = new System.Windows.Forms.Label();
            this.TotalGiroBtn = new System.Windows.Forms.Button();
            this.WaiterSelctionBox = new System.Windows.Forms.ComboBox();
            this.GiroForWaiterLabel = new System.Windows.Forms.Label();
            this.GiroForWaiterBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.ShowExpenseBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.ViewRevenue = new System.Windows.Forms.Button();
            this.StockManage = new System.Windows.Forms.Button();
            this.ManageMenu = new System.Windows.Forms.Button();
            this.ManageStaff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Fuchsia;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 77);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(288, 30);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(300, 120);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(761, 440);
            this.dataGridView1.TabIndex = 1;
            // 
            // DailyGiroBtn
            // 
            this.DailyGiroBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DailyGiroBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.DailyGiroBtn.Location = new System.Drawing.Point(89, 118);
            this.DailyGiroBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DailyGiroBtn.Name = "DailyGiroBtn";
            this.DailyGiroBtn.Size = new System.Drawing.Size(167, 32);
            this.DailyGiroBtn.TabIndex = 2;
            this.DailyGiroBtn.Text = "Show";
            this.DailyGiroBtn.UseVisualStyleBackColor = true;
            this.DailyGiroBtn.Click += new System.EventHandler(this.DailyGiroBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select a date to see daily revenue;";
            // 
            // TableNumberForGiro
            // 
            this.TableNumberForGiro.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TableNumberForGiro.FormattingEnabled = true;
            this.TableNumberForGiro.Location = new System.Drawing.Point(34, 232);
            this.TableNumberForGiro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableNumberForGiro.Name = "TableNumberForGiro";
            this.TableNumberForGiro.Size = new System.Drawing.Size(288, 31);
            this.TableNumberForGiro.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Location = new System.Drawing.Point(29, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "calculate toltal revenue for specific table;";
            // 
            // CalculateForTableBtn
            // 
            this.CalculateForTableBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CalculateForTableBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.CalculateForTableBtn.Location = new System.Drawing.Point(89, 296);
            this.CalculateForTableBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CalculateForTableBtn.Name = "CalculateForTableBtn";
            this.CalculateForTableBtn.Size = new System.Drawing.Size(167, 32);
            this.CalculateForTableBtn.TabIndex = 6;
            this.CalculateForTableBtn.Text = "Calculate";
            this.CalculateForTableBtn.UseVisualStyleBackColor = true;
            this.CalculateForTableBtn.Click += new System.EventHandler(this.CalculateForTableBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.label4.Location = new System.Drawing.Point(516, 609);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Giro;";
            // 
            // TabelGiroLabel
            // 
            this.TabelGiroLabel.AutoSize = true;
            this.TabelGiroLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TabelGiroLabel.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.TabelGiroLabel.Location = new System.Drawing.Point(123, 267);
            this.TabelGiroLabel.Name = "TabelGiroLabel";
            this.TabelGiroLabel.Size = new System.Drawing.Size(0, 23);
            this.TabelGiroLabel.TabIndex = 9;
            // 
            // TotalGiroLabel
            // 
            this.TotalGiroLabel.AutoSize = true;
            this.TotalGiroLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TotalGiroLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.TotalGiroLabel.Location = new System.Drawing.Point(640, 655);
            this.TotalGiroLabel.Name = "TotalGiroLabel";
            this.TotalGiroLabel.Size = new System.Drawing.Size(0, 23);
            this.TotalGiroLabel.TabIndex = 10;
            // 
            // TotalGiroBtn
            // 
            this.TotalGiroBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TotalGiroBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.TotalGiroBtn.Location = new System.Drawing.Point(644, 604);
            this.TotalGiroBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TotalGiroBtn.Name = "TotalGiroBtn";
            this.TotalGiroBtn.Size = new System.Drawing.Size(167, 36);
            this.TotalGiroBtn.TabIndex = 11;
            this.TotalGiroBtn.Text = "Calculate";
            this.TotalGiroBtn.UseVisualStyleBackColor = true;
            this.TotalGiroBtn.Click += new System.EventHandler(this.TotalGiroBtn_Click);
            // 
            // WaiterSelctionBox
            // 
            this.WaiterSelctionBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WaiterSelctionBox.FormattingEnabled = true;
            this.WaiterSelctionBox.Location = new System.Drawing.Point(42, 430);
            this.WaiterSelctionBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WaiterSelctionBox.Name = "WaiterSelctionBox";
            this.WaiterSelctionBox.Size = new System.Drawing.Size(288, 31);
            this.WaiterSelctionBox.TabIndex = 12;
            // 
            // GiroForWaiterLabel
            // 
            this.GiroForWaiterLabel.AutoSize = true;
            this.GiroForWaiterLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GiroForWaiterLabel.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.GiroForWaiterLabel.Location = new System.Drawing.Point(123, 467);
            this.GiroForWaiterLabel.Name = "GiroForWaiterLabel";
            this.GiroForWaiterLabel.Size = new System.Drawing.Size(0, 23);
            this.GiroForWaiterLabel.TabIndex = 14;
            // 
            // GiroForWaiterBtn
            // 
            this.GiroForWaiterBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GiroForWaiterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.GiroForWaiterBtn.Location = new System.Drawing.Point(89, 498);
            this.GiroForWaiterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GiroForWaiterBtn.Name = "GiroForWaiterBtn";
            this.GiroForWaiterBtn.Size = new System.Drawing.Size(167, 32);
            this.GiroForWaiterBtn.TabIndex = 13;
            this.GiroForWaiterBtn.Text = "Calculate";
            this.GiroForWaiterBtn.UseVisualStyleBackColor = true;
            this.GiroForWaiterBtn.Click += new System.EventHandler(this.GiroForWaiterBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label5.Location = new System.Drawing.Point(29, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "calculate toltal revenue for specific waiter;";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ShowExpenseBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.GiroForWaiterLabel);
            this.panel1.Controls.Add(this.GiroForWaiterBtn);
            this.panel1.Controls.Add(this.WaiterSelctionBox);
            this.panel1.Controls.Add(this.TabelGiroLabel);
            this.panel1.Controls.Add(this.CalculateForTableBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TableNumberForGiro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DailyGiroBtn);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(1087, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 707);
            this.panel1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label6.Location = new System.Drawing.Point(71, 594);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "show inventory expenses;";
            // 
            // ShowExpenseBtn
            // 
            this.ShowExpenseBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ShowExpenseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.ShowExpenseBtn.Location = new System.Drawing.Point(89, 635);
            this.ShowExpenseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowExpenseBtn.Name = "ShowExpenseBtn";
            this.ShowExpenseBtn.Size = new System.Drawing.Size(167, 32);
            this.ShowExpenseBtn.TabIndex = 19;
            this.ShowExpenseBtn.Text = "Show";
            this.ShowExpenseBtn.UseVisualStyleBackColor = true;
            this.ShowExpenseBtn.Click += new System.EventHandler(this.ShowExpenseBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.label3.Location = new System.Drawing.Point(293, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Total Revenue Table For Restaurant";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.buttonLogOut);
            this.panel2.Controls.Add(this.ViewRevenue);
            this.panel2.Controls.Add(this.StockManage);
            this.panel2.Controls.Add(this.ManageMenu);
            this.panel2.Controls.Add(this.ManageStaff);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 747);
            this.panel2.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant_Management_System.Properties.Resources.ForkBase;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackgroundImage = global::Restaurant_Management_System.Properties.Resources.Ekran_görüntüsü_2024_12_30_201118;
            this.buttonLogOut.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.buttonLogOut.Location = new System.Drawing.Point(151, 592);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(171, 42);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.Text = "   Log Out";
            this.buttonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // ViewRevenue
            // 
            this.ViewRevenue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ViewRevenue.BackgroundImage")));
            this.ViewRevenue.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ViewRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.ViewRevenue.Location = new System.Drawing.Point(59, 490);
            this.ViewRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewRevenue.Name = "ViewRevenue";
            this.ViewRevenue.Size = new System.Drawing.Size(340, 57);
            this.ViewRevenue.TabIndex = 3;
            this.ViewRevenue.Text = "View Revenue";
            this.ViewRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewRevenue.UseVisualStyleBackColor = true;
            // 
            // StockManage
            // 
            this.StockManage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StockManage.BackgroundImage")));
            this.StockManage.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StockManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.StockManage.Location = new System.Drawing.Point(59, 250);
            this.StockManage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StockManage.Name = "StockManage";
            this.StockManage.Size = new System.Drawing.Size(340, 57);
            this.StockManage.TabIndex = 0;
            this.StockManage.Text = "Manage Stock";
            this.StockManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StockManage.UseVisualStyleBackColor = true;
            this.StockManage.Click += new System.EventHandler(this.StockManage_Click);
            // 
            // ManageMenu
            // 
            this.ManageMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ManageMenu.BackgroundImage")));
            this.ManageMenu.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ManageMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.ManageMenu.Location = new System.Drawing.Point(59, 410);
            this.ManageMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ManageMenu.Name = "ManageMenu";
            this.ManageMenu.Size = new System.Drawing.Size(340, 57);
            this.ManageMenu.TabIndex = 2;
            this.ManageMenu.Text = "Manage Menu";
            this.ManageMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageMenu.UseVisualStyleBackColor = true;
            this.ManageMenu.Click += new System.EventHandler(this.ManageMenu_Click);
            // 
            // ManageStaff
            // 
            this.ManageStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ManageStaff.BackgroundImage")));
            this.ManageStaff.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ManageStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.ManageStaff.Location = new System.Drawing.Point(59, 330);
            this.ManageStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ManageStaff.Name = "ManageStaff";
            this.ManageStaff.Size = new System.Drawing.Size(340, 57);
            this.ManageStaff.TabIndex = 1;
            this.ManageStaff.Text = "Manage Staff";
            this.ManageStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageStaff.UseVisualStyleBackColor = true;
            this.ManageStaff.Click += new System.EventHandler(this.ManageStaff_Click);
            // 
            // RevenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1509, 747);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotalGiroBtn);
            this.Controls.Add(this.TotalGiroLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RevenueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owner";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DailyGiroBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TableNumberForGiro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CalculateForTableBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TabelGiroLabel;
        private System.Windows.Forms.Label TotalGiroLabel;
        private System.Windows.Forms.Button TotalGiroBtn;
        private System.Windows.Forms.ComboBox WaiterSelctionBox;
        private System.Windows.Forms.Label GiroForWaiterLabel;
        private System.Windows.Forms.Button GiroForWaiterBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ViewRevenue;
        private System.Windows.Forms.Button StockManage;
        private System.Windows.Forms.Button ManageMenu;
        private System.Windows.Forms.Button ManageStaff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ShowExpenseBtn;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}