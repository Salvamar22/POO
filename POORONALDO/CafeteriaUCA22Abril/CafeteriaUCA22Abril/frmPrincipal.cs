using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaUCA22Abril
{
    public partial class frmPrincipal : Form
    {
        private double[] precios = {1.25, 2.25, 1.75, 0.75};
        private double[] subtotales = {0, 0, 0, 0};
        
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

        private void nudCantidadPapa_ValueChanged(object sender, EventArgs e)
        {
            subtotales[0] = Convert.ToInt32(nudCantidadPapa.Value) * precios[0];
            lblSubtotalPapa.Text = "$" + subtotales[0];
            actualizarTotal();
        }

        private void nudCantidadCarne_ValueChanged(object sender, EventArgs e)
        {
            subtotales[1] = Convert.ToInt32(nudCantidadCarne.Value) * precios[1];
            lblSubtotalCarne.Text = "$" + subtotales[1];
            actualizarTotal();
        }

        private void nudCantidadPollo_ValueChanged(object sender, EventArgs e)
        {
            subtotales[2] = Convert.ToInt32(nudCantidadPollo.Value) * precios[2];
            lblSubtotalPollo.Text = "$" + subtotales[2];
            actualizarTotal();
        }

        private void nudCantidadVegetales_ValueChanged(object sender, EventArgs e)
        {
            subtotales[3] = Convert.ToInt32(nudCantidadVegetales.Value) * precios[3];
            lblSubtotalVegetales.Text = "$" + subtotales[3];
            actualizarTotal();
        }

        private void actualizarTotal()
        {
            double total = subtotales.Sum();

            if (radEmpleado.Checked == true) total *= 0.9;

            lblTotal.Text = "Total: $" + Math.Round(total, 2);
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
            txtNombre.Text = "";//txtNombre.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length < 6)
            {
                MessageBox.Show("Debe digitar su nombre!", "Cafetería UCA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (subtotales.Sum() <= 0)
            {
                MessageBox.Show("Debe haber seleccionado algo!", "Cafetería UCA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double subtotal = Math.Round(subtotales.Sum(), 2);
                double descuento = Math.Round(radEmpleado.Checked ? 0.1 * subtotal : 0, 2);
                double total = subtotal - descuento;

                string mensaje = String.Format("Bienvenido {0}\nSubtotal: ${1}\n" +
                                               "Descuento: ${2}\nTotal: ${3}\n" +
                                               "Forma de pago: {4}\nGracias por su compra!",
                    txtNombre.Text, subtotal, descuento, total,
                    radEfectivo.Checked ? "Efectivo" : "Tarjeta");

                MessageBox.Show(mensaje, "Cafetería UCA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                limpiar();
            }
        }
    }
}