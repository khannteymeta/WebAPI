namespace AttendanceManagementSystem.Presentation
{
    partial class ClockManagement
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            currentTimeLabel = new Label();
            label3 = new Label();
            cardnoTextBox = new TextBox();
            clockinButton = new Button();
            clockoutButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(259, 22);
            label1.Name = "label1";
            label1.Size = new Size(211, 51);
            label1.TabIndex = 0;
            label1.Text = "Clock Form";
            // 
            // currentTimeLabel
            // 
            currentTimeLabel.AutoSize = true;
            currentTimeLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            currentTimeLabel.Location = new Point(294, 94);
            currentTimeLabel.Name = "currentTimeLabel";
            currentTimeLabel.Size = new Size(111, 51);
            currentTimeLabel.TabIndex = 1;
            currentTimeLabel.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.2543278F);
            label3.Location = new Point(159, 180);
            label3.Name = "label3";
            label3.Size = new Size(111, 31);
            label3.TabIndex = 2;
            label3.Text = "Card no : ";
            // 
            // cardnoTextBox
            // 
            cardnoTextBox.Location = new Point(294, 180);
            cardnoTextBox.Name = "cardnoTextBox";
            cardnoTextBox.Size = new Size(205, 30);
            cardnoTextBox.TabIndex = 3;
            // 
            // clockinButton
            // 
            clockinButton.Font = new Font("Segoe UI", 12.2543278F);
            clockinButton.Location = new Point(230, 267);
            clockinButton.Name = "clockinButton";
            clockinButton.Size = new Size(105, 37);
            clockinButton.TabIndex = 4;
            clockinButton.Text = "Time-in";
            clockinButton.UseVisualStyleBackColor = true;
            clockinButton.Click += clockinButton_Click;
            // 
            // clockoutButton
            // 
            clockoutButton.Font = new Font("Segoe UI", 12.2543278F);
            clockoutButton.Location = new Point(384, 267);
            clockoutButton.Name = "clockoutButton";
            clockoutButton.Size = new Size(115, 37);
            clockoutButton.TabIndex = 5;
            clockoutButton.Text = "Time-out";
            clockoutButton.UseVisualStyleBackColor = true;
            clockoutButton.Click += clockoutButton_Click;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 10;
            timer.Tick += timer_Tick;
            // 
            // ClockManagement
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clockoutButton);
            Controls.Add(clockinButton);
            Controls.Add(cardnoTextBox);
            Controls.Add(label3);
            Controls.Add(currentTimeLabel);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.254328F);
            Name = "ClockManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clock Mangement";
            Load += ClockManagement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label currentTimeLabel;
        private Label label3;
        private TextBox cardnoTextBox;
        private Button clockinButton;
        private Button clockoutButton;
        private System.Windows.Forms.Timer timer;
    }
}