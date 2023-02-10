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
    public partial class TimeReport : UserControl
    {


        MySqlConnection conn;
        public TimeReport()
        {

            InitializeComponent();
            string server = "localhost";
            string database = "timesheet";
            string user = "root";
            string password = "Vinniethepooh01";
            string connString = $"SERVER = {server};DATABASE={database};USER={user};PASSWORD={password};";

            conn = new MySqlConnection(connString);

            shiftPick.Items.Add("Dag");
            shiftPick.Items.Add("kväll");
            shiftPick.Items.Add("Natt");
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string shiftSelection = shiftPick.SelectedItem.ToString();
            string dateWork = datetimepicker.Value.ToString("yyyy-MM-dd");
            int dataAdd = 0;

            if (shiftSelection == "Dag")
            {
                dataAdd = 8;
            }
            else if (shiftSelection == "kväll")
            {
                dataAdd = 8;
            }
            else if (shiftSelection == "Natt")
            {
                dataAdd = 8;
            }

            conn.Open();
            string InsertToDB = "INSERT INTO Worksheet(Worksheet_Date, Worksheet_shift, Worksheet_HoursWorked) VALUES (@dateWork, @shiftSelection , @dataAdd)";
            MySqlCommand cmd = new MySqlCommand(InsertToDB,conn);

            cmd.Parameters.AddWithValue("@datework", dateWork);
            cmd.Parameters.AddWithValue("@shiftSelection", shiftSelection);
            cmd.Parameters.AddWithValue("@dataAdd", dataAdd);
            cmd.ExecuteNonQuery();

            conn.Close();


        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
