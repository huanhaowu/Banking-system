using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreAPP.Usuarios
{
    public partial class Updt : Form
    {
        public Updt()
        {
            InitializeComponent();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            SRCore.wsCoreSoapClient ws = new SRCore.wsCoreSoapClient();
            MessageBox.Show(ws.ActualizarUsuario(int.Parse(txtUsuario_ID.Text), int.Parse(txtCliente_ID.Text), txtUsuario.Text, txtClave.Text));
            txtUsuario_ID.Text = string.Empty;
            txtCliente_ID.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtClave.Text = string.Empty;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            UsuariosV usuariosV = new UsuariosV();
            this.Hide();
            usuariosV.Show();
        }
    }
}
