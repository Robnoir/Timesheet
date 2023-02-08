using MySql.Data.MySqlClient;
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
    public partial class Login : Form
    {
        
       


        public Login()
        {
            InitializeComponent();
            txtloginPswrd.PasswordChar= '*';

        }

        private void LogoinVerification()
        {
            string server = "localhost";
            string database = "timesheet";
            string user = "root";
            string password = "Vinniethepooh01";
            string connString = $"SERVER = {server};DATABASE={database};USER={user};PASSWORD={password};";

            MySqlConnection conn = new MySqlConnection(connString);
            string email = txtloginUser.Text;
            string loginPassword = txtloginPswrd.Text;
            string query = "SELECT * FROM timesheet.employee WHERE employee_Email'"+ txtloginUser.Text+"'";

            MySqlCommand cmd = new MySqlCommand(query,conn);


            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string username = reader["employee_Email"].ToString();
                        string lpassword = reader["employee_Password"].ToString();

                        if (username == email && lpassword == loginPassword)
                        {
                            MessageBox.Show("Login successfull");
                            break;
                        }
                    }

                    if (!reader.IsClosed)
                    {
                        MessageBox.Show("Incorrect username or password!");

                    }
                }
                else
                {
                    MessageBox.Show("Username not found");
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();




        }

     

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            newUser1.Visible = true;
        }

        private void txt_loginUser_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
