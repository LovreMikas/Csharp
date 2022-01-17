using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string Prikazi(string a, string b, string c)
        {
            string prikazi = string.Format("**{0. {1}. {2}.**", a, b, c);
            return prikazi;
        }

        private void button1_Click(object sender, EventArgs e)
            {
                string a = textBox1.Text;
                string b = textBox2.Text;
                string c = textBox3.Text;

                string d = textBox4.Text;
                string l = textBox5.Text;
                string f = textBox1.Text;

            label4.Text = Prikazi(a, b, c);
            label5.Text = Prikazi(d, l, f);
        }
    }
}
