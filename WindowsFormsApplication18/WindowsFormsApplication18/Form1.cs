using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string SelectedZnak;
        double a, b, c;

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1, 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Text = "";
            SelectedZnak = "plus";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Text = "";
            SelectedZnak = "minus";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Text = "";
            SelectedZnak = "umnozhit";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Text = "";
            SelectedZnak = "delenie";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (SelectedZnak == "plus")
            {
                b = double.Parse(textBox1.Text);
                c = a + b;
                textBox1.Text = c.ToString();
            }
            if (SelectedZnak == "minus")
            {
                b = double.Parse(textBox1.Text);
                c = a - b;
                textBox1.Text = c.ToString();
            }
            if (SelectedZnak == "umnozhit")
            {
                b = double.Parse(textBox1.Text);
                c = a * b;
                textBox1.Text = c.ToString();
            }
            if (SelectedZnak == "delenie")
            {
                b = double.Parse(textBox1.Text);
                c = a / b;
                textBox1.Text = c.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text == "") // Делаем так, чтобы программа не крашилась.
            {
                button3.Enabled = false;
                button4.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
                button4.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
            }
        }
    }
}
