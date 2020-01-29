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

namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEdicion_Click(object sender, EventArgs e)
        {
            GBdatospersonales.Enabled = true;
            GBdatosbancarios.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            GBdatospersonales.Enabled = false;
            GBdatosbancarios.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtSaldo.Text = "";
            txtCantidad.Text = "";
            txtApellido.Text = "" ;
            txtDireccion.Text = "";
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            string[] lineas = { txtNombre.Text, txtApellido.Text, txtDireccion.Text, dateTimePickerNaciemiento.ToString(), "Femenino", txtCantidad.Text, dateTimePickerEjecucion.ToString() };
            using (StreamWriter Salida = new StreamWriter("C:\\Users\\user\\source\\repos\\Examen_taller_totalizador\\AquiSeGuarda.txt"))
            {
                foreach (String linea in lineas)
                {
                    Salida.WriteLine(linea);
                }
            }
        }
        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
