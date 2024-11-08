using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MiniFactura
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {
          
          
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoDelProducto.Text) || string.IsNullOrEmpty(txtPrecioProducto.Text) || string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!int.TryParse(txtPrecioProducto.Text, out int precioUnitario) || precioUnitario <= 0)
            {
                MessageBox.Show("El precio debe ser un número positivo.");
                txtPrecioProducto.Focus();
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero positivo.");
                txtCantidad.Focus();
                return;
            }

            int checkedCount = 0;
            double descuentoSeleccionado = 0;
            //Validación de elección de checklist
            if (rb0.Checked)
            {
                checkedCount++;
                descuentoSeleccionado = 0.00;
            }

            if (rb1.Checked)
            {
                checkedCount++;
                descuentoSeleccionado = 0.01;
            }

            if (rb5.Checked)
            {
                checkedCount++;
                descuentoSeleccionado = 0.05; // Debe ser 0.05, no 0.5
            }

            if (rb10.Checked)
            {
                checkedCount++;
                descuentoSeleccionado = 0.10;
            }

            if (rb15.Checked)
            {
                checkedCount++;
                descuentoSeleccionado = 0.15;
            }

            if (checkedCount == 0)
            {
                MessageBox.Show("Debe seleccionar un porcentaje de descuento.");
                return;
            }
            else if (checkedCount > 1)
            {
                MessageBox.Show("Solo debe seleccionar un porcentaje de descuento.");
                return;
            }

            // Cálculos
            double subtotal = precioUnitario * cantidad;
            double descuento = subtotal * descuentoSeleccionado;
            double iva = subtotal * 0.15;
            double total = subtotal - descuento + iva;

            // Mostrar resultados
            txtSubtotal.Text = subtotal.ToString("F2");
            txtDesceutno.Text = descuento.ToString("F2"); // Corrección de typo: txtDesceutno a txtDescuento
            txtIva.Text = iva.ToString("F2");
            txtTotal.Text = total.ToString("F2");
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           txtIva.Clear();
           txtTotal.Clear();
           txtCantidad.Clear();
            txtDesceutno.Clear();
            txtCodigoDelProducto.Clear();
            txtNombreProducto.Clear();
            txtPrecioProducto.Clear();
            txtSubtotal.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El programa se cerrara");
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los datos han sido guardados");
        }
    }
}
