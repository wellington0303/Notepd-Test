using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade05_c_
{
    public partial class Form1 : Form
    {
        private string _textContent = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _textContent = textBox1.Text;
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void editarNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


    }
}
