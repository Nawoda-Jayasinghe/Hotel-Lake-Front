﻿
namespace Hotel_Management_System
{
    partial class FormMainCashier
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnOrders = new FontAwesome.Sharp.IconButton();
            this.btnPayments = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.titleCurrent = new System.Windows.Forms.Label();
            this.iconCurrent = new FontAwesome.Sharp.IconPictureBox();
            this.panelS = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnOrders);
            this.panelMenu.Controls.Add(this.btnPayments);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(307, 885);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnOrders
            // 
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Candara", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.IconChar = FontAwesome.Sharp.IconChar.PeopleArrows;
            this.btnOrders.IconColor = System.Drawing.Color.White;
            this.btnOrders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrders.IconSize = 60;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(0, 489);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOrders.Size = new System.Drawing.Size(307, 244);
            this.btnOrders.TabIndex = 6;
            this.btnOrders.Text = "Orders";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Candara", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnPayments.IconColor = System.Drawing.Color.White;
            this.btnPayments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPayments.IconSize = 60;
            this.btnPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.Location = new System.Drawing.Point(0, 245);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPayments.Size = new System.Drawing.Size(307, 244);
            this.btnPayments.TabIndex = 5;
            this.btnPayments.Text = "Payments";
            this.btnPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.panel2);
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(307, 245);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.panel2.Location = new System.Drawing.Point(0, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 8);
            this.panel2.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::Hotel_Management_System.Properties.Resources.looog_01;
            this.btnHome.Location = new System.Drawing.Point(-42, -15);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(399, 296);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.titleCurrent);
            this.panel1.Controls.Add(this.iconCurrent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(307, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 75);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Red;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.DotCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Red;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 35;
            this.iconPictureBox1.Location = new System.Drawing.Point(1206, 13);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(48, 35);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // titleCurrent
            // 
            this.titleCurrent.AutoSize = true;
            this.titleCurrent.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleCurrent.ForeColor = System.Drawing.Color.White;
            this.titleCurrent.Location = new System.Drawing.Point(61, 14);
            this.titleCurrent.Name = "titleCurrent";
            this.titleCurrent.Size = new System.Drawing.Size(86, 35);
            this.titleCurrent.TabIndex = 2;
            this.titleCurrent.Text = "Home";
            this.titleCurrent.Click += new System.EventHandler(this.titleCurrent_Click);
            // 
            // iconCurrent
            // 
            this.iconCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrent.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrent.IconColor = System.Drawing.Color.White;
            this.iconCurrent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrent.Location = new System.Drawing.Point(23, 18);
            this.iconCurrent.Name = "iconCurrent";
            this.iconCurrent.Size = new System.Drawing.Size(32, 32);
            this.iconCurrent.TabIndex = 1;
            this.iconCurrent.TabStop = false;
            this.iconCurrent.Click += new System.EventHandler(this.iconCurrent_Click);
            // 
            // panelS
            // 
            this.panelS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelS.Location = new System.Drawing.Point(307, 75);
            this.panelS.Name = "panelS";
            this.panelS.Size = new System.Drawing.Size(1257, 9);
            this.panelS.TabIndex = 2;
            this.panelS.Paint += new System.Windows.Forms.PaintEventHandler(this.panelS_Paint);
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoSize = true;
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelDesktop.Location = new System.Drawing.Point(307, 84);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1257, 801);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelD_Paint);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // FormMainCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 885);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelS);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMainCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New";
            this.Load += new System.EventHandler(this.New_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnPayments;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrent;
        private System.Windows.Forms.Panel panelS;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnOrders;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label titleCurrent;
        private System.Windows.Forms.Panel panel2;
    }
}