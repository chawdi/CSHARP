using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace FreezzzeMode
{    
    public partial class Game : Form
    {
        //Set variables
        int ch = 0;
        int a = 0; 

        public Game()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            //When you click on the Start button, the textboxes disappear and labels with numbers appear to remember for a period of time
            te1.Visible = false;
            te2.Visible = false;
            te3.Visible = false;
            te4.Visible = false;
            l1.Visible = true;
            l2.Visible = true;
            l3.Visible = true;
            l4.Visible = true;
            t1.Enabled = true;
            t1.Start();
            b2.Enabled = false;
            b1.Enabled = false;
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            //generate numbers in the label when the timer starts
            Random rn = new Random();
            ch++;
            if (a == 0)
            {
                if (ch < 2)
                {
                    l1.Text = rn.Next(10).ToString();
                    l2.Text = rn.Next(10).ToString();
                    l3.Text = rn.Next(10).ToString();
                    l4.Text = rn.Next(10).ToString();

                }
                //When the time in the timer ends, the labels with numbers disappear and textboxes appear
                if ((ch > 3 && ch < 5))
                {
                    
                    l1.Visible = false;
                    l2.Visible = false;
                    l3.Visible = false;
                    l4.Visible = false;
                    te1.Visible = true;
                    te2.Visible = true;
                    te3.Visible = true;
                    te4.Visible = true;
                    b1.Enabled = true;
                    t1.Stop();
                    ch = 0;
                }
            } 
            if(a == 1)
            {
                if (ch < 2)
                {
                    l1.Text = rn.Next(20).ToString();
                    l2.Text = rn.Next(20).ToString();
                    l3.Text = rn.Next(20).ToString();
                    l4.Text = rn.Next(20).ToString();

                }
                //When the time in the timer ends, the labels with numbers disappear and textboxes appear
                if ((ch > 3 && ch < 5))
                {
                    
                    l1.Visible = false;
                    l2.Visible = false;
                    l3.Visible = false;
                    l4.Visible = false;
                    te1.Visible = true;
                    te2.Visible = true;
                    te3.Visible = true;
                    te4.Visible = true;
                    b1.Enabled = true;
                    t1.Stop();
                    ch = 0;
                }
            }
            if (a == 2)
            {
                if (ch < 2)
                {
                    l1.Text = rn.Next(50).ToString();
                    l2.Text = rn.Next(50).ToString();
                    l3.Text = rn.Next(50).ToString();
                    l4.Text = rn.Next(50).ToString();

                }
                //When the time in the timer ends, the labels with numbers disappear and textboxes appear
                if ((ch > 3 && ch < 5))
                {
                    
                    l1.Visible = false;
                    l2.Visible = false;
                    l3.Visible = false;
                    l4.Visible = false;
                    te1.Visible = true;
                    te2.Visible = true;
                    te3.Visible = true;
                    te4.Visible = true;
                    b1.Enabled = true;
                    t1.Stop();
                    ch = 0;
                }
            }
            if (a == 3)
            {
                if (ch < 2)
                {
                    l1.Text = rn.Next(100).ToString();
                    l2.Text = rn.Next(100).ToString();
                    l3.Text = rn.Next(100).ToString();
                    l4.Text = rn.Next(100).ToString();

                }
                //When the time in the timer ends, the labels with numbers disappear and textboxes appear
                if ((ch > 3 && ch < 5))
                {
                    
                    l1.Visible = false;
                    l2.Visible = false;
                    l3.Visible = false;
                    l4.Visible = false;
                    te1.Visible = true;
                    te2.Visible = true;
                    te3.Visible = true;
                    te4.Visible = true;
                    b1.Enabled = true;
                    t1.Stop();
                    ch = 0;
                }
            }
            if (a == 4)
            {
                if (ch < 2)
                {
                    l1.Text = rn.Next(150).ToString();
                    l2.Text = rn.Next(150).ToString();
                    l3.Text = rn.Next(150).ToString();
                    l4.Text = rn.Next(150).ToString();

                }
                //When the time in the timer ends, the labels with numbers disappear and textboxes appear
                if ((ch > 3 && ch < 5))
                {
                    
                    l1.Visible = false;
                    l2.Visible = false;
                    l3.Visible = false;
                    l4.Visible = false;
                    te1.Visible = true;
                    te2.Visible = true;
                    te3.Visible = true;
                    te4.Visible = true;
                    b1.Enabled = true;
                    t1.Stop();
                    ch = 0;
                }
            }
            if (a == 5)
            {
                if (ch < 2)
                {
                    l1.Text = rn.Next(200).ToString();
                    l2.Text = rn.Next(200).ToString();
                    l3.Text = rn.Next(200).ToString();
                    l4.Text = rn.Next(200).ToString();

                }
                //When the time in the timer ends, the labels with numbers disappear and textboxes appear
                if ((ch > 3 && ch < 5))
                {
                    
                    l1.Visible = false;
                    l2.Visible = false;
                    l3.Visible = false;
                    l4.Visible = false;
                    te1.Visible = true;
                    te2.Visible = true;
                    te3.Visible = true;
                    te4.Visible = true;
                    b1.Enabled = true;
                    t1.Stop();
                    ch = 0;
                }
            }
            if (a == 6)
            {
                if (ch < 2)
                {
                    l1.Text = rn.Next(250).ToString();
                    l2.Text = rn.Next(250).ToString();
                    l3.Text = rn.Next(250).ToString();
                    l4.Text = rn.Next(250).ToString();

                }
                //When the time in the timer ends, the labels with numbers disappear and textboxes appear
                if ((ch > 3 && ch < 5))
                {
                    
                    l1.Visible = false;
                    l2.Visible = false;
                    l3.Visible = false;
                    l4.Visible = false;
                    te1.Visible = true;
                    te2.Visible = true;
                    te3.Visible = true;
                    te4.Visible = true;
                    b1.Enabled = true;
                    t1.Stop();
                    ch = 0;
                }
            }
            if (a == 7)
            {
                if (ch < 2)
                {
                    l1.Text = rn.Next(300).ToString();
                    l2.Text = rn.Next(300).ToString();
                    l3.Text = rn.Next(300).ToString();
                    l4.Text = rn.Next(300).ToString();

                }
                //When the time in the timer ends, the labels with numbers disappear and textboxes appear
                if ((ch > 3 && ch < 5))
                {
                    
                    l1.Visible = false;
                    l2.Visible = false;
                    l3.Visible = false;
                    l4.Visible = false;
                    te1.Visible = true;
                    te2.Visible = true;
                    te3.Visible = true;
                    te4.Visible = true;
                    b1.Enabled = true;
                    t1.Stop();
                    ch = 0;
                }
            }
            if (a == 8)
            {
                if (ch < 2)
                {
                    l1.Text = rn.Next(350).ToString();
                    l2.Text = rn.Next(350).ToString();
                    l3.Text = rn.Next(350).ToString();
                    l4.Text = rn.Next(350).ToString();

                }
                //When the time in the timer ends, the labels with numbers disappear and textboxes appear
                if ((ch > 3 && ch < 5))
                {
                    
                    l1.Visible = false;
                    l2.Visible = false;
                    l3.Visible = false;
                    l4.Visible = false;
                    te1.Visible = true;
                    te2.Visible = true;
                    te3.Visible = true;
                    te4.Visible = true;
                    b1.Enabled = true;
                    t1.Stop();
                    ch = 0;
                }
            }
            if (a == 9)
            {
                if (ch < 2)
                {
                    l1.Text = rn.Next(400).ToString();
                    l2.Text = rn.Next(400).ToString();
                    l3.Text = rn.Next(400).ToString();
                    l4.Text = rn.Next(400).ToString();

                }
                //When the time in the timer ends, the labels with numbers disappear and textboxes appear
                if ((ch > 3 && ch < 5))
                {
                    
                    l1.Visible = false;
                    l2.Visible = false;
                    l3.Visible = false;
                    l4.Visible = false;
                    te1.Visible = true;
                    te2.Visible = true;
                    te3.Visible = true;
                    te4.Visible = true;
                    b1.Enabled = true;
                    t1.Stop();
                    ch = 0;
                }
            }
            if (a == 10)
            {
                if (ch < 2)
                {
                    l1.Text = rn.Next(450).ToString();
                    l2.Text = rn.Next(450).ToString();
                    l3.Text = rn.Next(450).ToString();
                    l4.Text = rn.Next(450).ToString();

                }
                //When the time in the timer ends, the labels with numbers disappear and textboxes appear
                if ((ch > 3 && ch < 5))
                {
                    
                    l1.Visible = false;
                    l2.Visible = false;
                    l3.Visible = false;
                    l4.Visible = false;
                    te1.Visible = true;
                    te2.Visible = true;
                    te3.Visible = true;
                    te4.Visible = true;
                    b1.Enabled = true;
                    t1.Stop();
                    ch = 0;
                }
            }
            if (a > 10)
            {
                if (ch < 2)
                {
                    l1.Text = rn.Next(1000).ToString();
                    l2.Text = rn.Next(1000).ToString();
                    l3.Text = rn.Next(1000).ToString();
                    l4.Text = rn.Next(1000).ToString();

                }
                //When the time in the timer ends, the labels with numbers disappear and textboxes appear
                if ((ch > 3 && ch < 5))
                {

                    l1.Visible = false;
                    l2.Visible = false;
                    l3.Visible = false;
                    l4.Visible = false;
                    te1.Visible = true;
                    te2.Visible = true;
                    te3.Visible = true;
                    te4.Visible = true;
                    b1.Enabled = true;
                    t1.Stop();
                    ch = 0;
                }
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            //When you click on the Answer button, the answers are compared
            if (l1.Text == te1.Text && l2.Text == te2.Text && l3.Text == te3.Text && l4.Text == te4.Text)
            {
                l5.Visible = true;
                a = a + 1; 
                l7.Text = Convert.ToString(a);
                b2.Enabled = true;
                te1.Text = "";
                te2.Text = "";
                te3.Text = "";
                te4.Text = "";
            }
            else
            {
                l8.Visible = true;
                StatClass.sim = Convert.ToInt16(a);
                Score fr4 = new Score();
                fr4.ShowDialog();
                this.Hide();
                Application.Exit();

            }
            l1.Text = "";
            l2.Text = "";
            l3.Text = "";
            l4.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            l7.Text = Convert.ToString(a);
            
        }

        private void b3_Click(object sender, EventArgs e)
        {
            MainMenu fr1 = new MainMenu();
            fr1.ShowDialog();
            this.Hide();
            Application.Exit();
        }
    }
}
