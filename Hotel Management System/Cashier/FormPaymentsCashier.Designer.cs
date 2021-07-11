
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
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFoodTotalCashier = new System.Windows.Forms.Label();
            this.iconBttnAddFoodCashier = new FontAwesome.Sharp.IconButton();
            this.lblFoodNameCashier = new System.Windows.Forms.Label();
            this.txtFoodQuantityCashier = new System.Windows.Forms.TextBox();
            this.iconBttnFoodSearchOrdersCashier = new FontAwesome.Sharp.IconButton();
            this.txtSearchPayments2 = new System.Windows.Forms.TextBox();
            this.tbleFoodOrderDetailsCashier = new System.Windows.Forms.DataGridView();
            this.FoodIDPayments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodNamePayments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityPayments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodPricePayments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodSelectPayments = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbleFoodDetailsCashier = new System.Windows.Forms.DataGridView();
            this.FoodIDSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodNameSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodPriceSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconBttnFoodSearchCashier = new FontAwesome.Sharp.IconButton();
            this.txtSearchPayments1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbleFoodOrderDetailsCashier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbleFoodDetailsCashier)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.iconButton4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblFoodTotalCashier);
            this.panel1.Controls.Add(this.iconBttnAddFoodCashier);
            this.panel1.Controls.Add(this.lblFoodNameCashier);
            this.panel1.Controls.Add(this.txtFoodQuantityCashier);
            this.panel1.Controls.Add(this.iconBttnFoodSearchOrdersCashier);
            this.panel1.Controls.Add(this.txtSearchPayments2);
            this.panel1.Controls.Add(this.tbleFoodOrderDetailsCashier);
            this.panel1.Controls.Add(this.tbleFoodDetailsCashier);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.iconBttnFoodSearchCashier);
            this.panel1.Controls.Add(this.txtSearchPayments1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 584);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconButton3
            // 
            this.iconButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Paypal;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 50;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton3.Location = new System.Drawing.Point(869, 467);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(100, 95);
            this.iconButton3.TabIndex = 7;
            this.iconButton3.Text = "Card";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 50;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton4.Location = new System.Drawing.Point(763, 467);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(100, 95);
            this.iconButton4.TabIndex = 6;
            this.iconButton4.Text = "Cash";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 42);
            this.label2.TabIndex = 47;
            this.label2.Text = "LKR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFoodTotalCashier
            // 
            this.lblFoodTotalCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodTotalCashier.Location = new System.Drawing.Point(516, 490);
            this.lblFoodTotalCashier.Name = "lblFoodTotalCashier";
            this.lblFoodTotalCashier.Size = new System.Drawing.Size(127, 42);
            this.lblFoodTotalCashier.TabIndex = 46;
            this.lblFoodTotalCashier.Text = "0.00";
            this.lblFoodTotalCashier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.iconBttnAddFoodCashier.Location = new System.Drawing.Point(860, 84);
            this.iconBttnAddFoodCashier.Name = "iconBttnAddFoodCashier";
            this.iconBttnAddFoodCashier.Size = new System.Drawing.Size(40, 40);
            this.iconBttnAddFoodCashier.TabIndex = 4;
            this.iconBttnAddFoodCashier.UseVisualStyleBackColor = true;
            // 
            // lblFoodNameCashier
            // 
            this.lblFoodNameCashier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFoodNameCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodNameCashier.Location = new System.Drawing.Point(479, 92);
            this.lblFoodNameCashier.Name = "lblFoodNameCashier";
            this.lblFoodNameCashier.Size = new System.Drawing.Size(252, 25);
            this.lblFoodNameCashier.TabIndex = 43;
            this.lblFoodNameCashier.Text = "Chicken Cheese Kottu (L)";
            this.lblFoodNameCashier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFoodQuantityCashier
            // 
            this.txtFoodQuantityCashier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtFoodQuantityCashier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFoodQuantityCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodQuantityCashier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFoodQuantityCashier.Location = new System.Drawing.Point(788, 89);
            this.txtFoodQuantityCashier.Name = "txtFoodQuantityCashier";
            this.txtFoodQuantityCashier.Size = new System.Drawing.Size(34, 30);
            this.txtFoodQuantityCashier.TabIndex = 42;
            this.txtFoodQuantityCashier.Text = "3";
            // 
            // iconBttnFoodSearchOrdersCashier
            // 
            this.iconBttnFoodSearchOrdersCashier.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconBttnFoodSearchOrdersCashier.IconColor = System.Drawing.Color.Black;
            this.iconBttnFoodSearchOrdersCashier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBttnFoodSearchOrdersCashier.IconSize = 30;
            this.iconBttnFoodSearchOrdersCashier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBttnFoodSearchOrdersCashier.Location = new System.Drawing.Point(931, 26);
            this.iconBttnFoodSearchOrdersCashier.Name = "iconBttnFoodSearchOrdersCashier";
            this.iconBttnFoodSearchOrdersCashier.Size = new System.Drawing.Size(34, 31);
            this.iconBttnFoodSearchOrdersCashier.TabIndex = 41;
            this.iconBttnFoodSearchOrdersCashier.UseVisualStyleBackColor = true;
            // 
            // txtSearchPayments2
            // 
            this.txtSearchPayments2.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchPayments2.Location = new System.Drawing.Point(421, 27);
            this.txtSearchPayments2.Name = "txtSearchPayments2";
            this.txtSearchPayments2.Size = new System.Drawing.Size(504, 22);
            this.txtSearchPayments2.TabIndex = 2;
            this.txtSearchPayments2.Text = "Search";
            this.txtSearchPayments2.Enter += new System.EventHandler(this.txtSearchPayments2_Enter);
            this.txtSearchPayments2.Leave += new System.EventHandler(this.txtSearchPayments2_Leave);
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
            this.tbleFoodOrderDetailsCashier.Location = new System.Drawing.Point(402, 144);
            this.tbleFoodOrderDetailsCashier.Name = "tbleFoodOrderDetailsCashier";
            this.tbleFoodOrderDetailsCashier.RowHeadersVisible = false;
            this.tbleFoodOrderDetailsCashier.RowHeadersWidth = 51;
            this.tbleFoodOrderDetailsCashier.RowTemplate.Height = 24;
            this.tbleFoodOrderDetailsCashier.Size = new System.Drawing.Size(589, 309);
            this.tbleFoodOrderDetailsCashier.TabIndex = 5;
            this.tbleFoodOrderDetailsCashier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbleFoodOrderDetailsCashier_CellContentClick);
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
            this.tbleFoodDetailsCashier.Size = new System.Drawing.Size(329, 439);
            this.tbleFoodDetailsCashier.TabIndex = 1;
            this.tbleFoodDetailsCashier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbleFoodDetailsCashier_CellContentClick);
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
            this.iconBttnFoodSearchCashier.Location = new System.Drawing.Point(309, 30);
            this.iconBttnFoodSearchCashier.Name = "iconBttnFoodSearchCashier";
            this.iconBttnFoodSearchCashier.Size = new System.Drawing.Size(34, 31);
            this.iconBttnFoodSearchCashier.TabIndex = 3;
            this.iconBttnFoodSearchCashier.UseVisualStyleBackColor = true;
            // 
            // txtSearchPayments1
            // 
            this.txtSearchPayments1.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchPayments1.Location = new System.Drawing.Point(44, 30);
            this.txtSearchPayments1.Name = "txtSearchPayments1";
            this.txtSearchPayments1.Size = new System.Drawing.Size(259, 22);
            this.txtSearchPayments1.TabIndex = 0;
            this.txtSearchPayments1.Text = "Search";
            this.txtSearchPayments1.Enter += new System.EventHandler(this.txtSearchPayments1_Enter);
            this.txtSearchPayments1.Leave += new System.EventHandler(this.txtSearchPayments1_Leave);
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
        private System.Windows.Forms.TextBox txtSearchPayments1;
        private System.Windows.Forms.DataGridView tbleFoodDetailsCashier;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView tbleFoodOrderDetailsCashier;
        private FontAwesome.Sharp.IconButton iconBttnFoodSearchOrdersCashier;
        private System.Windows.Forms.TextBox txtSearchPayments2;
        private System.Windows.Forms.TextBox txtFoodQuantityCashier;
        private System.Windows.Forms.Label lblFoodNameCashier;
        private FontAwesome.Sharp.IconButton iconBttnAddFoodCashier;
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
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}