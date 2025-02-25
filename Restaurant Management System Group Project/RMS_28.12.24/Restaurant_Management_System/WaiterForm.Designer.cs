namespace Restaurant_Management_System
{
    partial class WaiterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaiterForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.OrderStatus1 = new System.Windows.Forms.Button();
            this.btnViewMenu1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelTables = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLoadChart = new System.Windows.Forms.Button();
            this.chartBestMenu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBestMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonLogOut);
            this.panel1.Controls.Add(this.btnAddOrder);
            this.panel1.Controls.Add(this.OrderStatus1);
            this.panel1.Controls.Add(this.btnViewMenu1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
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
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackgroundImage = global::Restaurant_Management_System.Properties.Resources.Ekran_görüntüsü_2024_12_30_201118;
            this.buttonLogOut.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLogOut.Location = new System.Drawing.Point(151, 576);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(171, 42);
            this.buttonLogOut.TabIndex = 2;
            this.buttonLogOut.Text = "   Log Out";
            this.buttonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddOrder.BackgroundImage")));
            this.btnAddOrder.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.btnAddOrder.Location = new System.Drawing.Point(44, 300);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(340, 57);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // OrderStatus1
            // 
            this.OrderStatus1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OrderStatus1.BackgroundImage")));
            this.OrderStatus1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OrderStatus1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.OrderStatus1.Location = new System.Drawing.Point(44, 460);
            this.OrderStatus1.Name = "OrderStatus1";
            this.OrderStatus1.Size = new System.Drawing.Size(340, 57);
            this.OrderStatus1.TabIndex = 2;
            this.OrderStatus1.Text = "Change Order Status";
            this.OrderStatus1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrderStatus1.UseVisualStyleBackColor = true;
            this.OrderStatus1.Click += new System.EventHandler(this.OrderStatus_Click);
            // 
            // btnViewMenu1
            // 
            this.btnViewMenu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewMenu1.BackgroundImage")));
            this.btnViewMenu1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnViewMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.btnViewMenu1.Location = new System.Drawing.Point(44, 380);
            this.btnViewMenu1.Name = "btnViewMenu1";
            this.btnViewMenu1.Size = new System.Drawing.Size(340, 57);
            this.btnViewMenu1.TabIndex = 1;
            this.btnViewMenu1.Text = "View Menu";
            this.btnViewMenu1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewMenu1.UseVisualStyleBackColor = true;
            this.btnViewMenu1.Click += new System.EventHandler(this.btnViewMenu1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelTables);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnLoadChart);
            this.panel3.Controls.Add(this.chartBestMenu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(284, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1222, 744);
            this.panel3.TabIndex = 5;
            // 
            // panelTables
            // 
            this.panelTables.Location = new System.Drawing.Point(627, 84);
            this.panelTables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTables.Name = "panelTables";
            this.panelTables.Size = new System.Drawing.Size(574, 473);
            this.panelTables.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.label6.Location = new System.Drawing.Point(23, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(525, 32);
            this.label6.TabIndex = 24;
            this.label6.Text = "To See Best Menu Item Press Load Chart Button";
            // 
            // btnLoadChart
            // 
            this.btnLoadChart.BackgroundImage = global::Restaurant_Management_System.Properties.Resources.Ekran_görüntüsü_2024_12_30_214012;
            this.btnLoadChart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLoadChart.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnLoadChart.Location = new System.Drawing.Point(436, 513);
            this.btnLoadChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadChart.Name = "btnLoadChart";
            this.btnLoadChart.Size = new System.Drawing.Size(185, 44);
            this.btnLoadChart.TabIndex = 1;
            this.btnLoadChart.Text = "Load Chart";
            this.btnLoadChart.UseVisualStyleBackColor = true;
            this.btnLoadChart.Click += new System.EventHandler(this.btnLoadChart_Click);
            // 
            // chartBestMenu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBestMenu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBestMenu.Legends.Add(legend1);
            this.chartBestMenu.Location = new System.Drawing.Point(29, 85);
            this.chartBestMenu.Name = "chartBestMenu";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "MenuItems";
            this.chartBestMenu.Series.Add(series1);
            this.chartBestMenu.Size = new System.Drawing.Size(592, 422);
            this.chartBestMenu.TabIndex = 0;
            this.chartBestMenu.Text = "chart1";
            // 
            // WaiterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1506, 744);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "WaiterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaiterForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBestMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnViewMenu1;
        private System.Windows.Forms.Button OrderStatus1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBestMenu;
        private System.Windows.Forms.Button btnLoadChart;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelTables;
    }
}