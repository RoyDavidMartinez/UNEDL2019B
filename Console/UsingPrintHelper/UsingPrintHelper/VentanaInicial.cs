using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingPrintHelper
{
    public partial class VentanaInicial : Form
    {
        public VentanaInicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 forma = new AboutBox1();
            //forma.MdiParent = this;
            forma.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printHelperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintHelper helper = new PrintHelper();
            helper.Show();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroAlumno registro = new RegistroAlumno();
            registro.Show();
        }
    }
}
