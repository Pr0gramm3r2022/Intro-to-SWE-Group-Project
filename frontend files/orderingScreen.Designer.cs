namespace BevSalesSystem
{
    partial class OrderingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderingScreen));
            this.LogoBackgroundPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AcmeLogo = new System.Windows.Forms.PictureBox();
            this.FootPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.CustomerSelectorMenu = new System.Windows.Forms.ComboBox();
            this.NewOrderText = new System.Windows.Forms.TextBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.InventorySearchResult = new System.Windows.Forms.ListBox();
            this.ItemSearchText = new System.Windows.Forms.TextBox();
            this.AddToOrderButton = new System.Windows.Forms.Button();
            this.PlaceOrderButton = new System.Windows.Forms.Button();
            this.OrderDetailText = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.TotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.LogoBackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcmeLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoBackgroundPanel
            // 
            this.LogoBackgroundPanel.AutoSize = true;
            this.LogoBackgroundPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LogoBackgroundPanel.Controls.Add(this.AcmeLogo);
            this.LogoBackgroundPanel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogoBackgroundPanel.Location = new System.Drawing.Point(412, 0);
            this.LogoBackgroundPanel.Name = "LogoBackgroundPanel";
            this.LogoBackgroundPanel.Size = new System.Drawing.Size(370, 115);
            this.LogoBackgroundPanel.TabIndex = 0;
            this.LogoBackgroundPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // AcmeLogo
            // 
            this.AcmeLogo.Image = ((System.Drawing.Image)(resources.GetObject("AcmeLogo.Image")));
            this.AcmeLogo.Location = new System.Drawing.Point(3, 3);
            this.AcmeLogo.Name = "AcmeLogo";
            this.AcmeLogo.Size = new System.Drawing.Size(364, 109);
            this.AcmeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AcmeLogo.TabIndex = 0;
            this.AcmeLogo.TabStop = false;
            this.AcmeLogo.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // FootPanel
            // 
            this.FootPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FootPanel.Location = new System.Drawing.Point(1, 545);
            this.FootPanel.Name = "FootPanel";
            this.FootPanel.Size = new System.Drawing.Size(1216, 110);
            this.FootPanel.TabIndex = 1;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HeaderPanel.Location = new System.Drawing.Point(1, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1205, 115);
            this.HeaderPanel.TabIndex = 2;
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
            this.CustomerSelectorMenu.Location = new System.Drawing.Point(12, 153);
            this.CustomerSelectorMenu.Name = "CustomerSelectorMenu";
            this.CustomerSelectorMenu.Size = new System.Drawing.Size(177, 28);
            this.CustomerSelectorMenu.TabIndex = 3;
            this.CustomerSelectorMenu.Text = "Select Customer";
            // 
            // NewOrderText
            // 
            this.NewOrderText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.NewOrderText.Location = new System.Drawing.Point(12, 121);
            this.NewOrderText.Name = "NewOrderText";
            this.NewOrderText.Size = new System.Drawing.Size(100, 26);
            this.NewOrderText.TabIndex = 4;
            this.NewOrderText.Text = "New Order";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(15, 219);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(252, 26);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.Text = "Ex. Bud Light";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SearchButton.Location = new System.Drawing.Point(273, 215);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 35);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // InventorySearchResult
            // 
            this.InventorySearchResult.FormattingEnabled = true;
            this.InventorySearchResult.ItemHeight = 20;
            this.InventorySearchResult.Location = new System.Drawing.Point(12, 260);
            this.InventorySearchResult.Name = "InventorySearchResult";
            this.InventorySearchResult.Size = new System.Drawing.Size(361, 204);
            this.InventorySearchResult.TabIndex = 7;
            // 
            // ItemSearchText
            // 
            this.ItemSearchText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ItemSearchText.Location = new System.Drawing.Point(15, 187);
            this.ItemSearchText.Name = "ItemSearchText";
            this.ItemSearchText.Size = new System.Drawing.Size(100, 26);
            this.ItemSearchText.TabIndex = 8;
            this.ItemSearchText.Text = "Item Search";
            // 
            // AddToOrderButton
            // 
            this.AddToOrderButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddToOrderButton.Location = new System.Drawing.Point(12, 470);
            this.AddToOrderButton.Name = "AddToOrderButton";
            this.AddToOrderButton.Size = new System.Drawing.Size(145, 35);
            this.AddToOrderButton.TabIndex = 9;
            this.AddToOrderButton.Text = "Add to Order";
            this.AddToOrderButton.UseVisualStyleBackColor = false;
            // 
            // PlaceOrderButton
            // 
            this.PlaceOrderButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PlaceOrderButton.Location = new System.Drawing.Point(379, 470);
            this.PlaceOrderButton.Name = "PlaceOrderButton";
            this.PlaceOrderButton.Size = new System.Drawing.Size(145, 35);
            this.PlaceOrderButton.TabIndex = 11;
            this.PlaceOrderButton.Text = "Place Order";
            this.PlaceOrderButton.UseVisualStyleBackColor = false;
            // 
            // OrderDetailText
            // 
            this.OrderDetailText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.OrderDetailText.Location = new System.Drawing.Point(379, 121);
            this.OrderDetailText.Name = "OrderDetailText";
            this.OrderDetailText.Size = new System.Drawing.Size(100, 26);
            this.OrderDetailText.TabIndex = 12;
            this.OrderDetailText.Text = "Order Details";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteButton.Location = new System.Drawing.Point(530, 471);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(145, 35);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "Delete Item";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // TotalCol
            // 
            this.TotalCol.HeaderText = "Total";
            this.TotalCol.MinimumWidth = 8;
            this.TotalCol.Name = "TotalCol";
            this.TotalCol.Width = 150;
            // 
            // UnitPriceCol
            // 
            this.UnitPriceCol.HeaderText = "Unit Price";
            this.UnitPriceCol.MinimumWidth = 8;
            this.UnitPriceCol.Name = "UnitPriceCol";
            this.UnitPriceCol.Width = 150;
            // 
            // QuantityCol
            // 
            this.QuantityCol.HeaderText = "Quantity";
            this.QuantityCol.MinimumWidth = 8;
            this.QuantityCol.Name = "QuantityCol";
            this.QuantityCol.Width = 150;
            // 
            // ItemDescriptionCol
            // 
            this.ItemDescriptionCol.HeaderText = "Item Description";
            this.ItemDescriptionCol.MinimumWidth = 8;
            this.ItemDescriptionCol.Name = "ItemDescriptionCol";
            this.ItemDescriptionCol.Width = 150;
            // 
            // OrderGridView
            // 
            this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemDescriptionCol,
            this.QuantityCol,
            this.UnitPriceCol,
            this.TotalCol});
            this.OrderGridView.Location = new System.Drawing.Point(389, 153);
            this.OrderGridView.Name = "OrderGridView";
            this.OrderGridView.RowHeadersWidth = 62;
            this.OrderGridView.RowTemplate.Height = 28;
            this.OrderGridView.Size = new System.Drawing.Size(663, 312);
            this.OrderGridView.TabIndex = 10;
            this.OrderGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackButton.Location = new System.Drawing.Point(907, 470);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(145, 35);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // OrderingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 651);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.OrderDetailText);
            this.Controls.Add(this.PlaceOrderButton);
            this.Controls.Add(this.OrderGridView);
            this.Controls.Add(this.AddToOrderButton);
            this.Controls.Add(this.ItemSearchText);
            this.Controls.Add(this.InventorySearchResult);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.NewOrderText);
            this.Controls.Add(this.CustomerSelectorMenu);
            this.Controls.Add(this.FootPanel);
            this.Controls.Add(this.LogoBackgroundPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "OrderingScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.orderingScreen_Load);
            this.LogoBackgroundPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AcmeLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel LogoBackgroundPanel;
        private System.Windows.Forms.FlowLayoutPanel FootPanel;
        public System.Windows.Forms.PictureBox AcmeLogo;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.ComboBox CustomerSelectorMenu;
        private System.Windows.Forms.TextBox NewOrderText;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox InventorySearchResult;
        private System.Windows.Forms.TextBox ItemSearchText;
        private System.Windows.Forms.Button AddToOrderButton;
        private System.Windows.Forms.Button PlaceOrderButton;
        private System.Windows.Forms.TextBox OrderDetailText;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescriptionCol;
        private System.Windows.Forms.DataGridView OrderGridView;
        private System.Windows.Forms.Button BackButton;
    }
}

