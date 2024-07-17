namespace AttendanceManagementSystem.Presentation
{
    partial class MainForm
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
            timeRecordButton = new Button();
            manageEmployeeButton = new Button();
            LoginLinkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.1343288F);
            label1.Location = new Point(155, 39);
            label1.Name = "label1";
            label1.Size = new Size(606, 51);
            label1.TabIndex = 0;
            label1.Text = "Employee TimeSheet Management";
            label1.Click += label1_Click;
            // 
            // timeRecordButton
            // 
            timeRecordButton.Font = new Font("Segoe UI", 14.1343279F);
            timeRecordButton.Location = new Point(342, 151);
            timeRecordButton.Name = "timeRecordButton";
            timeRecordButton.Size = new Size(200, 53);
            timeRecordButton.TabIndex = 1;
            timeRecordButton.Text = "Time Record";
            timeRecordButton.UseVisualStyleBackColor = true;
            timeRecordButton.Click += timeRecordButton_Click;
            // 
            // manageEmployeeButton
            // 
            manageEmployeeButton.Font = new Font("Segoe UI", 12.1343279F);
            manageEmployeeButton.Location = new Point(308, 251);
            manageEmployeeButton.Name = "manageEmployeeButton";
            manageEmployeeButton.Size = new Size(249, 49);
            manageEmployeeButton.TabIndex = 2;
            manageEmployeeButton.Tag = "";
            manageEmployeeButton.Text = "Manage Employee";
            manageEmployeeButton.UseVisualStyleBackColor = true;
            manageEmployeeButton.Click += manageEmployeeButton_Click;
            // 
            // LoginLinkLabel
            // 
            LoginLinkLabel.AutoSize = true;
            LoginLinkLabel.Location = new Point(17, 21);
            LoginLinkLabel.Name = "LoginLinkLabel";
            LoginLinkLabel.Size = new Size(52, 23);
            LoginLinkLabel.TabIndex = 3;
            LoginLinkLabel.TabStop = true;
            LoginLinkLabel.Text = "Login";
            LoginLinkLabel.LinkClicked += LoginLinkLabel_LinkClicked;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 450);
            Controls.Add(LoginLinkLabel);
            Controls.Add(manageEmployeeButton);
            Controls.Add(timeRecordButton);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.134328F);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button timeRecordButton;
        private Button manageEmployeeButton;
        private LinkLabel LoginLinkLabel;
    }
}