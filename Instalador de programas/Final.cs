using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instalador_de_programas
{
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
