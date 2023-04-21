using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja.Pantalla
{
    public partial class Retiro2 : Form
    {
        public Retiro2()
        {
            InitializeComponent();
        }

        private void bttDepositar2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposito deposito = new Deposito();
            if (deposito.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bttPrestamos2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prestamos prestamos = new Prestamos();
            if (prestamos.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bttCancelarR_Click(object sender, EventArgs e)
        {
            /*
            txt1.Clear();
            txt10.Clear();
            txt5.Clear();
            txt25.Clear();
            txt50.Clear();
            txt100.Clear();
            txt200.Clear();
            txt1000.Clear();
            txt2000.Clear();            
            txtMontoEspecifico.Clear();*/
        }

        private void txt50_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt100_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt200_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt500_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt1000_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt2000_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt25_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMontoEspecifico_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void grupoRetiro2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttConfirmarD_Click(object sender, EventArgs e)
        {

        }

        private void bttCancelarD_Click(object sender, EventArgs e)
        {
            txtMontoD.Clear();
            txtDescripD.Clear();
            txtCuentaD.Clear();
        }

        private void bttReciboD_Click(object sender, EventArgs e)
        {

        }

        private void txtMontoD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposito deposito = new Deposito();
            if (deposito.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bttPrestamos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prestamos prestamos = new Prestamos();
            if (prestamos.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }

        }
    }
}
