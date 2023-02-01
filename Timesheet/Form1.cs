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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            registration1.Visible = false;
            timeReport1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void registration1_Load(object sender, EventArgs e)
        {
            Visible= false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registration1.Visible= true;
            timeReport1.Visible= false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            registration1.Visible = false;
            timeReport1.Visible= true;
            
        }
    }
}
