using CoreAPP.SRCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreAPP.Transacciones
{
    public partial class CrearTransaccion : Form
    {
        public CrearTransaccion()
        {
            InitializeComponent();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            SRCore.wsCoreSoapClient ws = new SRCore.wsCoreSoapClient();
            MessageBox.Show(ws.CrearTipoTransaccion(txtDescripcion.Text));
            txtDescripcion.Text = string.Empty;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Transaccion transaccion = new Transaccion();
            this.Hide();
            transaccion.Show();
        }
    }
}
