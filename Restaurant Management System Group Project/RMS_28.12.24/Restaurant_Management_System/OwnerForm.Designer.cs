namespace Restaurant_Management_System
{
    partial class OwnerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.ViewRevenue = new System.Windows.Forms.Button();
            this.StockManage = new System.Windows.Forms.Button();
            this.ManageMenu = new System.Windows.Forms.Button();
            this.AddWorker = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonLogOut);
            this.panel1.Controls.Add(this.ViewRevenue);
            this.panel1.Controls.Add(this.StockManage);
            this.panel1.Controls.Add(this.ManageMenu);
            this.panel1.Controls.Add(this.AddWorker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 744);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant_Management_System.Properties.Resources.ForkBase;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
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
            this.buttonLogOut.TabIndex = 5;
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
            this.ViewRevenue.Click += new System.EventHandler(this.ViewRevenue_Click);
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
            this.ManageMenu.Click += new System.EventHandler(this.AddMenu_Click);
            // 
            // AddWorker
            // 
            this.AddWorker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddWorker.BackgroundImage")));
            this.AddWorker.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddWorker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.AddWorker.Location = new System.Drawing.Point(59, 330);
            this.AddWorker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddWorker.Name = "AddWorker";
            this.AddWorker.Size = new System.Drawing.Size(340, 57);
            this.AddWorker.TabIndex = 1;
            this.AddWorker.Text = "Manage Staff";
            this.AddWorker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddWorker.UseVisualStyleBackColor = true;
            this.AddWorker.Click += new System.EventHandler(this.AddWorker_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(284, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1222, 744);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(932, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 576);
            this.label1.TabIndex = 1;
            this.label1.Text = "F\r\nO\r\nR\r\nK\r\n\r\nB\r\nA\r\nS\r\nE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Restaurant_Management_System.Properties.Resources.owner_üçlü_Photoroom;
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(750, 825);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1506, 744);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OwnerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OwnerForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StockManage;
        private System.Windows.Forms.Button AddWorker;
        private System.Windows.Forms.Button ManageMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ViewRevenue;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}