namespace AttendanceManagementSystem.Presentation
{
    partial class EmployeeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label1 = new Label();
            employeeIDTextBox = new TextBox();
            label2 = new Label();
            fullnameTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            positionTextBox = new TextBox();
            cardnoTextBox = new TextBox();
            addnewButton = new Button();
            saveButton = new Button();
            updateButton = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(32, 54);
            Label1.Name = "Label1";
            Label1.Size = new Size(120, 23);
            Label1.TabIndex = 0;
            Label1.Text = "Employee ID : ";
            // 
            // employeeIDTextBox
            // 
            employeeIDTextBox.Location = new Point(166, 47);
            employeeIDTextBox.Name = "employeeIDTextBox";
            employeeIDTextBox.ReadOnly = true;
            employeeIDTextBox.Size = new Size(262, 30);
            employeeIDTextBox.TabIndex = 1;
            employeeIDTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 103);
            label2.Name = "label2";
            label2.Size = new Size(101, 23);
            label2.TabIndex = 2;
            label2.Text = "Full Name : ";
            // 
            // fullnameTextBox
            // 
            fullnameTextBox.Location = new Point(166, 96);
            fullnameTextBox.Name = "fullnameTextBox";
            fullnameTextBox.Size = new Size(262, 30);
            fullnameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 160);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 4;
            label3.Text = "Position : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 224);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 5;
            label4.Text = "Card No : ";
            // 
            // positionTextBox
            // 
            positionTextBox.Location = new Point(166, 157);
            positionTextBox.Name = "positionTextBox";
            positionTextBox.Size = new Size(262, 30);
            positionTextBox.TabIndex = 6;
            positionTextBox.TextChanged += positionTextBox_TextChanged;
            // 
            // cardnoTextBox
            // 
            cardnoTextBox.Location = new Point(166, 217);
            cardnoTextBox.Name = "cardnoTextBox";
            cardnoTextBox.Size = new Size(262, 30);
            cardnoTextBox.TabIndex = 7;
            // 
            // addnewButton
            // 
            addnewButton.BackColor = SystemColors.ButtonHighlight;
            addnewButton.ForeColor = SystemColors.ActiveCaptionText;
            addnewButton.Location = new Point(69, 583);
            addnewButton.Name = "addnewButton";
            addnewButton.Size = new Size(119, 42);
            addnewButton.TabIndex = 8;
            addnewButton.Text = "Add New";
            addnewButton.UseVisualStyleBackColor = false;
            addnewButton.Click += addnewButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.ButtonHighlight;
            saveButton.Location = new Point(202, 583);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(71, 42);
            saveButton.TabIndex = 9;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(295, 583);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(78, 42);
            updateButton.TabIndex = 10;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(569, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 57;
            dataGridView1.Size = new Size(440, 573);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Label1);
            groupBox1.Controls.Add(employeeIDTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(fullnameTextBox);
            groupBox1.Controls.Add(positionTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cardnoTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(36, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(472, 269);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Info";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(passwordTextBox);
            groupBox2.Controls.Add(usernameTextBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(36, 336);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(472, 221);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "User Account";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(166, 125);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(262, 30);
            passwordTextBox.TabIndex = 3;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(166, 70);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(262, 30);
            usernameTextBox.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 132);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 1;
            label6.Text = "Password :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 77);
            label5.Name = "label5";
            label5.Size = new Size(96, 23);
            label5.TabIndex = 0;
            label5.Text = "Username :";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(399, 583);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(78, 42);
            deleteButton.TabIndex = 14;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += button1_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 676);
            Controls.Add(deleteButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(updateButton);
            Controls.Add(saveButton);
            Controls.Add(addnewButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Label1;
        private TextBox employeeIDTextBox;
        private Label label2;
        private TextBox fullnameTextBox;
        private Label label3;
        private Label label4;
        private TextBox positionTextBox;
        private TextBox cardnoTextBox;
        private Button addnewButton;
        private Button saveButton;
        private Button updateButton;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Label label6;
        private Label label5;
        private Button deleteButton;
    }
}
