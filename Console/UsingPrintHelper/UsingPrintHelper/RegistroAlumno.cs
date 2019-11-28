using System;
using System.Collections;
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
    public partial class RegistroAlumno : Form
    {
        public RegistroAlumno()
        {
            InitializeComponent();
        }
        
        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            String nombre = NombreTxt.Text;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            IMpresion objeto = new IMpresion();
                       objeto.Show();
            objeto.Nombrelbl.Text = NombreTxt.Text;
            objeto.gradolbl.Text = GradoTxt.Text;
            objeto.grupolbl.Text = GrupoTxt.Text;
            objeto.matriculalbl.Text = MatriculaTxt.Text;
            if (BoxJava.Checked)
            {
                objeto.lbljava.Text = BoxJava.Text;
            }
            if (BoxPython.Checked)
            {
                objeto.lblpython.Text = BoxPython.Text;
            }
            if (BoxRuby.Checked)
            {
                objeto.lblruby.Text = BoxRuby.Text;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
