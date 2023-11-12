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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Instalador_de_programas
{
    public partial class Confguracoes : Form
    {
        public Confguracoes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Progresso form4 = new Progresso();
            form4.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Inicial form1 = new Inicial();
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}

