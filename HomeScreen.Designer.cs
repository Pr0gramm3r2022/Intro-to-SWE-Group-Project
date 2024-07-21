namespace SWE_Final_Project
{
    partial class HomeScreen
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
            NewOrderButton = new Button();
            label1 = new Label();
            LogOutButton = new Button();
            NewCustomerButton = new Button();
            SuspendLayout();
            // 
            // NewOrderButton
            // 
            NewOrderButton.BackColor = SystemColors.MenuHighlight;
            NewOrderButton.Location = new Point(317, 62);
            NewOrderButton.Name = "NewOrderButton";
            NewOrderButton.Size = new Size(125, 59);
            NewOrderButton.TabIndex = 0;
            NewOrderButton.Text = "New Order";
            NewOrderButton.UseVisualStyleBackColor = false;
            NewOrderButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(295, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 1;
            label1.Text = "Welcome to ACME Distributing";
            // 
            // LogOutButton
            // 
            LogOutButton.BackColor = Color.Firebrick;
            LogOutButton.ForeColor = Color.White;
            LogOutButton.Location = new Point(336, 179);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(88, 51);
            LogOutButton.TabIndex = 2;
            LogOutButton.Text = "Log Out";
            LogOutButton.UseVisualStyleBackColor = false;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // NewCustomerButton
            // 
            NewCustomerButton.BackColor = Color.Orange;
            NewCustomerButton.Location = new Point(317, 127);
            NewCustomerButton.Name = "NewCustomerButton";
            NewCustomerButton.Size = new Size(125, 46);
            NewCustomerButton.TabIndex = 3;
            NewCustomerButton.Text = "New Customer";
            NewCustomerButton.UseVisualStyleBackColor = false;
            NewCustomerButton.Click += NewCustomerButton_Click;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 295);
            Controls.Add(NewCustomerButton);
            Controls.Add(LogOutButton);
            Controls.Add(label1);
            Controls.Add(NewOrderButton);
            Name = "HomeScreen";
            Text = "HomeScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NewOrderButton;
        private Label label1;
        private Button LogOutButton;
        private Button NewCustomerButton;
    }
}