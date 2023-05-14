using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreezzzeMode
{
    public partial class Score : Form
    {
        public Score()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game fr2 = new Game();
            fr2.ShowDialog();
            this.Hide();
            Application.Exit();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //Запись в файл лучшего результата и последующий вывод его
            l33.Text = StatClass.sim.ToString();
            int highscore = Properties.Settings.Default.Highscore;
            if (StatClass.sim > Properties.Settings.Default.Highscore)
                Properties.Settings.Default.Highscore = StatClass.sim;
            l4.Text = Properties.Settings.Default.Highscore.ToString();
            Properties.Settings.Default.Save();

        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }
    }
}
