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
    public partial class updateTransaccion : Form
    {
        public updateTransaccion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            SRCore.wsCoreSoapClient ws = new SRCore.wsCoreSoapClient();
            MessageBox.Show(ws.ActualizarTipoTransaccion(txtDescripcion.Text, int.Parse(txtTipoT_ID.Text)));
            txtDescripcion.Text = string.Empty;
            txtTipoT_ID.Text = string.Empty;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Transaccion transaccion = new Transaccion();
            this.Hide();
            transaccion.Show();
        }
    }
}
