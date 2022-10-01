using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesgloseMonedas
{
    public partial class DesgloseMonedas : Form
    {
        int B2000, B1000, B500, B200, B100, B50, B25, B10, B5, B1, cantidad;

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    this.txtCantidad.Focus();
                }
            }
        }

        public DesgloseMonedas()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
               cantidad = int.Parse(txtCantidad.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar una cantidad Valida.");
                return;
            }

            //Billetes de 2000
            if (cantidad >= 2000)
            {
                B2000 = cantidad / 2000;
                txtBillete2000.Text = B2000.ToString();
                cantidad = cantidad - (B2000 * 2000);
            }

            //Billetes de 1000
            if (cantidad >= 1000)
            {
                B1000 = cantidad / 1000;
                txtBillete1000.Text = B1000.ToString();
                cantidad = cantidad - (B1000 * 1000);
            }

            //Billetes de 500
            if (cantidad >= 500)
            {
                B500 = cantidad / 500;
                txtBillete500.Text = B500.ToString();
                cantidad = cantidad - (B500 * 500);
            }

            //Billetes de 200
            if (cantidad >= 200)
            {
                B200 = cantidad / 200;
                txtBillete200.Text = B200.ToString();
                cantidad = cantidad - (B200 * 200);
            }

            //Billetes de 100
            if (cantidad >= 100)
            {
                B100 = cantidad / 100;
                txtBillete100.Text = B100.ToString();
                cantidad = cantidad - (B100 * 100);
            }

            //Billetes de 50
            if (cantidad >= 50)
            {
                B50 = cantidad / 50;
                txtBillete50.Text = B50.ToString();
                cantidad = cantidad - (B50 * 50);
            }

            //Monedas de 25
            if (cantidad >= 25)
            {
                B25 = cantidad / 25;
                txtMoneda25.Text = B25.ToString();
                cantidad = cantidad - (B25 * 25);
            }

            //Monedas de 10
            if (cantidad >= 10)
            {
                B10 = cantidad / 10;
                txtMoneda10.Text = B10.ToString();
                cantidad = cantidad - (B10 * 10);
            }

            //Monedas de 5
            if (cantidad >= 5)
            {
                B5 = cantidad / 5;
                txtMoneda5.Text = B5.ToString();
                cantidad = cantidad - (B5 * 5);
            }

            //Monedas de 1
            if (cantidad >= 1)
            {
                B1 = cantidad / 1;
                txtMoneda1.Text = B1.ToString();
                cantidad = cantidad - (B1 * 1);
            }
        }
    }
}
