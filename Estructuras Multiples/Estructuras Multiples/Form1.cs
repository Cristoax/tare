using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras_Multiples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Dia = int.Parse(txtNumero.Text);
            if (Dia <= 0 || Dia > 7)
            {
                MessageBox.Show("Ingrese un valor entre 1 y 7");
            }
            if (Dia == 1)
            {
                txtDiaDeLaSemana.Text = "Lunes";
            }
            if (Dia == 2)
            {
                txtDiaDeLaSemana.Text = "Martes";
            }
            if (Dia == 3)
            {
                txtDiaDeLaSemana.Text = "Miercoles";
            }
            if (Dia == 4)
            {
                txtDiaDeLaSemana.Text = "Jueves";
            }
            if (Dia == 5)
            {
                txtDiaDeLaSemana.Text = "Viernes";
            }
            if (Dia == 6)
            {
                txtDiaDeLaSemana.Text = "sabado";
            }
            if (Dia == 7)
            {
                txtDiaDeLaSemana.Text = "Domingo";
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDiaDeLaSemana.Clear();
            txtNumero.Clear();
            txtNumero.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El programa se cerrara");
            Close();
        }
    }
}
