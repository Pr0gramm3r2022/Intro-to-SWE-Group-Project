namespace SWE_Final_Project
{
    partial class OrderScreen
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
            OrderSubmitButton = new Button();
            GlassQuantity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CanQuantity = new TextBox();
            PonyKegQuantity = new TextBox();
            KegQuantity = new TextBox();
            AddressTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            EnterCustomerTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // OrderSubmitButton
            // 
            OrderSubmitButton.BackColor = Color.Lime;
            OrderSubmitButton.Location = new Point(334, 287);
            OrderSubmitButton.Name = "OrderSubmitButton";
            OrderSubmitButton.Size = new Size(113, 30);
            OrderSubmitButton.TabIndex = 0;
            OrderSubmitButton.Text = "Submit";
            OrderSubmitButton.UseVisualStyleBackColor = false;
            OrderSubmitButton.Click += OrderSubmitButton_Click;
            // 
            // GlassQuantity
            // 
            GlassQuantity.Location = new Point(64, 177);
            GlassQuantity.Name = "GlassQuantity";
            GlassQuantity.Size = new Size(100, 23);
            GlassQuantity.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 159);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 2;
            label1.Text = "Quantity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 159);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "Quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(458, 159);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Quantity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(655, 159);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 5;
            label4.Text = "Quantity:";
            // 
            // CanQuantity
            // 
            CanQuantity.Location = new Point(251, 177);
            CanQuantity.Name = "CanQuantity";
            CanQuantity.Size = new Size(100, 23);
            CanQuantity.TabIndex = 6;
            // 
            // PonyKegQuantity
            // 
            PonyKegQuantity.Location = new Point(458, 177);
            PonyKegQuantity.Name = "PonyKegQuantity";
            PonyKegQuantity.Size = new Size(100, 23);
            PonyKegQuantity.TabIndex = 7;
            // 
            // KegQuantity
            // 
            KegQuantity.Location = new Point(655, 177);
            KegQuantity.Name = "KegQuantity";
            KegQuantity.Size = new Size(100, 23);
            KegQuantity.TabIndex = 8;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(164, 258);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(462, 23);
            AddressTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 266);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 10;
            label5.Text = "Enter Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 237);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 11;
            label6.Text = "Enter Customer:";
            // 
            // EnterCustomerTextBox
            // 
            EnterCustomerTextBox.Location = new Point(164, 234);
            EnterCustomerTextBox.Name = "EnterCustomerTextBox";
            EnterCustomerTextBox.Size = new Size(178, 23);
            EnterCustomerTextBox.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.glass_bott;
            pictureBox1.Location = new Point(64, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(251, 95);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(458, 95);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(655, 95);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 50);
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // OrderScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(EnterCustomerTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(AddressTextBox);
            Controls.Add(KegQuantity);
            Controls.Add(PonyKegQuantity);
            Controls.Add(CanQuantity);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GlassQuantity);
            Controls.Add(OrderSubmitButton);
            Name = "OrderScreen";
            Text = "OrderScreen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OrderSubmitButton;
        private TextBox GlassQuantity;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox CanQuantity;
        private TextBox PonyKegQuantity;
        private TextBox KegQuantity;
        private TextBox AddressTextBox;
        private Label label5;
        private Label label6;
        private TextBox EnterCustomerTextBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}