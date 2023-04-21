using CoreAPP.SRCore;
using CoreAPP.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreAPP.Cuenta
{
    public partial class Movimientos : Form
    {
        public Movimientos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCuentaID usuario = new txtCuentaID();
            this.Hide();
            usuario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SRCore.wsCoreSoapClient ws = new SRCore.wsCoreSoapClient();
            dgvMovimientos.DataSource = ws.ConsultarMovimientos(int.Parse(txtCuenta_ID.Text));
        }
    }
}
