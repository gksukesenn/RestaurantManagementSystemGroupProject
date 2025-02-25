namespace Restaurant_Management_System
{
    partial class ChefForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChefForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ViewOrderBtn = new System.Windows.Forms.Button();
            this.ViewRecipeBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ViewFoodStatus = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonShowOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboSelectFood = new System.Windows.Forms.ComboBox();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.comboTableNumber = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewFoodStatus)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.ViewOrderBtn);
            this.panel1.Controls.Add(this.ViewRecipeBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonLogOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 744);
            this.panel1.TabIndex = 3;
            // 
            // ViewOrderBtn
            // 
            this.ViewOrderBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ViewOrderBtn.BackgroundImage")));
            this.ViewOrderBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ViewOrderBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.ViewOrderBtn.Location = new System.Drawing.Point(59, 410);
            this.ViewOrderBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewOrderBtn.Name = "ViewOrderBtn";
            this.ViewOrderBtn.Size = new System.Drawing.Size(340, 57);
            this.ViewOrderBtn.TabIndex = 9;
            this.ViewOrderBtn.Text = "View Order";
            this.ViewOrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewOrderBtn.UseVisualStyleBackColor = true;
            this.ViewOrderBtn.Click += new System.EventHandler(this.ViewOrderBtn_Click);
            // 
            // ViewRecipeBtn
            // 
            this.ViewRecipeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ViewRecipeBtn.BackgroundImage")));
            this.ViewRecipeBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ViewRecipeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.ViewRecipeBtn.Location = new System.Drawing.Point(59, 490);
            this.ViewRecipeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewRecipeBtn.Name = "ViewRecipeBtn";
            this.ViewRecipeBtn.Size = new System.Drawing.Size(340, 57);
            this.ViewRecipeBtn.TabIndex = 8;
            this.ViewRecipeBtn.Text = "View Recipe";
            this.ViewRecipeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewRecipeBtn.UseVisualStyleBackColor = true;
            this.ViewRecipeBtn.Click += new System.EventHandler(this.ViewRecipeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant_Management_System.Properties.Resources.ForkBase;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackgroundImage = global::Restaurant_Management_System.Properties.Resources.Ekran_görüntüsü_2024_12_30_201118;
            this.buttonLogOut.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.buttonLogOut.Location = new System.Drawing.Point(121, 596);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(234, 48);
            this.buttonLogOut.TabIndex = 2;
            this.buttonLogOut.Text = "   Log Out";
            this.buttonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.ViewFoodStatus);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(284, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1222, 744);
            this.panel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.label3.Location = new System.Drawing.Point(341, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(432, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "View Orders of Selected Table Number";
            // 
            // ViewFoodStatus
            // 
            this.ViewFoodStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewFoodStatus.Location = new System.Drawing.Point(348, 123);
            this.ViewFoodStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewFoodStatus.Name = "ViewFoodStatus";
            this.ViewFoodStatus.RowHeadersWidth = 62;
            this.ViewFoodStatus.Size = new System.Drawing.Size(810, 496);
            this.ViewFoodStatus.TabIndex = 7;
            this.ViewFoodStatus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewFoodStatus_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonShowOrder);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboSelectFood);
            this.panel2.Controls.Add(this.buttonProcess);
            this.panel2.Controls.Add(this.comboTableNumber);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.panel2.Location = new System.Drawing.Point(17, 202);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 316);
            this.panel2.TabIndex = 6;
            // 
            // buttonShowOrder
            // 
            this.buttonShowOrder.BackgroundImage = global::Restaurant_Management_System.Properties.Resources.Ekran_görüntüsü_2024_12_18_020556;
            this.buttonShowOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.buttonShowOrder.Location = new System.Drawing.Point(66, 64);
            this.buttonShowOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowOrder.Name = "buttonShowOrder";
            this.buttonShowOrder.Size = new System.Drawing.Size(148, 49);
            this.buttonShowOrder.TabIndex = 0;
            this.buttonShowOrder.Text = "Show Table";
            this.buttonShowOrder.UseVisualStyleBackColor = true;
            this.buttonShowOrder.Click += new System.EventHandler(this.buttonShowOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.label2.Location = new System.Drawing.Point(24, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Food";
            // 
            // comboSelectFood
            // 
            this.comboSelectFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.comboSelectFood.FormattingEnabled = true;
            this.comboSelectFood.Location = new System.Drawing.Point(157, 166);
            this.comboSelectFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboSelectFood.Name = "comboSelectFood";
            this.comboSelectFood.Size = new System.Drawing.Size(131, 31);
            this.comboSelectFood.TabIndex = 4;
            this.comboSelectFood.SelectedIndexChanged += new System.EventHandler(this.comboSelectFood_SelectedIndexChanged);
            // 
            // buttonProcess
            // 
            this.buttonProcess.BackgroundImage = global::Restaurant_Management_System.Properties.Resources.Ekran_görüntüsü_2024_12_18_020556;
            this.buttonProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.buttonProcess.Location = new System.Drawing.Point(66, 219);
            this.buttonProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(148, 49);
            this.buttonProcess.TabIndex = 5;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // comboTableNumber
            // 
            this.comboTableNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.comboTableNumber.FormattingEnabled = true;
            this.comboTableNumber.Location = new System.Drawing.Point(157, 10);
            this.comboTableNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboTableNumber.Name = "comboTableNumber";
            this.comboTableNumber.Size = new System.Drawing.Size(131, 31);
            this.comboTableNumber.TabIndex = 2;
            this.comboTableNumber.SelectedIndexChanged += new System.EventHandler(this.comboTableNumber_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table Number";
            // 
            // ChefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1506, 744);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChefForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChefForm";
            this.Load += new System.EventHandler(this.ChefForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewFoodStatus)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboSelectFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTableNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShowOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.DataGridView ViewFoodStatus;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ViewRecipeBtn;
        private System.Windows.Forms.Button ViewOrderBtn;
    }
}
