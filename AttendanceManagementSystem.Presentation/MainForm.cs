using AttendenceManagementSystem.Application;
using AttendenceManagementSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceManagementSystem.Presentation
{
    public partial class MainForm : Form
    {
        private ITimeSheet _timeSheet;
        private IAuthentication _auth;

        public MainForm(ITimeSheet timeSheet, IAuthentication auth)
        {
            InitializeComponent();
            _timeSheet = timeSheet;
            _auth = auth;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timeRecordButton_Click(object sender, EventArgs e)
        {

            ClockManagement cfrm = new ClockManagement(_timeSheet);
            cfrm.ShowDialog();
        }

        private void manageEmployeeButton_Click(object sender, EventArgs e)
        {
            if(_auth.IsAuthenticated)
            {
                EmployeeForm form = new EmployeeForm(_timeSheet);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please login");
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Exist or not", "Employee TimeSheet Management", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                System.Environment.Exit(1);
            }
        }
        private void LoginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm lfrm = new LoginForm(_auth);
            lfrm.ShowDialog();
        }
    }
}
