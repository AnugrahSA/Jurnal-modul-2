using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2_1302204047
{
    public partial class Form1 : Form
    {
        decimal bil1;
        decimal bil2;
        int opr;
        Boolean opr_selesai = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text != "0")
            {
                textDisplay1.Text += "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text = "1";
            }
            else
            {
                textDisplay1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text = "2";
            }
            else
            {
                textDisplay1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text = "3";
            }
            else
            {
                textDisplay1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text = "4";
            }
            else
            {
                textDisplay1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text = "5";
            }
            else
            {
                textDisplay1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text = "6";
            }
            else
            {
                textDisplay1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text = "7";
            }
            else
            {
                textDisplay1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text = "8";
            }
            else
            {
                textDisplay1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text = "9";
            }
            else
            {
                textDisplay1.Text += "9";
            }
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textDisplay1.Text);
            textDisplay1.Text = " ";
            opr = 1;
            opr_selesai = true;
               
        }

        private void samadengan_Click(object sender, EventArgs e)
        {
            if (opr_selesai == true)
                bil2 = Convert.ToDecimal(textDisplay1.Text);
            {
                switch(opr)
                {
                    case 1:
                        textDisplay1.Text = Convert.ToString(bil1 + bil2);
                        break;
                }
            }
            opr_selesai = false;
        }
    }
}
