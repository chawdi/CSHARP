using System;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b, c;
        bool znak = true;

        private void button0_Click(object sender, EventArgs e)
        {
            text1.Text += 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          text1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
         text1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            text1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            text1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            text1.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            text1.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            text1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            text1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            text1.Text += 9;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            a = int.Parse(text1.Text);
            text1.Clear();
            c = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void buttonDelit_Click(object sender, EventArgs e)
        {
            a = int.Parse(text1.Text);
            text1.Clear();
            c = 2;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void buttonUmnoz_Click(object sender, EventArgs e)
        {
            a = int.Parse(text1.Text);
            text1.Clear();
            c = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            a = int.Parse(text1.Text);
            text1.Clear();
            c = 4;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            text1.Text = "";
            label1.Text = "";
        }

        private void buttonRavno_Click(object sender, EventArgs e)
        {
            calc();
            label1.Text = "";
        }
        private void calc()
        {
            switch (c)
            {
                case 1:
                    b = a + int.Parse(text1.Text);
                    text1.Text = b.ToString();
                break;
                case 2:
                    b = a / int.Parse(text1.Text);
                    text1.Text = b.ToString();
                    break;
                case 3:
                    b = a * int.Parse(text1.Text);
                    text1.Text = b.ToString();
                    break;
                case 4:
                    b = a - int.Parse(text1.Text);
                    text1.Text = b.ToString();
                    break;
                    default:
                        break;
            }
        }
    }
}
