namespace AttendanceManagementSystem.Presentation
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 64);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24.1791039F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(266, 53);
            label2.Name = "label2";
            label2.Size = new Size(268, 61);
            label2.TabIndex = 1;
            label2.Text = "Login Form";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(65, 172);
            label3.Name = "label3";
            label3.Size = new Size(123, 30);
            label3.TabIndex = 2;
            label3.Text = "Username : ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(72, 244);
            label4.Name = "label4";
            label4.Size = new Size(116, 30);
            label4.TabIndex = 3;
            label4.Text = "Password : ";
            label4.Click += label4_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI", 14.25F);
            usernameTextBox.Location = new Point(194, 159);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(430, 43);
            usernameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 14.25F);
            passwordTextBox.Location = new Point(194, 231);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(430, 43);
            passwordTextBox.TabIndex = 5;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Segoe UI", 11F);
            loginButton.Location = new Point(325, 336);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(121, 45);
            loginButton.TabIndex = 6;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login Form";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
    }
}