namespace BevSalesSystem
{
    partial class ViewCustomerScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCustomerScreen));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomerSearchButton = new System.Windows.Forms.Button();
            this.CustomerSelectorMenu = new System.Windows.Forms.ComboBox();
            this.CustomerSearchText = new System.Windows.Forms.TextBox();
            this.CustomerInfoResult = new System.Windows.Forms.ListBox();
            this.ViewOrderText = new System.Windows.Forms.TextBox();
            this.OrderComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.OrderGridView = new System.Windows.Forms.DataGridView();
            this.ItemDescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(-64, 551);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1216, 110);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(347, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(370, 115);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-64, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 115);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CustomerSearchButton
            // 
            this.CustomerSearchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CustomerSearchButton.Location = new System.Drawing.Point(333, 127);
            this.CustomerSearchButton.Name = "CustomerSearchButton";
            this.CustomerSearchButton.Size = new System.Drawing.Size(100, 35);
            this.CustomerSearchButton.TabIndex = 6;
            this.CustomerSearchButton.Text = "Search";
            this.CustomerSearchButton.UseVisualStyleBackColor = false;
            this.CustomerSearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerSelectorMenu
            // 
            this.CustomerSelectorMenu.FormattingEnabled = true;
            this.CustomerSelectorMenu.Items.AddRange(new object[] {
            "Nolen Ryann",
            "James Johnson",
            "Jessica Smith",
            "Nellie Jones",
            "Spencer Smithers",
            "Thomas Gavin"});
            this.CustomerSelectorMenu.Location = new System.Drawing.Point(150, 131);
            this.CustomerSelectorMenu.Name = "CustomerSelectorMenu";
            this.CustomerSelectorMenu.Size = new System.Drawing.Size(177, 28);
            this.CustomerSelectorMenu.TabIndex = 7;
            this.CustomerSelectorMenu.Text = "Select Customer";
            // 
            // CustomerSearchText
            // 
            this.CustomerSearchText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CustomerSearchText.Location = new System.Drawing.Point(12, 131);
            this.CustomerSearchText.Name = "CustomerSearchText";
            this.CustomerSearchText.Size = new System.Drawing.Size(132, 26);
            this.CustomerSearchText.TabIndex = 9;
            this.CustomerSearchText.Text = "Customer Search";
            // 
            // CustomerInfoResult
            // 
            this.CustomerInfoResult.FormattingEnabled = true;
            this.CustomerInfoResult.ItemHeight = 20;
            this.CustomerInfoResult.Items.AddRange(new object[] {
            "Name:",
            "Email:",
            "Address: ",
            "City:",
            "State:",
            "ZIP:",
            "Phone Number:",
            "",
            "Payment Method:",
            "Card Number:"});
            this.CustomerInfoResult.Location = new System.Drawing.Point(12, 168);
            this.CustomerInfoResult.Name = "CustomerInfoResult";
            this.CustomerInfoResult.Size = new System.Drawing.Size(346, 204);
            this.CustomerInfoResult.TabIndex = 10;
            // 
            // ViewOrderText
            // 
            this.ViewOrderText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ViewOrderText.Location = new System.Drawing.Point(439, 131);
            this.ViewOrderText.Name = "ViewOrderText";
            this.ViewOrderText.Size = new System.Drawing.Size(132, 26);
            this.ViewOrderText.TabIndex = 11;
            this.ViewOrderText.Text = "View Order";
            // 
            // OrderComboBox
            // 
            this.OrderComboBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderComboBox.FormattingEnabled = true;
            this.OrderComboBox.Location = new System.Drawing.Point(577, 134);
            this.OrderComboBox.Name = "OrderComboBox";
            this.OrderComboBox.Size = new System.Drawing.Size(163, 28);
            this.OrderComboBox.TabIndex = 12;
            this.OrderComboBox.Text = "Select Order";
            this.OrderComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(746, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // OrderGridView
            // 
            this.OrderGridView.AllowDrop = true;
            this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemDescriptionCol,
            this.QuantityCol,
            this.UnitPriceCol,
            this.TotalCol});
            this.OrderGridView.Location = new System.Drawing.Point(380, 168);
            this.OrderGridView.Name = "OrderGridView";
            this.OrderGridView.RowHeadersWidth = 62;
            this.OrderGridView.RowTemplate.Height = 28;
            this.OrderGridView.Size = new System.Drawing.Size(663, 337);
            this.OrderGridView.TabIndex = 14;
            // 
            // ItemDescriptionCol
            // 
            this.ItemDescriptionCol.HeaderText = "Item Description";
            this.ItemDescriptionCol.MinimumWidth = 8;
            this.ItemDescriptionCol.Name = "ItemDescriptionCol";
            this.ItemDescriptionCol.Width = 150;
            // 
            // QuantityCol
            // 
            this.QuantityCol.HeaderText = "Quantity";
            this.QuantityCol.MinimumWidth = 8;
            this.QuantityCol.Name = "QuantityCol";
            this.QuantityCol.Width = 150;
            // 
            // UnitPriceCol
            // 
            this.UnitPriceCol.HeaderText = "Unit Price";
            this.UnitPriceCol.MinimumWidth = 8;
            this.UnitPriceCol.Name = "UnitPriceCol";
            this.UnitPriceCol.Width = 150;
            // 
            // TotalCol
            // 
            this.TotalCol.HeaderText = "Total";
            this.TotalCol.MinimumWidth = 8;
            this.TotalCol.Name = "TotalCol";
            this.TotalCol.Width = 150;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Order ID:",
            "Purchase Date:",
            "Estimated Delivery:",
            "",
            "Sub Total:",
            "Sales Tax:",
            "Total:"});
            this.listBox1.Location = new System.Drawing.Point(12, 378);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(346, 164);
            this.listBox1.TabIndex = 15;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton.Location = new System.Drawing.Point(380, 511);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(131, 35);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Canel Order";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackButton.Location = new System.Drawing.Point(912, 511);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(131, 35);
            this.BackButton.TabIndex = 17;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewCustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 666);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.OrderGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OrderComboBox);
            this.Controls.Add(this.ViewOrderText);
            this.Controls.Add(this.CustomerInfoResult);
            this.Controls.Add(this.CustomerSearchButton);
            this.Controls.Add(this.CustomerSearchText);
            this.Controls.Add(this.CustomerSelectorMenu);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "ViewCustomerScreen";
            this.Text = "ViewCustomerScreen";
            this.Load += new System.EventHandler(this.ViewCustomerScreen_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CustomerSearchButton;
        private System.Windows.Forms.ComboBox CustomerSelectorMenu;
        private System.Windows.Forms.TextBox CustomerSearchText;
        private System.Windows.Forms.ListBox CustomerInfoResult;
        private System.Windows.Forms.TextBox ViewOrderText;
        private System.Windows.Forms.ComboBox OrderComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView OrderGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescriptionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCol;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button BackButton;
    }
}