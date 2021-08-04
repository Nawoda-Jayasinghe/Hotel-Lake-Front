
namespace Hotel_Management_System
{
    partial class FormFacilityPricesAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFID = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtFprice = new System.Windows.Forms.TextBox();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.tblFoodDetails = new System.Windows.Forms.DataGridView();
            this.iconBttnFoodSearchCashier = new FontAwesome.Sharp.IconButton();
            this.txtSearchFacility = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFID
            // 
            this.lblFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFID.Location = new System.Drawing.Point(220, 413);
            this.lblFID.Name = "lblFID";
            this.lblFID.Size = new System.Drawing.Size(344, 31);
            this.lblFID.TabIndex = 480;
            // 
            // txtFname
            // 
            this.txtFname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFname.Location = new System.Drawing.Point(225, 451);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(339, 41);
            this.txtFname.TabIndex = 478;
            this.txtFname.Enter += new System.EventHandler(this.txtFname_Enter);
            // 
            // txtFprice
            // 
            this.txtFprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtFprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFprice.Location = new System.Drawing.Point(225, 491);
            this.txtFprice.Name = "txtFprice";
            this.txtFprice.Size = new System.Drawing.Size(182, 41);
            this.txtFprice.TabIndex = 477;
            this.txtFprice.Enter += new System.EventHandler(this.txtFprice_Enter);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReset.IconColor = System.Drawing.Color.Black;
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.Location = new System.Drawing.Point(729, 513);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 52);
            this.btnReset.TabIndex = 475;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.Location = new System.Drawing.Point(855, 513);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 52);
            this.btnUpdate.TabIndex = 476;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tblFoodDetails
            // 
            this.tblFoodDetails.AllowUserToAddRows = false;
            this.tblFoodDetails.AllowUserToDeleteRows = false;
            this.tblFoodDetails.AllowUserToResizeColumns = false;
            this.tblFoodDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.tblFoodDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.tblFoodDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblFoodDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tblFoodDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblFoodDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.tblFoodDetails.ColumnHeadersHeight = 50;
            this.tblFoodDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblFoodDetails.DefaultCellStyle = dataGridViewCellStyle19;
            this.tblFoodDetails.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tblFoodDetails.Location = new System.Drawing.Point(45, 106);
            this.tblFoodDetails.Name = "tblFoodDetails";
            this.tblFoodDetails.ReadOnly = true;
            this.tblFoodDetails.RowHeadersVisible = false;
            this.tblFoodDetails.RowHeadersWidth = 51;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tblFoodDetails.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.tblFoodDetails.RowTemplate.Height = 35;
            this.tblFoodDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblFoodDetails.Size = new System.Drawing.Size(921, 227);
            this.tblFoodDetails.TabIndex = 474;
            this.tblFoodDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblFoodDetails_CellClick);
            // 
            // iconBttnFoodSearchCashier
            // 
            this.iconBttnFoodSearchCashier.Enabled = false;
            this.iconBttnFoodSearchCashier.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconBttnFoodSearchCashier.IconColor = System.Drawing.Color.Black;
            this.iconBttnFoodSearchCashier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBttnFoodSearchCashier.IconSize = 30;
            this.iconBttnFoodSearchCashier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBttnFoodSearchCashier.Location = new System.Drawing.Point(657, 22);
            this.iconBttnFoodSearchCashier.Name = "iconBttnFoodSearchCashier";
            this.iconBttnFoodSearchCashier.Size = new System.Drawing.Size(34, 31);
            this.iconBttnFoodSearchCashier.TabIndex = 472;
            this.iconBttnFoodSearchCashier.UseVisualStyleBackColor = true;
            // 
            // txtSearchFacility
            // 
            this.txtSearchFacility.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchFacility.Location = new System.Drawing.Point(334, 26);
            this.txtSearchFacility.Name = "txtSearchFacility";
            this.txtSearchFacility.Size = new System.Drawing.Size(293, 22);
            this.txtSearchFacility.TabIndex = 471;
            this.txtSearchFacility.Text = "Search";
            this.txtSearchFacility.TextChanged += new System.EventHandler(this.txtSearchFoodCashier_TextChanged);
            this.txtSearchFacility.Enter += new System.EventHandler(this.txtSearchFoodCashier_Enter);
            this.txtSearchFacility.Leave += new System.EventHandler(this.txtSearchFoodCashier_Leave);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 31);
            this.label3.TabIndex = 466;
            this.label3.Text = "Price per Day:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 465;
            this.label1.Text = "Facility Name :";
            // 
            // label39
            // 
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(25, 416);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(143, 31);
            this.label39.TabIndex = 464;
            this.label39.Text = "Facility ID :";
            // 
            // FormFacilityPricesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1003, 584);
            this.Controls.Add(this.lblFID);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.txtFprice);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tblFoodDetails);
            this.Controls.Add(this.iconBttnFoodSearchCashier);
            this.Controls.Add(this.txtSearchFacility);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label39);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Name = "FormFacilityPricesAdmin";
            this.Text = "Facility Prices";
            this.Load += new System.EventHandler(this.FormRestaurant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFID;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtFprice;
        private FontAwesome.Sharp.IconButton btnReset;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private System.Windows.Forms.DataGridView tblFoodDetails;
        private FontAwesome.Sharp.IconButton iconBttnFoodSearchCashier;
        private System.Windows.Forms.TextBox txtSearchFacility;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label39;
    }
}