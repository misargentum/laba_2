using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //int ans1, ans2;
        string ans1, ans2;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //ans1 = 1;
            ans1 = "прийди";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //ans1 = 2;
            ans1 = "привет";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //ans2 = 1;
            ans2 = "пока";

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //ans2 = 2;
            ans2 = "уйди";

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = Convert.ToString(ans1) + Convert.ToString(ans2);
            label1.Text = ans1 + ans2;

        }

    }
}
