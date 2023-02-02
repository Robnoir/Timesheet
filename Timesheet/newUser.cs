using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timesheet
{
    public partial class newUser : UserControl
    {
        public newUser()
        {
            InitializeComponent();
            txtPassword.PasswordChar= '*';
            txtConfirmpswrd.PasswordChar= '*';
        }

        private void newUser_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            string input1 = txtPassword.Text;
            string input2 = txtConfirmpswrd.Text;

            if (input1 == input2)
            {
                MessageBox.Show("Signup Complete");
            }
            else
            {
                MessageBox.Show("Passwords dont match");

            }
        }

   
    }
}
