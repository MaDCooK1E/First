using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            TextBox pole = sender as TextBox;
            string tx = pole.Text;
            int d1 = tx.Length;
            int n = tx.IndexOf(",");
            if (!(Char.IsDigit(c) || (c == ',' && n == -1 && d1 == 0) ||
                    (c == '-' && d1 == 0) ||
                    (c == '+' && d1 == 0)))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string str;
                str = textBox1.Text;
                double x = Convert.ToDouble(str);
                str = textBox2.Text;
                double y = Convert.ToDouble(str);
                double z = 9 * Math.Pow(x, 4) - ((Math.Sqrt(x + Math.Abs(y))) / (y + 7));
                str = Convert.ToString(Math.Round(z, 3));
                textBox3.Text = str;
            }
            catch { MessageBox.Show("Error"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }
    }
}
