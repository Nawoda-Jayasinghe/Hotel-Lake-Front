
namespace Hotel_Management_System
{
    partial class FormMain
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
            this.btnNotifications = new FontAwesome.Sharp.IconButton();
            this.btnPayments = new FontAwesome.Sharp.IconButton();
            this.btnStaffDetails = new FontAwesome.Sharp.IconButton();
            this.btnFoodDetails = new FontAwesome.Sharp.IconButton();
            this.btnRoomDetails = new FontAwesome.Sharp.IconButton();
            this.btnGuestDetails = new FontAwesome.Sharp.IconButton();
            this.btnNewGuest = new FontAwesome.Sharp.IconButton();
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrent)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnNotifications);
            this.panelMenu.Controls.Add(this.btnPayments);
            this.panelMenu.Controls.Add(this.btnStaffDetails);
            this.panelMenu.Controls.Add(this.btnFoodDetails);
            this.panelMenu.Controls.Add(this.btnRoomDetails);
            this.panelMenu.Controls.Add(this.btnGuestDetails);
            this.panelMenu.Controls.Add(this.btnNewGuest);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(307, 885);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnNotifications
            // 
            this.btnNotifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotifications.FlatAppearance.BorderSize = 0;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifications.ForeColor = System.Drawing.Color.White;
            this.btnNotifications.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.btnNotifications.IconColor = System.Drawing.Color.White;
            this.btnNotifications.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNotifications.IconSize = 32;
            this.btnNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.Location = new System.Drawing.Point(0, 749);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNotifications.Size = new System.Drawing.Size(307, 84);
            this.btnNotifications.TabIndex = 7;
            this.btnNotifications.Text = "Notifications";
            this.btnNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotifications.UseVisualStyleBackColor = true;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btnPayments.IconColor = System.Drawing.Color.White;
            this.btnPayments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPayments.IconSize = 32;
            this.btnPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.Location = new System.Drawing.Point(0, 665);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPayments.Size = new System.Drawing.Size(307, 84);
            this.btnPayments.TabIndex = 6;
            this.btnPayments.Text = "Payments";
            this.btnPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnStaffDetails
            // 
            this.btnStaffDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaffDetails.FlatAppearance.BorderSize = 0;
            this.btnStaffDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffDetails.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffDetails.ForeColor = System.Drawing.Color.White;
            this.btnStaffDetails.IconChar = FontAwesome.Sharp.IconChar.PeopleArrows;
            this.btnStaffDetails.IconColor = System.Drawing.Color.White;
            this.btnStaffDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStaffDetails.IconSize = 32;
            this.btnStaffDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffDetails.Location = new System.Drawing.Point(0, 581);
            this.btnStaffDetails.Name = "btnStaffDetails";
            this.btnStaffDetails.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnStaffDetails.Size = new System.Drawing.Size(307, 84);
            this.btnStaffDetails.TabIndex = 5;
            this.btnStaffDetails.Text = "Staff Details";
            this.btnStaffDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaffDetails.UseVisualStyleBackColor = true;
            this.btnStaffDetails.Click += new System.EventHandler(this.btnStaffDetails_Click);
            // 
            // btnFoodDetails
            // 
            this.btnFoodDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFoodDetails.FlatAppearance.BorderSize = 0;
            this.btnFoodDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodDetails.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodDetails.ForeColor = System.Drawing.Color.White;
            this.btnFoodDetails.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.btnFoodDetails.IconColor = System.Drawing.Color.White;
            this.btnFoodDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFoodDetails.IconSize = 32;
            this.btnFoodDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodDetails.Location = new System.Drawing.Point(0, 497);
            this.btnFoodDetails.Name = "btnFoodDetails";
            this.btnFoodDetails.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFoodDetails.Size = new System.Drawing.Size(307, 84);
            this.btnFoodDetails.TabIndex = 4;
            this.btnFoodDetails.Text = "Food Details";
            this.btnFoodDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFoodDetails.UseVisualStyleBackColor = true;
            this.btnFoodDetails.Click += new System.EventHandler(this.btnFoodDetails_Click);
            // 
            // btnRoomDetails
            // 
            this.btnRoomDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomDetails.FlatAppearance.BorderSize = 0;
            this.btnRoomDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomDetails.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomDetails.ForeColor = System.Drawing.Color.White;
            this.btnRoomDetails.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.btnRoomDetails.IconColor = System.Drawing.Color.White;
            this.btnRoomDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRoomDetails.IconSize = 32;
            this.btnRoomDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomDetails.Location = new System.Drawing.Point(0, 413);
            this.btnRoomDetails.Name = "btnRoomDetails";
            this.btnRoomDetails.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRoomDetails.Size = new System.Drawing.Size(307, 84);
            this.btnRoomDetails.TabIndex = 3;
            this.btnRoomDetails.Text = "Room Details";
            this.btnRoomDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoomDetails.UseVisualStyleBackColor = true;
            this.btnRoomDetails.Click += new System.EventHandler(this.btnRoomDetails_Click);
            // 
            // btnGuestDetails
            // 
            this.btnGuestDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuestDetails.FlatAppearance.BorderSize = 0;
            this.btnGuestDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestDetails.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestDetails.ForeColor = System.Drawing.Color.White;
            this.btnGuestDetails.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.btnGuestDetails.IconColor = System.Drawing.Color.White;
            this.btnGuestDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuestDetails.IconSize = 32;
            this.btnGuestDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuestDetails.Location = new System.Drawing.Point(0, 329);
            this.btnGuestDetails.Name = "btnGuestDetails";
            this.btnGuestDetails.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGuestDetails.Size = new System.Drawing.Size(307, 84);
            this.btnGuestDetails.TabIndex = 2;
            this.btnGuestDetails.Text = "Guest Details";
            this.btnGuestDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuestDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuestDetails.UseVisualStyleBackColor = true;
            this.btnGuestDetails.Click += new System.EventHandler(this.btnGuestDetails_Click);
            // 
            // btnNewGuest
            // 
            this.btnNewGuest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewGuest.FlatAppearance.BorderSize = 0;
            this.btnNewGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGuest.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGuest.ForeColor = System.Drawing.Color.White;
            this.btnNewGuest.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnNewGuest.IconColor = System.Drawing.Color.White;
            this.btnNewGuest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewGuest.IconSize = 32;
            this.btnNewGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewGuest.Location = new System.Drawing.Point(0, 245);
            this.btnNewGuest.Name = "btnNewGuest";
            this.btnNewGuest.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNewGuest.Size = new System.Drawing.Size(307, 84);
            this.btnNewGuest.TabIndex = 1;
            this.btnNewGuest.Text = "New Guest";
            this.btnNewGuest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewGuest.UseVisualStyleBackColor = true;
            this.btnNewGuest.Click += new System.EventHandler(this.btnNewGuest_Click);
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
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Controls.Add(this.iconButton2);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.textBox1);
            this.panelDesktop.Controls.Add(this.iconButton1);
            this.panelDesktop.Controls.Add(this.panel3);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.pictureBox1);
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
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(886, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 254);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 135);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel3.Location = new System.Drawing.Point(789, -4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 805);
            this.panel3.TabIndex = 2;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(566, 675);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(38, 34);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(208, 675);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 34);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Guest ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(984, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "89005";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(910, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mr. Sanju Hashintha";
            // 
            // iconButton2
            // 
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.Location = new System.Drawing.Point(897, 716);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(264, 44);
            this.iconButton2.TabIndex = 7;
            this.iconButton2.Text = "Log Out";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(31, 245);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(743, 348);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 885);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelS);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMain";
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
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnNewGuest;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnStaffDetails;
        private FontAwesome.Sharp.IconButton btnFoodDetails;
        private FontAwesome.Sharp.IconButton btnRoomDetails;
        private FontAwesome.Sharp.IconButton btnGuestDetails;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrent;
        private System.Windows.Forms.Panel panelS;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnNotifications;
        private FontAwesome.Sharp.IconButton btnPayments;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label titleCurrent;
        private System.Windows.Forms.Panel panel2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}