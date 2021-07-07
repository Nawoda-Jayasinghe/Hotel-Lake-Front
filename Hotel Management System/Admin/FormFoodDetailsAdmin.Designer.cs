
namespace Hotel_Management_System
{
    partial class FormFoodDetailsAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbleCategoryDetailsAdmin = new System.Windows.Forms.DataGridView();
            this.CategoryIDCategoryTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryInfoCategoryTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbleFoodDetailsAdmin = new System.Windows.Forms.DataGridView();
            this.FoodIDSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodNameSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodPriceSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodCategoryIDSearchAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconBttnFoodSearchCashier = new FontAwesome.Sharp.IconButton();
            this.txtSearchFoodCashier = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbleCategoryDetailsAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbleFoodDetailsAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbleCategoryDetailsAdmin);
            this.panel1.Controls.Add(this.tbleFoodDetailsAdmin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.iconBttnFoodSearchCashier);
            this.panel1.Controls.Add(this.txtSearchFoodCashier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 584);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbleCategoryDetailsAdmin
            // 
            this.tbleCategoryDetailsAdmin.AllowUserToOrderColumns = true;
            this.tbleCategoryDetailsAdmin.AllowUserToResizeColumns = false;
            this.tbleCategoryDetailsAdmin.AllowUserToResizeRows = false;
            this.tbleCategoryDetailsAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbleCategoryDetailsAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbleCategoryDetailsAdmin.ColumnHeadersHeight = 75;
            this.tbleCategoryDetailsAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tbleCategoryDetailsAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryIDCategoryTable,
            this.CategoryInfoCategoryTable});
            this.tbleCategoryDetailsAdmin.Location = new System.Drawing.Point(674, 108);
            this.tbleCategoryDetailsAdmin.Name = "tbleCategoryDetailsAdmin";
            this.tbleCategoryDetailsAdmin.RowHeadersVisible = false;
            this.tbleCategoryDetailsAdmin.RowHeadersWidth = 51;
            this.tbleCategoryDetailsAdmin.RowTemplate.Height = 24;
            this.tbleCategoryDetailsAdmin.Size = new System.Drawing.Size(299, 339);
            this.tbleCategoryDetailsAdmin.TabIndex = 24;
            // 
            // CategoryIDCategoryTable
            // 
            this.CategoryIDCategoryTable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CategoryIDCategoryTable.FillWeight = 101.2478F;
            this.CategoryIDCategoryTable.Frozen = true;
            this.CategoryIDCategoryTable.HeaderText = "Category ID";
            this.CategoryIDCategoryTable.MinimumWidth = 6;
            this.CategoryIDCategoryTable.Name = "CategoryIDCategoryTable";
            this.CategoryIDCategoryTable.ReadOnly = true;
            this.CategoryIDCategoryTable.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryIDCategoryTable.Width = 115;
            // 
            // CategoryInfoCategoryTable
            // 
            this.CategoryInfoCategoryTable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CategoryInfoCategoryTable.FillWeight = 145.7974F;
            this.CategoryInfoCategoryTable.HeaderText = "Items";
            this.CategoryInfoCategoryTable.MinimumWidth = 6;
            this.CategoryInfoCategoryTable.Name = "CategoryInfoCategoryTable";
            this.CategoryInfoCategoryTable.ReadOnly = true;
            this.CategoryInfoCategoryTable.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tbleFoodDetailsAdmin
            // 
            this.tbleFoodDetailsAdmin.AllowUserToOrderColumns = true;
            this.tbleFoodDetailsAdmin.AllowUserToResizeColumns = false;
            this.tbleFoodDetailsAdmin.AllowUserToResizeRows = false;
            this.tbleFoodDetailsAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbleFoodDetailsAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbleFoodDetailsAdmin.ColumnHeadersHeight = 75;
            this.tbleFoodDetailsAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tbleFoodDetailsAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodIDSearch,
            this.FoodNameSearch,
            this.FoodPriceSearch,
            this.FoodCategoryIDSearchAdmin});
            this.tbleFoodDetailsAdmin.Location = new System.Drawing.Point(35, 108);
            this.tbleFoodDetailsAdmin.Name = "tbleFoodDetailsAdmin";
            this.tbleFoodDetailsAdmin.RowHeadersVisible = false;
            this.tbleFoodDetailsAdmin.RowHeadersWidth = 51;
            this.tbleFoodDetailsAdmin.RowTemplate.Height = 24;
            this.tbleFoodDetailsAdmin.Size = new System.Drawing.Size(570, 339);
            this.tbleFoodDetailsAdmin.TabIndex = 23;
            // 
            // FoodIDSearch
            // 
            this.FoodIDSearch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FoodIDSearch.FillWeight = 101.2478F;
            this.FoodIDSearch.Frozen = true;
            this.FoodIDSearch.HeaderText = "Food ID";
            this.FoodIDSearch.MinimumWidth = 6;
            this.FoodIDSearch.Name = "FoodIDSearch";
            this.FoodIDSearch.ReadOnly = true;
            this.FoodIDSearch.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FoodIDSearch.Width = 125;
            // 
            // FoodNameSearch
            // 
            this.FoodNameSearch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodNameSearch.FillWeight = 145.7974F;
            this.FoodNameSearch.HeaderText = "Name";
            this.FoodNameSearch.MinimumWidth = 6;
            this.FoodNameSearch.Name = "FoodNameSearch";
            this.FoodNameSearch.ReadOnly = true;
            this.FoodNameSearch.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FoodPriceSearch
            // 
            this.FoodPriceSearch.FillWeight = 71.97558F;
            this.FoodPriceSearch.HeaderText = "Price";
            this.FoodPriceSearch.MinimumWidth = 6;
            this.FoodPriceSearch.Name = "FoodPriceSearch";
            this.FoodPriceSearch.ReadOnly = true;
            this.FoodPriceSearch.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FoodPriceSearch.Width = 125;
            // 
            // FoodCategoryIDSearchAdmin
            // 
            this.FoodCategoryIDSearchAdmin.FillWeight = 84.7226F;
            this.FoodCategoryIDSearchAdmin.HeaderText = "Category ID";
            this.FoodCategoryIDSearchAdmin.MinimumWidth = 6;
            this.FoodCategoryIDSearchAdmin.Name = "FoodCategoryIDSearchAdmin";
            this.FoodCategoryIDSearchAdmin.Width = 115;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel3.Location = new System.Drawing.Point(640, -5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 608);
            this.panel3.TabIndex = 19;
            // 
            // iconBttnFoodSearchCashier
            // 
            this.iconBttnFoodSearchCashier.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconBttnFoodSearchCashier.IconColor = System.Drawing.Color.Black;
            this.iconBttnFoodSearchCashier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBttnFoodSearchCashier.IconSize = 30;
            this.iconBttnFoodSearchCashier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBttnFoodSearchCashier.Location = new System.Drawing.Point(380, 27);
            this.iconBttnFoodSearchCashier.Name = "iconBttnFoodSearchCashier";
            this.iconBttnFoodSearchCashier.Size = new System.Drawing.Size(34, 31);
            this.iconBttnFoodSearchCashier.TabIndex = 3;
            this.iconBttnFoodSearchCashier.UseVisualStyleBackColor = true;
            // 
            // txtSearchFoodCashier
            // 
            this.txtSearchFoodCashier.Location = new System.Drawing.Point(35, 31);
            this.txtSearchFoodCashier.Name = "txtSearchFoodCashier";
            this.txtSearchFoodCashier.Size = new System.Drawing.Size(297, 22);
            this.txtSearchFoodCashier.TabIndex = 2;
            this.txtSearchFoodCashier.Text = "Search";
            // 
            // FormFoodDetailsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1003, 584);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Name = "FormFoodDetailsAdmin";
            this.Text = "Food Details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbleCategoryDetailsAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbleFoodDetailsAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconBttnFoodSearchCashier;
        private System.Windows.Forms.TextBox txtSearchFoodCashier;
        private System.Windows.Forms.DataGridView tbleFoodDetailsAdmin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodIDSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodNameSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodPriceSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodCategoryIDSearchAdmin;
        private System.Windows.Forms.DataGridView tbleCategoryDetailsAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryIDCategoryTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryInfoCategoryTable;
    }
}