using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria21Abril
{
    public partial class frmPrincipal : Form
    {
        private double[] precios = {1.25, 2.25, 1.75, 0.75};
        private double[] subtotal = {0, 0, 0, 0};
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblPrecioPapa.Text = "$" + precios[0];
            lblPrecioCarne.Text = "$" + precios[1];
            lblPrecioPollo.Text = "$" + precios[2];
            lblPrecioVegetales.Text = "$" + precios[3];
        }

        private void actualizarTotal()
        {
            double total = subtotal.Sum();
            if (radEmpleado.Checked == true)
            {
                total *= 0.90;
            }
            lblTotal.Text = "Total: $" + Math.Round(total, 2);
        }

        private void nudCantidadPapa_ValueChanged(object sender, EventArgs e)
        {
            subtotal[0] = Convert.ToInt32(nudCantidadPapa.Value) * precios[0];
            lblSubtotalPapa.Text = "$" + subtotal[0];
            actualizarTotal();
        }

        private void nudCantidadCarne_ValueChanged(object sender, EventArgs e)
        {
            subtotal[1] = Convert.ToInt32(nudCantidadCarne.Value) * precios[1];
            lblSubtotalCarne.Text = "$" + subtotal[1];
            actualizarTotal();
        }

        private void nudCantidadPollo_ValueChanged(object sender, EventArgs e)
        {
            subtotal[2] = Convert.ToInt32(nudCantidadPollo.Value) * precios[2];
            lblSubtotalPollo.Text = "$" + subtotal[2];
            actualizarTotal();
        }

        private void nudCantidadVegetales_ValueChanged(object sender, EventArgs e)
        {
            subtotal[3] = Convert.ToInt32(nudCantidadVegetales.Value) * precios[3];
            lblSubtotalVegetales.Text = "$" + subtotal[3];
            actualizarTotal();
        }

        private void radEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            actualizarTotal();
        }

        private void limpiar()
        {
            nudCantidadPapa.Value = 0;
            nudCantidadCarne.Value = 0;
            nudCantidadPollo.Value = 0;
            nudCantidadVegetales.Value = 0;
            txtCliente.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            //No ha puesto su nombre
            if (txtCliente.Text.Length < 5)
            {
                MessageBox.Show("No ha escrito su nombre!", "Cafetería UCA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (subtotal.Sum() <= 0)
            {
                MessageBox.Show("No ha comprado nada!", "Cafetería UCA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double d_subtotal = Math.Round(subtotal.Sum(), 2);
                double d_descuento = Math.Round(radEmpleado.Checked ? d_subtotal * 0.1 : 0, 2);
                double d_total = Math.Round(d_subtotal - d_descuento, 2);

                string mensaje = String.Format("Bienvenido {0}!\nSubtotal: ${1}\n" +
                                               "Descuento: ${2}\nTotal: ${3}\n" +
                                               "Forma de pago: {4}\nGracias por su compra!",
                    txtCliente.Text, d_subtotal, d_descuento, d_total,
                    radEfectivo.Checked ? "Efectivo" : "Tarjeta");
                    
                MessageBox.Show(mensaje, "Cafetería UCA",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                limpiar();
            }
        }
    }
}