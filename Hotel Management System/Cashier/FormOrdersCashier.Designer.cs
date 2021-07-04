
namespace Hotel_Management_System
{
    partial class FormOrdersCashier
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
            this.tbleRoomFoodOrderDetailsListCashier = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bttnOrderPlaced = new System.Windows.Forms.Button();
            this.bttnOrderComplete = new System.Windows.Forms.Button();
            this.FoodIDOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodNameOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodPriceOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodSelectOrders = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbleRoomFoodOrderDetailsCashier = new System.Windows.Forms.DataGridView();
            this.OrderSelectOrders = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OrderIDCashier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomIDCashier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbleRoomFoodOrderDetailsListCashier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbleRoomFoodOrderDetailsCashier)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bttnOrderComplete);
            this.panel1.Controls.Add(this.bttnOrderPlaced);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblFoodTotalCashier);
            this.panel1.Controls.Add(this.tbleRoomFoodOrderDetailsListCashier);
            this.panel1.Controls.Add(this.tbleRoomFoodOrderDetailsCashier);
            this.panel1.Controls.Add(this.panel3);
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
            // tbleRoomFoodOrderDetailsListCashier
            // 
            this.tbleRoomFoodOrderDetailsListCashier.AllowUserToOrderColumns = true;
            this.tbleRoomFoodOrderDetailsListCashier.AllowUserToResizeColumns = false;
            this.tbleRoomFoodOrderDetailsListCashier.AllowUserToResizeRows = false;
            this.tbleRoomFoodOrderDetailsListCashier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbleRoomFoodOrderDetailsListCashier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbleRoomFoodOrderDetailsListCashier.ColumnHeadersHeight = 55;
            this.tbleRoomFoodOrderDetailsListCashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tbleRoomFoodOrderDetailsListCashier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodIDOrders,
            this.FoodNameOrders,
            this.QuantityOrders,
            this.FoodPriceOrders,
            this.FoodSelectOrders});
            this.tbleRoomFoodOrderDetailsListCashier.Location = new System.Drawing.Point(464, 53);
            this.tbleRoomFoodOrderDetailsListCashier.Name = "tbleRoomFoodOrderDetailsListCashier";
            this.tbleRoomFoodOrderDetailsListCashier.RowHeadersVisible = false;
            this.tbleRoomFoodOrderDetailsListCashier.RowHeadersWidth = 51;
            this.tbleRoomFoodOrderDetailsListCashier.RowTemplate.Height = 24;
            this.tbleRoomFoodOrderDetailsListCashier.Size = new System.Drawing.Size(482, 337);
            this.tbleRoomFoodOrderDetailsListCashier.TabIndex = 29;
            this.tbleRoomFoodOrderDetailsListCashier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbleFoodOrderDetailsCashier_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel3.Location = new System.Drawing.Point(382, -12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 608);
            this.panel3.TabIndex = 19;
            // 
            // bttnOrderPlaced
            // 
            this.bttnOrderPlaced.ForeColor = System.Drawing.Color.Black;
            this.bttnOrderPlaced.Location = new System.Drawing.Point(788, 455);
            this.bttnOrderPlaced.Name = "bttnOrderPlaced";
            this.bttnOrderPlaced.Size = new System.Drawing.Size(190, 39);
            this.bttnOrderPlaced.TabIndex = 48;
            this.bttnOrderPlaced.Text = "Order Placed";
            this.bttnOrderPlaced.UseVisualStyleBackColor = true;
            // 
            // bttnOrderComplete
            // 
            this.bttnOrderComplete.Enabled = false;
            this.bttnOrderComplete.ForeColor = System.Drawing.Color.Black;
            this.bttnOrderComplete.Location = new System.Drawing.Point(788, 521);
            this.bttnOrderComplete.Name = "bttnOrderComplete";
            this.bttnOrderComplete.Size = new System.Drawing.Size(190, 39);
            this.bttnOrderComplete.TabIndex = 49;
            this.bttnOrderComplete.Text = "Order Completed";
            this.bttnOrderComplete.UseVisualStyleBackColor = true;
            // 
            // FoodIDOrders
            // 
            this.FoodIDOrders.HeaderText = "Food ID";
            this.FoodIDOrders.MinimumWidth = 6;
            this.FoodIDOrders.Name = "FoodIDOrders";
            this.FoodIDOrders.Width = 125;
            // 
            // FoodNameOrders
            // 
            this.FoodNameOrders.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodNameOrders.HeaderText = "Name";
            this.FoodNameOrders.MinimumWidth = 6;
            this.FoodNameOrders.Name = "FoodNameOrders";
            // 
            // QuantityOrders
            // 
            this.QuantityOrders.HeaderText = "Quantity";
            this.QuantityOrders.MinimumWidth = 6;
            this.QuantityOrders.Name = "QuantityOrders";
            this.QuantityOrders.Width = 115;
            // 
            // FoodPriceOrders
            // 
            this.FoodPriceOrders.HeaderText = "Price";
            this.FoodPriceOrders.MinimumWidth = 6;
            this.FoodPriceOrders.Name = "FoodPriceOrders";
            this.FoodPriceOrders.Width = 96;
            // 
            // FoodSelectOrders
            // 
            this.FoodSelectOrders.HeaderText = "";
            this.FoodSelectOrders.MinimumWidth = 6;
            this.FoodSelectOrders.Name = "FoodSelectOrders";
            this.FoodSelectOrders.Width = 30;
            // 
            // tbleRoomFoodOrderDetailsCashier
            // 
            this.tbleRoomFoodOrderDetailsCashier.AllowUserToOrderColumns = true;
            this.tbleRoomFoodOrderDetailsCashier.AllowUserToResizeColumns = false;
            this.tbleRoomFoodOrderDetailsCashier.AllowUserToResizeRows = false;
            this.tbleRoomFoodOrderDetailsCashier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbleRoomFoodOrderDetailsCashier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbleRoomFoodOrderDetailsCashier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbleRoomFoodOrderDetailsCashier.ColumnHeadersHeight = 55;
            this.tbleRoomFoodOrderDetailsCashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tbleRoomFoodOrderDetailsCashier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomIDCashier,
            this.OrderIDCashier,
            this.OrderSelectOrders});
            this.tbleRoomFoodOrderDetailsCashier.Location = new System.Drawing.Point(38, 53);
            this.tbleRoomFoodOrderDetailsCashier.Name = "tbleRoomFoodOrderDetailsCashier";
            this.tbleRoomFoodOrderDetailsCashier.RowHeadersVisible = false;
            this.tbleRoomFoodOrderDetailsCashier.RowHeadersWidth = 51;
            this.tbleRoomFoodOrderDetailsCashier.RowTemplate.Height = 24;
            this.tbleRoomFoodOrderDetailsCashier.Size = new System.Drawing.Size(307, 357);
            this.tbleRoomFoodOrderDetailsCashier.TabIndex = 23;
            // 
            // OrderSelectOrders
            // 
            this.OrderSelectOrders.FillWeight = 48.12834F;
            this.OrderSelectOrders.HeaderText = "";
            this.OrderSelectOrders.MinimumWidth = 6;
            this.OrderSelectOrders.Name = "OrderSelectOrders";
            // 
            // OrderIDCashier
            // 
            this.OrderIDCashier.FillWeight = 151.4532F;
            this.OrderIDCashier.HeaderText = "Order ID";
            this.OrderIDCashier.MinimumWidth = 6;
            this.OrderIDCashier.Name = "OrderIDCashier";
            // 
            // RoomIDCashier
            // 
            this.RoomIDCashier.FillWeight = 100.4184F;
            this.RoomIDCashier.HeaderText = "Room ID";
            this.RoomIDCashier.MinimumWidth = 6;
            this.RoomIDCashier.Name = "RoomIDCashier";
            // 
            // FormOrdersCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1003, 584);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Name = "FormOrdersCashier";
            this.Text = "Orders";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbleRoomFoodOrderDetailsListCashier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbleRoomFoodOrderDetailsCashier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView tbleRoomFoodOrderDetailsListCashier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFoodTotalCashier;
        private System.Windows.Forms.Button bttnOrderComplete;
        private System.Windows.Forms.Button bttnOrderPlaced;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodIDOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodNameOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodPriceOrders;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FoodSelectOrders;
        private System.Windows.Forms.DataGridView tbleRoomFoodOrderDetailsCashier;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomIDCashier;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderIDCashier;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OrderSelectOrders;
    }
}