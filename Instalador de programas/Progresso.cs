using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instalador_de_programas
{
    public partial class Progresso : Form
    {
        public Progresso()
        {
            InitializeComponent();
        }

        private void CopyAll(string sourceDir, string destDir)
        {
            Directory.CreateDirectory(destDir);
            string[] files = Directory.GetFiles(sourceDir, "*.*", SearchOption.AllDirectories);
            int fileCount = files.Length;
            int currentFile = 0;
            foreach (string file in files)
            {
                currentFile++;
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(destDir, fileName);
                File.Copy(file, destFile, true);
                double percentComplete = (double)currentFile / (double)fileCount * 100;
                progressBar2.Value = (int)percentComplete;

            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicial inicial = new Inicial();
            inicial.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string sourceDir = ".\\Arquivos";
                    string destDir = fbd.SelectedPath + ".\\Master Softwares";
                    CopyAll(sourceDir, destDir);
                    this.Hide();
                    Final final = new Final();
                    final.Show();
                } 
                else if (result == DialogResult.Cancel)
                {
                    this.Hide();
                    Progresso progresso = new Progresso();
                    progresso.Show();  
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
