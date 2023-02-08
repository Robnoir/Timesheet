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
    public partial class newUser : UserControl
    {


        MySqlConnection conn;
        TextBox[] txtboxesUser;

        public newUser()
        {
            InitializeComponent();
         
            string server = "localhost";
            string database = "timesheet";
            string user = "root";
            string password = "Vinniethepooh01";
            string connString = $"SERVER = {server};DATABASE={database};USER={user};PASSWORD={password};";

            conn = new MySqlConnection(connString);

            txtboxesUser = new TextBox[] {txtName,txtLastname,txtEmail,txtPassword,txtConfirmPswrd};

        }

        private void InsertPersonToDb()
        {
            bool valid = true;

            foreach (TextBox txtbox in txtboxesUser)
            {
                txtbox.Text = txtbox.Text.Trim();

                if (txtbox.Text == "")
                {
                    valid = false;
                    txtbox.BackColor = Color.IndianRed;

                }
                else
                {
                    txtbox.BackColor = TextBox.DefaultBackColor;

                }            
            }

            if (!valid)
            {
                MessageBox.Show("Invalid text, please try again");
            }

            if (txtPassword != txtConfirmPswrd)
            {
                txtPassword.BackColor = Color.IndianRed;
                txtConfirmPswrd.BackColor = Color.IndianRed;
                MessageBox.Show("Passwords do not match.");
                return;
            }


            string name = txtName.Text;
            string lastname = txtLastname.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            string sqlQuerry = $"CALL Insertnewuser('{name},{lastname},{email},{password})";

            MySqlCommand cmd = new MySqlCommand(sqlQuerry,conn);

            

            try
            {
                //Öppna connection
                conn.Open();

                //Exekvera kommando
                cmd.ExecuteReader();

                //Stänga kopplingen 
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //Bekräftelse till användare
            MessageBox.Show("Insert finished succesfully");






        }






        private void newUser_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            InsertPersonToDb();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPswrd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
