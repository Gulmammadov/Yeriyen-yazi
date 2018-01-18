using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20171011Win_YeriyenYazi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int say = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string s1, s2;
            s1 = textBox1.Text;
            s2 = textBox2.Text;

            /*if (s1 == s2)
            {
                label3.Text = "Beraberdir";
            }
            else
            {
                label3.Text = "Beraber deyil";
            }
            */
            if (String.Compare(s1,s2,true,System.Globalization.CultureInfo.GetCultureInfo("Az"))==0)
            {
                label3.Text = "Beraberdir";
            }
             
            else if (String.Compare(s1, s2) > 0)
            {
                label3.Text = "Boyukdu";
            }
            else
            {
                label3.Text = "Kicikdi";
            }
            
            
           /* if (s1.Equals(s2))
            {
                label3.Text = "Beraberdir";
            }
            else
            {
                label3.Text = "Beraber deyil";
            }*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string s = label4.Text.Substring(1);
            s += label4.Text.Substring(0, 1);
            label4.Text = s;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
