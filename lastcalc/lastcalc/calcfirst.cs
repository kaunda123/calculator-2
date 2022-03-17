using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace lastcalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataColumn ColuDis;
        DataRow Rowse;
        DataTable table = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            string butname = "1";
            buttonSelect(butname);
        }

         //This is button "."
        private void button11_Click(object sender, EventArgs e)
        {
            int i = 0;
            float j=0;
            string textboxVar = textBox1.Text;
            string sec;
            string[] textboxArray;
            //gl = textBox1.Text.Split('+');
            if (textBox1.Text != "" && textBox1.Text.Contains("+") || textBox1.Text.Contains("-") || textBox1.Text.Contains("x") || textBox1.Text.Contains("/"))
            {
                textboxArray = textBox1.Text.Split('+','-','x', '/');
                bool results2 = int.TryParse(textboxArray[1], out i);
                bool results = int.TryParse(textboxVar, out i);
                if (results == true)
                    textBox1.Text = textBox1.Text + ".";
                else if (results2 == true)
                    textBox1.Text = textBox1.Text + ".";
            }
            else if (textBox1.Text != "")
            {
                bool results = int.TryParse(textboxVar, out i);
                if (results == true)
                    textBox1.Text = textBox1.Text + ".";
            }
                
               
        }

         //This is button "-"
        private void button14_Click(object sender, EventArgs e)
        {

            float i = 0;
            string textboxVar = textBox1.Text;
            string sec;
            bool results = float.TryParse(textboxVar, out i);
            if (textBox1.Text != "" && results == true)


                textBox1.Text = textBox1.Text + "-";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string butname = "2";
            buttonSelect(butname);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string butname = "3";
            buttonSelect(butname);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string butname = "4";
            buttonSelect(butname);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string butname = "5";
            buttonSelect(butname);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string butname = "6";
            buttonSelect(butname);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string butname = "7";
            buttonSelect(butname);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string butname = "8";
            buttonSelect(butname);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string butname = "9";
            buttonSelect(butname);
        }

         //This is clear all button
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        public void buttonSelect(string button)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text + button;
            else
                textBox1.Text = button;
        }

         //This is button "+"
        private void button13_Click(object sender, EventArgs e)
        {
            float i = 0;
            string textboxVar=textBox1.Text;
            string sec;
            bool results = float.TryParse(textboxVar, out i);
            if (textBox1.Text != "" && results==true )
              
                
                textBox1.Text = textBox1.Text + "+";
               
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string butname = "0";
            buttonSelect(butname);
        }

         //This is button "x"
        private void button15_Click(object sender, EventArgs e)
        {

            float i = 0;
            string textboxVar = textBox1.Text;
            string sec;
            bool results = float.TryParse(textboxVar, out i);
            if (textBox1.Text != "" && results == true)


                textBox1.Text = textBox1.Text + "x";
        }

         //This is button "/"
        private void button16_Click(object sender, EventArgs e)
        {
            float i = 0;
            string textboxVar = textBox1.Text;
            string sec;
            bool results = float.TryParse(textboxVar, out i);
            if (textBox1.Text != "" && results == true)


                textBox1.Text = textBox1.Text + "/";
        }
        
        //This is button "="
        private void button12_Click(object sender, EventArgs e)
        {
            string textboxVar=textBox1.Text;
            
            string r;
            string[]textboxArray;
            float numg;
            float numg2 = 0;
            float numg3 = 0;
            if ( textBox1.Text.Contains("+"))
            {
                textboxArray = textboxVar.Split('+');
                r = textboxVar;
                //MessageBox.Show(g);
                foreach (string element in textboxArray)
                {
                    float.TryParse(element,out numg);
                    numg2 = numg + numg2;
                    textBox1.Text = numg2.ToString();
                }
                //dataBase(String.Format("insert into Memorycalc(Computation,Answer1) values({0},{1});", r, textBox1.Text));
                dataBase(String.Format("insert into Memorycalc(Computation,Answer1) values({0}{1}{2},{3})", "'", r, "'", textBox1.Text));
                
                
                //string test=(String.Format("insert into Memorycalc(Computation,Answer1) values({0}{1}{2},{3})","'", r,"'", textBox1.Text));
                //int x = 0;
                
            }
            else if (textBox1.Text.Contains("-"))
            {
                textboxArray = textboxVar.Split('-');
                r = textboxVar;
                //MessageBox.Show(h);
                foreach (string element1 in textboxArray)
                {
                    float.TryParse(element1, out numg);
                    numg2 = numg - numg2;
                    
                }
                numg2 = -(numg2);
                numg3 = numg2;
                textBox1.Text = numg3.ToString();
                dataBase(String.Format("insert into Memorycalc(Computation,Answer1) values({0}{1}{2},{3})", "'", r, "'", textBox1.Text));
            }
            else if (textBox1.Text.Contains("x"))
            {
                textboxArray = textboxVar.Split('x');
                r = textboxVar;
                //MessageBox.Show(g);
                numg2 = 1;
                foreach (string element2 in textboxArray)
                {
                    float.TryParse(element2, out numg);
                    numg2 = numg * numg2;
                    textBox1.Text = numg2.ToString();
                }
                dataBase(String.Format("insert into Memorycalc(Computation,Answer1) values({0}{1}{2},{3})", "'", r, "'", textBox1.Text));
            }
            else if (textBox1.Text.Contains("/"))
            {
                textboxArray = textboxVar.Split('/');
                r = textboxVar;
                //MessageBox.Show(g);
                numg2 = 1;
                numg3 = 0;
                foreach (string element3 in textboxArray)
                {
                    float.TryParse(element3, out numg);
                    numg2 = numg / numg2;
                }
                numg2 = 1 / (numg2);
                numg3 = numg2;
                textBox1.Text = numg3.ToString();
                dataBase(String.Format("insert into Memorycalc(Computation,Answer1) values({0}{1}{2},{3})", "'", r, "'", textBox1.Text));
            }
            
        }
        private void dataBase(string SelectCommandText)
        {
            try
            {
                string selectConnection="Data Source=GGGJK-PC\\ SQLEXPRESS;Initial Catalog=Customer;Integrated Security=True";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(SelectCommandText, selectConnection);
                
                dataAdapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }
        
         //This is CE Button(deletes character one by one
        private void button18_Click(object sender, EventArgs e)
        {
            string m = textBox1.Text;
            string d="";
            if(textBox1.Text.Length>1)
            {
                for (int i = 0; i < m.Length - 1; i++)
                {
                    d = d + m[i];
                    textBox1.Text = d;
                }
            }
            else if(textBox1.Text.Length==1)
            {
                m = "";
                textBox1.Text = m;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //int r;
            //int.TryParse(dataBase("Select Answer From Memorycalc Where Answer1="23"), out r);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            dataBase("Select Computation,Answer1 from Memorycalc");
            int numberOfRows= 0;
            while(numberOfRows<30)
            {
                string h= table.Rows[2].ToString();
                Rowse = table.Rows[2];
                
                textBox1.Text = h;
                
                
                numberOfRows++;
            }
            
        }
        public override string ToString()
        {
            if(button20.Enabled==true)
            {
                
                return String.Format("{0}", table.Rows[2]);
                
            } 
            else
                return base.ToString();
        }
    }
}
