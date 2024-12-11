namespace denemeproje
{
    partial class NewMemberSon
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
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            phoneTextBox = new TextBox();
            emailTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            genderComboBox = new ComboBox();
            roleComboBox = new ComboBox();
            Gender = new Label();
            label6 = new Label();
            membershipTypeComboBox = new ComboBox();
            label7 = new Label();
            saveButton = new Button();
            addressTextBox = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(72, 142);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(115, 23);
            firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(265, 142);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(115, 23);
            lastNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 109);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 110);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(72, 214);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(115, 23);
            phoneTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(265, 214);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(115, 23);
            emailTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 188);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 6;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 187);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 7;
            label5.Text = "Email";
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(73, 285);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(63, 23);
            genderComboBox.TabIndex = 8;
            // 
            // roleComboBox
            // 
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Location = new Point(192, 285);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(68, 23);
            roleComboBox.TabIndex = 9;
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.Location = new Point(74, 260);
            Gender.Name = "Gender";
            Gender.Size = new Size(45, 15);
            Gender.TabIndex = 10;
            Gender.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(192, 260);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 11;
            label6.Text = "Role";
            // 
            // membershipTypeComboBox
            // 
            membershipTypeComboBox.FormattingEnabled = true;
            membershipTypeComboBox.Location = new Point(299, 285);
            membershipTypeComboBox.Name = "membershipTypeComboBox";
            membershipTypeComboBox.Size = new Size(103, 23);
            membershipTypeComboBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(299, 260);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 13;
            label7.Text = "Membership Type";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(184, 366);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 14;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(471, 198);
            addressTextBox.Multiline = true;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(112, 77);
            addressTextBox.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(473, 163);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 16;
            label8.Text = "Address";
            // 
            // NewMemberSon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(addressTextBox);
            Controls.Add(saveButton);
            Controls.Add(label7);
            Controls.Add(membershipTypeComboBox);
            Controls.Add(label6);
            Controls.Add(Gender);
            Controls.Add(roleComboBox);
            Controls.Add(genderComboBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(emailTextBox);
            Controls.Add(phoneTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Name = "NewMemberSon";
            Text = "NewMemberSon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox phoneTextBox;
        private TextBox emailTextBox;
        private Label label4;
        private Label label5;
        private ComboBox genderComboBox;
        private ComboBox roleComboBox;
        private Label Gender;
        private Label label6;
        private ComboBox membershipTypeComboBox;
        private Label label7;
        private Button saveButton;
        private TextBox addressTextBox;
        private Label label8;
        private TextBox textBox1;
    }
}