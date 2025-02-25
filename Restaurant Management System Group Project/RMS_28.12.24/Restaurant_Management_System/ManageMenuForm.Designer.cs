namespace Restaurant_Management_System
{
    partial class ManageMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMenuForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.selectRecipeItem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.selectRecipeFood = new System.Windows.Forms.ComboBox();
            this.recipeAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewFood = new System.Windows.Forms.DataGridView();
            this.buttonRemoveMenu = new System.Windows.Forms.Button();
            this.comboSelectFood = new System.Windows.Forms.ComboBox();
            this.menuAdd = new System.Windows.Forms.Button();
            this.textFood = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.StockManage = new System.Windows.Forms.Button();
            this.StaffManage = new System.Windows.Forms.Button();
            this.ManageMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ViewRevenue = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.selectRecipeItem);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textQuantity);
            this.panel3.Controls.Add(this.selectRecipeFood);
            this.panel3.Controls.Add(this.recipeAdd);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textPrice);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dataGridViewFood);
            this.panel3.Controls.Add(this.buttonRemoveMenu);
            this.panel3.Controls.Add(this.comboSelectFood);
            this.panel3.Controls.Add(this.menuAdd);
            this.panel3.Controls.Add(this.textFood);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(284, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1222, 744);
            this.panel3.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.label9.Location = new System.Drawing.Point(66, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 23);
            this.label9.TabIndex = 32;
            this.label9.Text = "Item";
            // 
            // selectRecipeItem
            // 
            this.selectRecipeItem.AllowDrop = true;
            this.selectRecipeItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectRecipeItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.selectRecipeItem.FormattingEnabled = true;
            this.selectRecipeItem.IntegralHeight = false;
            this.selectRecipeItem.ItemHeight = 23;
            this.selectRecipeItem.Location = new System.Drawing.Point(155, 410);
            this.selectRecipeItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectRecipeItem.MaxDropDownItems = 6;
            this.selectRecipeItem.Name = "selectRecipeItem";
            this.selectRecipeItem.Size = new System.Drawing.Size(216, 31);
            this.selectRecipeItem.TabIndex = 31;
            this.selectRecipeItem.SelectedIndexChanged += new System.EventHandler(this.selectRecipeItem_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.label8.Location = new System.Drawing.Point(61, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 23);
            this.label8.TabIndex = 30;
            this.label8.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.label7.Location = new System.Drawing.Point(61, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "Food";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.label5.Location = new System.Drawing.Point(89, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 32);
            this.label5.TabIndex = 28;
            this.label5.Text = "Add New Recipe Item";
            // 
            // textQuantity
            // 
            this.textQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.textQuantity.Location = new System.Drawing.Point(155, 466);
            this.textQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(216, 30);
            this.textQuantity.TabIndex = 27;
            // 
            // selectRecipeFood
            // 
            this.selectRecipeFood.AllowDrop = true;
            this.selectRecipeFood.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectRecipeFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.selectRecipeFood.FormattingEnabled = true;
            this.selectRecipeFood.IntegralHeight = false;
            this.selectRecipeFood.ItemHeight = 23;
            this.selectRecipeFood.Location = new System.Drawing.Point(155, 345);
            this.selectRecipeFood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectRecipeFood.MaxDropDownItems = 6;
            this.selectRecipeFood.Name = "selectRecipeFood";
            this.selectRecipeFood.Size = new System.Drawing.Size(216, 31);
            this.selectRecipeFood.TabIndex = 26;
            this.selectRecipeFood.SelectedIndexChanged += new System.EventHandler(this.selectRecipeFood_SelectedIndexChanged);
            // 
            // recipeAdd
            // 
            this.recipeAdd.BackgroundImage = global::Restaurant_Management_System.Properties.Resources.Ekran_görüntüsü_2024_12_30_214012;
            this.recipeAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recipeAdd.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.recipeAdd.Location = new System.Drawing.Point(155, 501);
            this.recipeAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recipeAdd.Name = "recipeAdd";
            this.recipeAdd.Size = new System.Drawing.Size(116, 36);
            this.recipeAdd.TabIndex = 25;
            this.recipeAdd.Text = "Add";
            this.recipeAdd.UseVisualStyleBackColor = true;
            this.recipeAdd.Click += new System.EventHandler(this.recipeAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.label4.Location = new System.Drawing.Point(89, 560);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "Remove an Item From Menu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.label6.Location = new System.Drawing.Point(89, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "Add New Menu Item";
            // 
            // textPrice
            // 
            this.textPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.textPrice.Location = new System.Drawing.Point(155, 153);
            this.textPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(216, 30);
            this.textPrice.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.label3.Location = new System.Drawing.Point(91, 620);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Food";
            // 
            // dataGridViewFood
            // 
            this.dataGridViewFood.ColumnHeadersHeight = 34;
            this.dataGridViewFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewFood.Location = new System.Drawing.Point(624, 53);
            this.dataGridViewFood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewFood.Name = "dataGridViewFood";
            this.dataGridViewFood.RowHeadersWidth = 62;
            this.dataGridViewFood.Size = new System.Drawing.Size(508, 596);
            this.dataGridViewFood.TabIndex = 8;
            // 
            // buttonRemoveMenu
            // 
            this.buttonRemoveMenu.BackgroundImage = global::Restaurant_Management_System.Properties.Resources.Ekran_görüntüsü_2024_12_30_214012;
            this.buttonRemoveMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRemoveMenu.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonRemoveMenu.Location = new System.Drawing.Point(155, 679);
            this.buttonRemoveMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemoveMenu.Name = "buttonRemoveMenu";
            this.buttonRemoveMenu.Size = new System.Drawing.Size(116, 36);
            this.buttonRemoveMenu.TabIndex = 7;
            this.buttonRemoveMenu.Text = "Remove";
            this.buttonRemoveMenu.UseVisualStyleBackColor = true;
            this.buttonRemoveMenu.Click += new System.EventHandler(this.buttonRemoveMenu_Click);
            // 
            // comboSelectFood
            // 
            this.comboSelectFood.AllowDrop = true;
            this.comboSelectFood.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboSelectFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.comboSelectFood.FormattingEnabled = true;
            this.comboSelectFood.IntegralHeight = false;
            this.comboSelectFood.ItemHeight = 23;
            this.comboSelectFood.Location = new System.Drawing.Point(155, 618);
            this.comboSelectFood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboSelectFood.MaxDropDownItems = 6;
            this.comboSelectFood.Name = "comboSelectFood";
            this.comboSelectFood.Size = new System.Drawing.Size(216, 31);
            this.comboSelectFood.TabIndex = 6;
            // 
            // menuAdd
            // 
            this.menuAdd.BackgroundImage = global::Restaurant_Management_System.Properties.Resources.Ekran_görüntüsü_2024_12_30_214012;
            this.menuAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuAdd.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.menuAdd.Location = new System.Drawing.Point(155, 206);
            this.menuAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Size = new System.Drawing.Size(116, 36);
            this.menuAdd.TabIndex = 4;
            this.menuAdd.Text = "Add";
            this.menuAdd.UseVisualStyleBackColor = true;
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // textFood
            // 
            this.textFood.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.textFood.Location = new System.Drawing.Point(155, 86);
            this.textFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textFood.Name = "textFood";
            this.textFood.Size = new System.Drawing.Size(216, 30);
            this.textFood.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.label2.Location = new System.Drawing.Point(89, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(89, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackgroundImage = global::Restaurant_Management_System.Properties.Resources.Ekran_görüntüsü_2024_12_30_201118;
            this.buttonLogOut.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.buttonLogOut.Location = new System.Drawing.Point(151, 592);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(171, 42);
            this.buttonLogOut.TabIndex = 11;
            this.buttonLogOut.Text = "   Log Out";
            this.buttonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
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
            // StaffManage
            // 
            this.StaffManage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StaffManage.BackgroundImage")));
            this.StaffManage.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StaffManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.StaffManage.Location = new System.Drawing.Point(59, 330);
            this.StaffManage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StaffManage.Name = "StaffManage";
            this.StaffManage.Size = new System.Drawing.Size(340, 57);
            this.StaffManage.TabIndex = 3;
            this.StaffManage.Text = "Manage Staff";
            this.StaffManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StaffManage.UseVisualStyleBackColor = true;
            this.StaffManage.Click += new System.EventHandler(this.button1_Click);
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
            this.ManageMenu.TabIndex = 4;
            this.ManageMenu.Text = "Manage Menu";
            this.ManageMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageMenu.UseVisualStyleBackColor = true;
            this.ManageMenu.Click += new System.EventHandler(this.ManageMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonLogOut);
            this.panel1.Controls.Add(this.ViewRevenue);
            this.panel1.Controls.Add(this.ManageMenu);
            this.panel1.Controls.Add(this.StaffManage);
            this.panel1.Controls.Add(this.StockManage);
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
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
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
            this.ViewRevenue.TabIndex = 5;
            this.ViewRevenue.Text = "View Revenue";
            this.ViewRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewRevenue.UseVisualStyleBackColor = true;
            this.ViewRevenue.Click += new System.EventHandler(this.ViewRevenue_Click);
            // 
            // ManageMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1506, 744);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owner";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button menuAdd;
        private System.Windows.Forms.Button buttonRemoveMenu;
        private System.Windows.Forms.ComboBox comboSelectFood;
        private System.Windows.Forms.DataGridView dataGridViewFood;
        private System.Windows.Forms.Button StockManage;
        private System.Windows.Forms.Button StaffManage;
        private System.Windows.Forms.Button ManageMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textFood;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button ViewRevenue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox selectRecipeFood;
        private System.Windows.Forms.Button recipeAdd;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox selectRecipeItem;
        private System.Windows.Forms.Label label8;
    }
}