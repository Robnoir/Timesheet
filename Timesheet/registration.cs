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
using System.Xml.Linq;

namespace Timesheet
{
    public partial class registration : UserControl
    {


        MySqlConnection conn;

        public registration()
        {
            InitializeComponent();
            string server = "localhost";
            string database = "timesheet";
            string user = "root";
            string password = "Vinniethepooh01";
            string connString = $"SERVER = {server};DATABASE={database};USER={user};PASSWORD={password};";

            conn = new MySqlConnection(connString);

            
            
        }

        private void SaveAvailable()
        {
            string datefrom = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string datetill = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string valPass = comboBox1.SelectedItem.ToString();
            conn.Open();


            string InsertToDb = "INSERT INTO available (available_shift,available_From, available_To) VALUES (@valpass,@datefrom,@datetill)";
            MySqlCommand cmd = new MySqlCommand(InsertToDb,conn);

            cmd.Parameters.AddWithValue("@datefrom", datefrom);
            cmd.Parameters.AddWithValue("@datetill", datetill);
            cmd.Parameters.AddWithValue("@valpass", valPass);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
