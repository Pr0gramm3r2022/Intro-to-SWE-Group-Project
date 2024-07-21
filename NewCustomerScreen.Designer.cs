namespace SWE_Final_Project
{
    partial class NewCustomerScreen
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
            Add = new Button();
            FirstNameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            LastNameBox = new TextBox();
            AddressBox = new TextBox();
            PhoneNumberBox = new TextBox();
            Finish = new Button();
            SuspendLayout();
            // 
            // Add
            // 
            Add.BackColor = SystemColors.ActiveCaption;
            Add.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.Location = new Point(320, 245);
            Add.Name = "Add";
            Add.Size = new Size(121, 47);
            Add.TabIndex = 0;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // FirstNameBox
            // 
            FirstNameBox.Location = new Point(219, 98);
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.Size = new Size(121, 23);
            FirstNameBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 80);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 2;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 80);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 3;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 149);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 198);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 5;
            label4.Text = "Phone Number";
            // 
            // LastNameBox
            // 
            LastNameBox.Location = new Point(414, 98);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(124, 23);
            LastNameBox.TabIndex = 6;
            // 
            // AddressBox
            // 
            AddressBox.Location = new Point(219, 167);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(319, 23);
            AddressBox.TabIndex = 7;
            // 
            // PhoneNumberBox
            // 
            PhoneNumberBox.Location = new Point(219, 216);
            PhoneNumberBox.Name = "PhoneNumberBox";
            PhoneNumberBox.Size = new Size(319, 23);
            PhoneNumberBox.TabIndex = 8;
            // 
            // Finish
            // 
            Finish.BackColor = SystemColors.AppWorkspace;
            Finish.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Finish.Location = new Point(303, 298);
            Finish.Name = "Finish";
            Finish.Size = new Size(157, 32);
            Finish.TabIndex = 9;
            Finish.Text = "Finish";
            Finish.UseVisualStyleBackColor = false;
            Finish.Click += Finish_Click;
            // 
            // NewCustomerScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Finish);
            Controls.Add(PhoneNumberBox);
            Controls.Add(AddressBox);
            Controls.Add(LastNameBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FirstNameBox);
            Controls.Add(Add);
            Name = "NewCustomerScreen";
            Text = "NewCustomerScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Add;
        private TextBox FirstNameBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox LastNameBox;
        private TextBox AddressBox;
        private TextBox PhoneNumberBox;
        private Button Finish;
    }
}