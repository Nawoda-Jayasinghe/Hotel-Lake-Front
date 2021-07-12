
namespace Hotel_Management_System
{
    partial class FormFoodDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblFoodDetails = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.iconBttnFoodSearchCashier = new FontAwesome.Sharp.IconButton();
            this.txtSearchFoodCashier = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tblFoodDetails
            // 
            this.tblFoodDetails.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tblFoodDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblFoodDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblFoodDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tblFoodDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblFoodDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblFoodDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblFoodDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblFoodDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblFoodDetails.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tblFoodDetails.Location = new System.Drawing.Point(0, 98);
            this.tblFoodDetails.Name = "tblFoodDetails";
            this.tblFoodDetails.RowHeadersVisible = false;
            this.tblFoodDetails.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.tblFoodDetails.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tblFoodDetails.RowTemplate.Height = 24;
            this.tblFoodDetails.Size = new System.Drawing.Size(1003, 486);
            this.tblFoodDetails.TabIndex = 29;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Food ID";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Food Item";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(517, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 33);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Breakfast";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(517, 59);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(99, 33);
            this.checkBox2.TabIndex = 31;
            this.checkBox2.Text = "Lunch";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(659, 59);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(106, 33);
            this.checkBox3.TabIndex = 32;
            this.checkBox3.Text = "Dinner";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(821, 59);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(113, 33);
            this.checkBox4.TabIndex = 33;
            this.checkBox4.Text = "Snacks";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(659, 25);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(139, 33);
            this.checkBox5.TabIndex = 34;
            this.checkBox5.Text = "Beverage";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(821, 25);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(130, 33);
            this.checkBox6.TabIndex = 35;
            this.checkBox6.Text = "Desserts";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(427, 30);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(62, 33);
            this.checkBox7.TabIndex = 36;
            this.checkBox7.Text = "All";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // iconBttnFoodSearchCashier
            // 
            this.iconBttnFoodSearchCashier.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconBttnFoodSearchCashier.IconColor = System.Drawing.Color.Black;
            this.iconBttnFoodSearchCashier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBttnFoodSearchCashier.IconSize = 30;
            this.iconBttnFoodSearchCashier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBttnFoodSearchCashier.Location = new System.Drawing.Point(311, 34);
            this.iconBttnFoodSearchCashier.Name = "iconBttnFoodSearchCashier";
            this.iconBttnFoodSearchCashier.Size = new System.Drawing.Size(34, 31);
            this.iconBttnFoodSearchCashier.TabIndex = 38;
            this.iconBttnFoodSearchCashier.UseVisualStyleBackColor = true;
            // 
            // txtSearchFoodCashier
            // 
            this.txtSearchFoodCashier.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchFoodCashier.Location = new System.Drawing.Point(12, 38);
            this.txtSearchFoodCashier.Name = "txtSearchFoodCashier";
            this.txtSearchFoodCashier.Size = new System.Drawing.Size(293, 22);
            this.txtSearchFoodCashier.TabIndex = 37;
            this.txtSearchFoodCashier.Text = "Search";
            this.txtSearchFoodCashier.Enter += new System.EventHandler(this.txtSearchFoodCashier_Enter);
            this.txtSearchFoodCashier.Leave += new System.EventHandler(this.txtSearchFoodCashier_Leave);
            // 
            // FormFoodDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1003, 584);
            this.Controls.Add(this.iconBttnFoodSearchCashier);
            this.Controls.Add(this.txtSearchFoodCashier);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tblFoodDetails);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Name = "FormFoodDetails";
            this.Text = "Restaurant";
            this.Load += new System.EventHandler(this.FormFoodDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblFoodDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private FontAwesome.Sharp.IconButton iconBttnFoodSearchCashier;
        private System.Windows.Forms.TextBox txtSearchFoodCashier;
    }
}