using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreezzzeMode
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            //Запуск формы с игрой при нажатии на кнопку "Play"
            Game fr2 = new Game();
            this.Hide();
            fr2.ShowDialog();
            fr2.Dispose();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            //Запуск формы с Правилами 
            Rules fr3 = new Rules();
            this.Hide();
            fr3.ShowDialog();
            fr3.Dispose();
            
            

        }

        private void b3_Click(object sender, EventArgs e)
        {
            //Закртие формы
            this.Close();
        }
    }
}
