using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lastcalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text + "1";
            else
                textBox1.Text = "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            float i = 0;
            string firs = textBox1.Text;
            string sec;
            bool results = float.TryParse(firs, out i);
            if (textBox1.Text != "" && results == true)


                textBox1.Text = textBox1.Text + ".";

        }

        private void button14_Click(object sender, EventArgs e)
        {

            float i = 0;
            string firs = textBox1.Text;
            string sec;
            bool results = float.TryParse(firs, out i);
            if (textBox1.Text != "" && results == true)


                textBox1.Text = textBox1.Text + "-";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text + "2";
            else
                textBox1.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text + "3";
            else
                textBox1.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text + "4";
            else
                textBox1.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text + "5";
            else
                textBox1.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text + "6";
            else
                textBox1.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text + "7";
            else
                textBox1.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text + "8";
            else
                textBox1.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text + "9";
            else
                textBox1.Text = "9";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            float i = 0;
            string firs=textBox1.Text;
            string sec;
            bool results = float.TryParse(firs, out i);
            if (textBox1.Text != "" && results==true )
              
                
                textBox1.Text = textBox1.Text + "+";
               
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text + "0";
            else
                textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {

            float i = 0;
            string firs = textBox1.Text;
            string sec;
            bool results = float.TryParse(firs, out i);
            if (textBox1.Text != "" && results == true)


                textBox1.Text = textBox1.Text + "x";
        }

        private void button16_Click(object sender, EventArgs e)
        {

            float i = 0;
            string firs = textBox1.Text;
            string sec;
            bool results = float.TryParse(firs, out i);
            if (textBox1.Text != "" && results == true)


                textBox1.Text = textBox1.Text + "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string g=textBox1.Text;
            string h = g;
            string[]gl;
            float numg;
            float numg2 = 0;
            if ( textBox1.Text.Contains("+"))
            {
                gl = g.Split('+');
                foreach(string sec in gl)
                {
                    float.TryParse(sec,out numg);
                    numg2 = numg + numg2;
                    textBox1.Text = numg2.ToString();
                }  
            }
            else if (textBox1.Text.Contains("-"))
            {
                gl = h.Split('-');
                foreach (string secm in gl)
                {
                    float.TryParse(secm, out numg);
                    numg2 = numg - numg2;
                    
                }
                numg2 = -(numg2);
                textBox1.Text = numg2.ToString();
                
            }
            else if (textBox1.Text.Contains("x"))
            {
                gl = g.Split('x');
                numg2 = 1;
                foreach (string secx in gl)
                {
                    float.TryParse(secx, out numg);
                    numg2 = numg * numg2;
                    textBox1.Text = numg2.ToString();
                }
            }
            else if (textBox1.Text!="" && button16.Enabled == true)
            {
                gl = g.Split('/');
                numg2 = 1;
                foreach (string secd in gl)
                {
                    float.TryParse(secd, out numg);
                    numg2 = numg / numg2;
                }
                numg2 = 1 / (numg2);
                textBox1.Text = numg2.ToString();
            }
        }
    }
}
