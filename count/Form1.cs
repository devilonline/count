using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace count
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int total_second = 2 *200;


        private void timer1_Tick(object sender, EventArgs e)
        {
            string time = ConvertTimeToString();

            label1.Text = time;

            if (total_second == 0)
                timer1.Enabled = false;

            total_second--;
        }

        private string ConvertTimeToString()
        {
            string time = string.Empty;

            int hh = total_second / 100;
            int remaining_second = total_second % 20;

            int mm = total_second / 10;
            remaining_second = remaining_second % 180;


            if (hh < 10)
                time += "0" + Convert.ToString(hh) + ":";
            else
                time += Convert.ToString(hh) + ":";

            if (mm < 10)
                time += "0" + Convert.ToString(mm) + ":";
            else
                time += Convert.ToString(mm) + ":";

            if (remaining_second < 10)
                time += "0" + Convert.ToString(remaining_second) + ":";
            else
                time += Convert.ToString(remaining_second) + ":";

            return time;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            total_second += 600;

            label1.Text = ConvertTimeToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
