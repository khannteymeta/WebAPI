using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AttendenceManagementSystem.Application;
namespace AttendanceManagementSystem.Presentation
{
    
    public partial class LoginForm : Form
    {
        private IAuthentication _auth;
        public LoginForm(IAuthentication auth)
        {
            InitializeComponent();
            _auth = auth;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //get username and password
            var un = usernameTextBox.Text.Trim();
            var pa = passwordTextBox.Text.Trim();

            try
            {
                bool result = _auth.ValidateLogin(un, pa);
                if(result)
                {
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }catch (ArgumentNullException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
        }
    }
}
