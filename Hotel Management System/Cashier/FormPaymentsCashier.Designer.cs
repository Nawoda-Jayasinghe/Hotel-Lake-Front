
namespace Hotel_Management_System
{
    partial class FormPaymentsCashier
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblFoodTotalCashier = new System.Windows.Forms.Label();
            this.iconBttnFoodCreditOrdersCashier = new FontAwesome.Sharp.IconButton();
            this.iconBttnAddFoodCashier = new FontAwesome.Sharp.IconButton();
            this.lblFoodNameCashier = new System.Windows.Forms.Label();
            this.txtFoodQuantityCashier = new System.Windows.Forms.TextBox();
            this.iconBttnFoodSearchOrdersCashier = new FontAwesome.Sharp.IconButton();
            this.txtSearchFoodOrdersCashier = new System.Windows.Forms.TextBox();
            this.tbleFoodOrderDetailsCashier = new System.Windows.Forms.DataGridView();
            this.tbleFoodDetailsCashier = new System.Windows.Forms.DataGridView();
            this.iconBttnFoodCardOrdersCashier = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconBttnFoodSearchCashier = new FontAwesome.Sharp.IconButton();
            this.txtSearchFoodCashier = new System.Windows.Forms.TextBox();
            this.FoodIDPayments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodNamePayments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityPayments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodPricePayments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodSelectPayments = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FoodIDSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodNameSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodPriceSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbleFoodOrderDetailsCashier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbleFoodDetailsCashier)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblFoodTotalCashier);
            this.panel1.Controls.Add(this.iconBttnFoodCreditOrdersCashier);
            this.panel1.Controls.Add(this.iconBttnAddFoodCashier);
            this.panel1.Controls.Add(this.lblFoodNameCashier);
            this.panel1.Controls.Add(this.txtFoodQuantityCashier);
            this.panel1.Controls.Add(this.iconBttnFoodSearchOrdersCashier);
            this.panel1.Controls.Add(this.txtSearchFoodOrdersCashier);
            this.panel1.Controls.Add(this.tbleFoodOrderDetailsCashier);
            this.panel1.Controls.Add(this.tbleFoodDetailsCashier);
            this.panel1.Controls.Add(this.iconBttnFoodCardOrdersCashier);
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 42);
            this.label2.TabIndex = 47;
            this.label2.Text = "LKR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFoodTotalCashier
            // 
            this.lblFoodTotalCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodTotalCashier.Location = new System.Drawing.Point(598, 490);
            this.lblFoodTotalCashier.Name = "lblFoodTotalCashier";
            this.lblFoodTotalCashier.Size = new System.Drawing.Size(127, 42);
            this.lblFoodTotalCashier.TabIndex = 46;
            this.lblFoodTotalCashier.Text = "0.00";
            this.lblFoodTotalCashier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // iconBttnFoodCreditOrdersCashier
            // 
            this.iconBttnFoodCreditOrdersCashier.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.iconBttnFoodCreditOrdersCashier.IconColor = System.Drawing.Color.Black;
            this.iconBttnFoodCreditOrdersCashier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBttnFoodCreditOrdersCashier.IconSize = 40;
            this.iconBttnFoodCreditOrdersCashier.Location = new System.Drawing.Point(794, 454);
            this.iconBttnFoodCreditOrdersCashier.Name = "iconBttnFoodCreditOrdersCashier";
            this.iconBttnFoodCreditOrdersCashier.Size = new System.Drawing.Size(166, 45);
            this.iconBttnFoodCreditOrdersCashier.TabIndex = 45;
            this.iconBttnFoodCreditOrdersCashier.UseVisualStyleBackColor = true;
            // 
            // iconBttnAddFoodCashier
            // 
            this.iconBttnAddFoodCashier.FlatAppearance.BorderSize = 0;
            this.iconBttnAddFoodCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBttnAddFoodCashier.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconBttnAddFoodCashier.IconColor = System.Drawing.Color.White;
            this.iconBttnAddFoodCashier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBttnAddFoodCashier.IconSize = 40;
            this.iconBttnAddFoodCashier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBttnAddFoodCashier.Location = new System.Drawing.Point(880, 88);
            this.iconBttnAddFoodCashier.Name = "iconBttnAddFoodCashier";
            this.iconBttnAddFoodCashier.Size = new System.Drawing.Size(40, 40);
            this.iconBttnAddFoodCashier.TabIndex = 44;
            this.iconBttnAddFoodCashier.UseVisualStyleBackColor = true;
            // 
            // lblFoodNameCashier
            // 
            this.lblFoodNameCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodNameCashier.Location = new System.Drawing.Point(418, 86);
            this.lblFoodNameCashier.Name = "lblFoodNameCashier";
            this.lblFoodNameCashier.Size = new System.Drawing.Size(356, 42);
            this.lblFoodNameCashier.TabIndex = 43;
            this.lblFoodNameCashier.Text = "Food Name";
            this.lblFoodNameCashier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFoodQuantityCashier
            // 
            this.txtFoodQuantityCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodQuantityCashier.Location = new System.Drawing.Point(825, 92);
            this.txtFoodQuantityCashier.Name = "txtFoodQuantityCashier";
            this.txtFoodQuantityCashier.Size = new System.Drawing.Size(34, 30);
            this.txtFoodQuantityCashier.TabIndex = 42;
            // 
            // iconBttnFoodSearchOrdersCashier
            // 
            this.iconBttnFoodSearchOrdersCashier.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconBttnFoodSearchOrdersCashier.IconColor = System.Drawing.Color.Black;
            this.iconBttnFoodSearchOrdersCashier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBttnFoodSearchOrdersCashier.IconSize = 30;
            this.iconBttnFoodSearchOrdersCashier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBttnFoodSearchOrdersCashier.Location = new System.Drawing.Point(880, 26);
            this.iconBttnFoodSearchOrdersCashier.Name = "iconBttnFoodSearchOrdersCashier";
            this.iconBttnFoodSearchOrdersCashier.Size = new System.Drawing.Size(34, 31);
            this.iconBttnFoodSearchOrdersCashier.TabIndex = 41;
            this.iconBttnFoodSearchOrdersCashier.UseVisualStyleBackColor = true;
            // 
            // txtSearchFoodOrdersCashier
            // 
            this.txtSearchFoodOrdersCashier.Location = new System.Drawing.Point(421, 27);
            this.txtSearchFoodOrdersCashier.Name = "txtSearchFoodOrdersCashier";
            this.txtSearchFoodOrdersCashier.Size = new System.Drawing.Size(438, 22);
            this.txtSearchFoodOrdersCashier.TabIndex = 40;
            this.txtSearchFoodOrdersCashier.Text = "Search";
            // 
            // tbleFoodOrderDetailsCashier
            // 
            this.tbleFoodOrderDetailsCashier.AllowUserToOrderColumns = true;
            this.tbleFoodOrderDetailsCashier.AllowUserToResizeColumns = false;
            this.tbleFoodOrderDetailsCashier.AllowUserToResizeRows = false;
            this.tbleFoodOrderDetailsCashier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbleFoodOrderDetailsCashier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbleFoodOrderDetailsCashier.ColumnHeadersHeight = 55;
            this.tbleFoodOrderDetailsCashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tbleFoodOrderDetailsCashier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodIDPayments,
            this.FoodNamePayments,
            this.QuantityPayments,
            this.FoodPricePayments,
            this.FoodSelectPayments});
            this.tbleFoodOrderDetailsCashier.Location = new System.Drawing.Point(421, 152);
            this.tbleFoodOrderDetailsCashier.Name = "tbleFoodOrderDetailsCashier";
            this.tbleFoodOrderDetailsCashier.RowHeadersVisible = false;
            this.tbleFoodOrderDetailsCashier.RowHeadersWidth = 51;
            this.tbleFoodOrderDetailsCashier.RowTemplate.Height = 24;
            this.tbleFoodOrderDetailsCashier.Size = new System.Drawing.Size(499, 258);
            this.tbleFoodOrderDetailsCashier.TabIndex = 29;
            this.tbleFoodOrderDetailsCashier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbleFoodOrderDetailsCashier_CellContentClick);
            // 
            // tbleFoodDetailsCashier
            // 
            this.tbleFoodDetailsCashier.AllowUserToOrderColumns = true;
            this.tbleFoodDetailsCashier.AllowUserToResizeColumns = false;
            this.tbleFoodDetailsCashier.AllowUserToResizeRows = false;
            this.tbleFoodDetailsCashier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbleFoodDetailsCashier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbleFoodDetailsCashier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbleFoodDetailsCashier.ColumnHeadersHeight = 55;
            this.tbleFoodDetailsCashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tbleFoodDetailsCashier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodIDSearch,
            this.FoodNameSearch,
            this.FoodPriceSearch});
            this.tbleFoodDetailsCashier.Location = new System.Drawing.Point(24, 103);
            this.tbleFoodDetailsCashier.Name = "tbleFoodDetailsCashier";
            this.tbleFoodDetailsCashier.RowHeadersVisible = false;
            this.tbleFoodDetailsCashier.RowHeadersWidth = 51;
            this.tbleFoodDetailsCashier.RowTemplate.Height = 24;
            this.tbleFoodDetailsCashier.Size = new System.Drawing.Size(329, 357);
            this.tbleFoodDetailsCashier.TabIndex = 23;
            this.tbleFoodDetailsCashier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbleFoodDetailsCashier_CellContentClick);
            // 
            // iconBttnFoodCardOrdersCashier
            // 
            this.iconBttnFoodCardOrdersCashier.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.iconBttnFoodCardOrdersCashier.IconColor = System.Drawing.Color.Black;
            this.iconBttnFoodCardOrdersCashier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBttnFoodCardOrdersCashier.IconSize = 40;
            this.iconBttnFoodCardOrdersCashier.Location = new System.Drawing.Point(794, 517);
            this.iconBttnFoodCardOrdersCashier.Name = "iconBttnFoodCardOrdersCashier";
            this.iconBttnFoodCardOrdersCashier.Size = new System.Drawing.Size(166, 45);
            this.iconBttnFoodCardOrdersCashier.TabIndex = 20;
            this.iconBttnFoodCardOrdersCashier.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel3.Location = new System.Drawing.Point(382, -12);
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
            this.iconBttnFoodSearchCashier.Location = new System.Drawing.Point(277, 26);
            this.iconBttnFoodSearchCashier.Name = "iconBttnFoodSearchCashier";
            this.iconBttnFoodSearchCashier.Size = new System.Drawing.Size(34, 31);
            this.iconBttnFoodSearchCashier.TabIndex = 3;
            this.iconBttnFoodSearchCashier.UseVisualStyleBackColor = true;
            // 
            // txtSearchFoodCashier
            // 
            this.txtSearchFoodCashier.Location = new System.Drawing.Point(24, 30);
            this.txtSearchFoodCashier.Name = "txtSearchFoodCashier";
            this.txtSearchFoodCashier.Size = new System.Drawing.Size(227, 22);
            this.txtSearchFoodCashier.TabIndex = 2;
            this.txtSearchFoodCashier.Text = "Search";
            // 
            // FoodIDPayments
            // 
            this.FoodIDPayments.HeaderText = "Food ID";
            this.FoodIDPayments.MinimumWidth = 6;
            this.FoodIDPayments.Name = "FoodIDPayments";
            this.FoodIDPayments.Width = 125;
            // 
            // FoodNamePayments
            // 
            this.FoodNamePayments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodNamePayments.HeaderText = "Name";
            this.FoodNamePayments.MinimumWidth = 6;
            this.FoodNamePayments.Name = "FoodNamePayments";
            // 
            // QuantityPayments
            // 
            this.QuantityPayments.HeaderText = "Quantity";
            this.QuantityPayments.MinimumWidth = 6;
            this.QuantityPayments.Name = "QuantityPayments";
            this.QuantityPayments.Width = 115;
            // 
            // FoodPricePayments
            // 
            this.FoodPricePayments.HeaderText = "Price";
            this.FoodPricePayments.MinimumWidth = 6;
            this.FoodPricePayments.Name = "FoodPricePayments";
            this.FoodPricePayments.Width = 99;
            // 
            // FoodSelectPayments
            // 
            this.FoodSelectPayments.HeaderText = "";
            this.FoodSelectPayments.MinimumWidth = 6;
            this.FoodSelectPayments.Name = "FoodSelectPayments";
            this.FoodSelectPayments.Width = 30;
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
            this.FoodNameSearch.FillWeight = 101.2478F;
            this.FoodNameSearch.HeaderText = "Name";
            this.FoodNameSearch.MinimumWidth = 6;
            this.FoodNameSearch.Name = "FoodNameSearch";
            this.FoodNameSearch.ReadOnly = true;
            this.FoodNameSearch.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FoodPriceSearch
            // 
            this.FoodPriceSearch.FillWeight = 101.2478F;
            this.FoodPriceSearch.HeaderText = "Price";
            this.FoodPriceSearch.MinimumWidth = 6;
            this.FoodPriceSearch.Name = "FoodPriceSearch";
            this.FoodPriceSearch.ReadOnly = true;
            this.FoodPriceSearch.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FormPaymentsCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1003, 584);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Name = "FormPaymentsCashier";
            this.Text = "Payments";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbleFoodOrderDetailsCashier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbleFoodDetailsCashier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconBttnFoodSearchCashier;
        private System.Windows.Forms.TextBox txtSearchFoodCashier;
        private FontAwesome.Sharp.IconButton iconBttnFoodCardOrdersCashier;
        private System.Windows.Forms.DataGridView tbleFoodDetailsCashier;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView tbleFoodOrderDetailsCashier;
        private FontAwesome.Sharp.IconButton iconBttnFoodSearchOrdersCashier;
        private System.Windows.Forms.TextBox txtSearchFoodOrdersCashier;
        private System.Windows.Forms.TextBox txtFoodQuantityCashier;
        private System.Windows.Forms.Label lblFoodNameCashier;
        private FontAwesome.Sharp.IconButton iconBttnAddFoodCashier;
        private FontAwesome.Sharp.IconButton iconBttnFoodCreditOrdersCashier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFoodTotalCashier;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodIDPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodNamePayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodPricePayments;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FoodSelectPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodIDSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodNameSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodPriceSearch;
    }
}