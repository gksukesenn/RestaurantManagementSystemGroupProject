namespace Restaurant_Management_System
{
    partial class ViewRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRecipe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ViewOrderBtn = new System.Windows.Forms.Button();
            this.ViewRecipeBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.selectRecipeItem = new System.Windows.Forms.ComboBox();
            this.recipeDataGridView = new System.Windows.Forms.DataGridView();
            this.btnViewRecipe = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDataGridView)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(284, 747);
            this.panel1.TabIndex = 4;
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
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click_1);
            // 
            // selectRecipeItem
            // 
            this.selectRecipeItem.AllowDrop = true;
            this.selectRecipeItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectRecipeItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.selectRecipeItem.FormattingEnabled = true;
            this.selectRecipeItem.IntegralHeight = false;
            this.selectRecipeItem.Location = new System.Drawing.Point(386, 320);
            this.selectRecipeItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectRecipeItem.Name = "selectRecipeItem";
            this.selectRecipeItem.Size = new System.Drawing.Size(193, 31);
            this.selectRecipeItem.TabIndex = 5;
            // 
            // recipeDataGridView
            // 
            this.recipeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipeDataGridView.Location = new System.Drawing.Point(685, 130);
            this.recipeDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recipeDataGridView.Name = "recipeDataGridView";
            this.recipeDataGridView.RowHeadersWidth = 62;
            this.recipeDataGridView.RowTemplate.Height = 28;
            this.recipeDataGridView.Size = new System.Drawing.Size(684, 482);
            this.recipeDataGridView.TabIndex = 6;
            // 
            // btnViewRecipe
            // 
            this.btnViewRecipe.BackgroundImage = global::Restaurant_Management_System.Properties.Resources.Ekran_görüntüsü_2024_12_18_020556;
            this.btnViewRecipe.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnViewRecipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.btnViewRecipe.Location = new System.Drawing.Point(404, 368);
            this.btnViewRecipe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewRecipe.Name = "btnViewRecipe";
            this.btnViewRecipe.Size = new System.Drawing.Size(148, 49);
            this.btnViewRecipe.TabIndex = 7;
            this.btnViewRecipe.Text = "Show Table";
            this.btnViewRecipe.UseVisualStyleBackColor = true;
            this.btnViewRecipe.Click += new System.EventHandler(this.btnViewRecipe_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.label6.Location = new System.Drawing.Point(679, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(405, 32);
            this.label6.TabIndex = 28;
            this.label6.Text = "View Recipe Of Selected Food Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.label2.Location = new System.Drawing.Point(425, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Select Food:";
            // 
            // ViewRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1509, 747);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnViewRecipe);
            this.Controls.Add(this.recipeDataGridView);
            this.Controls.Add(this.selectRecipeItem);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewRecipe";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ViewOrderBtn;
        private System.Windows.Forms.Button ViewRecipeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.ComboBox selectRecipeItem;
        private System.Windows.Forms.DataGridView recipeDataGridView;
        private System.Windows.Forms.Button btnViewRecipe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
    }
}