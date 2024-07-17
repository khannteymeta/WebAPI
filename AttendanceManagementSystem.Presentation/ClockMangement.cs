using AttendenceManagementSystem.Application;
using AttendenceManagementSystem.Domain.Entity;
using System;
using System.Windows.Forms;

namespace AttendanceManagementSystem.Presentation
{
    public partial class ClockManagement : Form
    {
        public ClockManagement(){}

        private ITimeSheet _timeSheet;
        private void ClockManagement_Load(object sender, EventArgs e) { }
        public ClockManagement(ITimeSheet timeSheet)
        {
            _timeSheet = timeSheet;
            InitializeComponent();
           
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToString();
        }

        private void clockinButton_Click(object sender, EventArgs e)
        {
            try
            {
                _timeSheet.LogEmployee(cardnoTextBox.Text, new Log(DateTime.Now, 0));
                ShowMessage("Time-in successfull", true);
            }
            catch (ArgumentException Ec)
            {
                ShowMessage(Ec.Message, false);
            }
        }
        private void timeoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                _timeSheet.LogEmployee(cardnoTextBox.Text, new Log(DateTime.Now, 1));
                ShowMessage("Time-out successfull", true);
            }
            catch (ArgumentException Ec)
            {
                ShowMessage(Ec.Message, false);
            }
        }

        private void clockoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                _timeSheet.LogEmployee(cardnoTextBox.Text, new Log(DateTime.Now, 1));
                ShowMessage("Time-out successfull", true);
            }
            catch (ArgumentException Ec)
            {
                ShowMessage(Ec.Message, false);
            }
        }

        private void ShowMessage(string message, bool Issucceed)
        {
            if (Issucceed)
            {
                MessageBox.Show(message, "Application Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(message, "Application Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cardnoTextBox.Clear();
            cardnoTextBox.Focus();
        }
    }
}
